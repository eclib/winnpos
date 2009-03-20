/*
 * Created by INNOVIC
 * User: Eduardo Llanquileo  
 * Date: 10/3/2009
 * Time: 22:40 PM
 * 
 */

using System;
using MySql.Data.MySqlClient;
using Negocio;
using System.IO;
using Rutinas;
using System.Windows.Forms;

namespace POSinnovic
{
	
	/// <summary>
	/// Description of impresion.
	/// </summary>
	public class impresion
	{
		public impresion()
		{		
		}
		public void gentxt(int id, POS Padre, CierreVenta Madre)
		{
			//MessageBox.Show("ACÀ");
			//Preparo Conexión
			//int pag = 0;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			neg.user    = "innovic";
			neg.pass    = "1nn0v1c";
			//Consulto por numero venta enviado - DETALLE
			string select = "select ven.FECHA as fecha, ven.HORA as hora, usr.USUARIO as usr, usr.ID as usrid, fpag.CODIGO as tip_pago ";
			select += "from pos_venta ven,pos_usuario usr, pos_venta_detalle_pago pag, pos_formas_pago fpag ";
			select += "where ven.ID = '"+id+"' ";
			select += "and ven.USR_VEN = usr.ID and pag.TIPO_PAGO = fpag.ID ";
			//select += "and ven.NUMERO ="+ num_vta;
			MySqlDataReader reader = neg.select(select);
			reader.Read();
			
			
			//Busco articulos vendidos con el ID del encabezado
			select = "select pre.DESCRIPCION as descr, det.CANTIDAD as can, det.PRECIO_UNITARIO as unit, det.TOTAL as total ";
			select += "from pos_venta_detalle det, pos_lista_precio pre ";
			select += "where ID_VENTA = '"+id+"' ";
			select += "and det.CODIGO = pre.CODIGO ";
			MySqlDataReader reader2 = neg.select(select);
			
			//SUCURSAL
			select = "select N_SUCURSAL as num,  NO_SUCURSAL as nom, DIRECCION as dir from pos_parametros ";
			MySqlDataReader reader3 = neg.select(select);
			reader3.Read();
			System.IO.StreamWriter writer;
			writer = System.IO.File.CreateText("BOLETA.txt");
			string fecha = reader["fecha"].ToString();
			int num_bol = numero_boleta(neg, id);
			int total = 0;
			
			encabezado_bol (writer, fecha, num_bol,reader["usrid"].ToString(),reader["usr"].ToString());
			int i = 0;	
			while(reader2.Read())
			{
				writer.WriteLine(String.Format("{0,-30}",reader2["descr"])+String.Format("{0,-6}",reader2["can"])+String.Format("{0,-8}",reader2["unit"])+String.Format("{0,-6}",reader2["total"]));
				total += (int)reader2["total"];
				i ++;
				if (i == 10)
				{
					fin_bol(writer, total, reader["tip_pago"].ToString(), reader["hora"].ToString(), reader3["num"].ToString(), reader3["nom"].ToString(), reader3["dir"].ToString());
					total = 0;
					salta_linea(writer, 10);
					num_bol = numero_boleta(neg);
					encabezado_bol (writer, fecha, num_bol,reader["usrid"].ToString(),reader["usr"].ToString());
					i=0;
				}
			}
			salta_linea(writer, 9-i);
			fin_bol(writer, total, reader["tip_pago"].ToString(), reader["hora"].ToString(), reader3["num"].ToString(), reader3["nom"].ToString(), reader3["dir"].ToString());
			writer.Close();
			
			//funcion imprimir
			if (imprimir("BOLETA.txt") == false)
			{
				MessageBox.Show("ERROR AL IMPRIMIR   :-S  ");
			}
			
			//Como esta imprimida la boleta ahora es valida
			remover_borrador(id, neg);
			Madre.Close();
			Padre.Cancela();
			Padre.calctotal();

		}
		
		//Imprime encabezado boleta
		public void encabezado_bol (System.IO.StreamWriter writer, string fecha, int num_bol, string usr_id,string usr_nom)
		{
			writer.WriteLine("Boleta: "+String.Format("{0,-20}",num_bol)+fecha.Substring(6,2)+" "+ mes(fecha.Substring(4,2))+" "+fecha.Substring(0,4));
			writer.WriteLine("VENDEDOR: "+usr_id+" "+usr_nom);
			writer.WriteLine("Articulo                     Cant. P. Unit. Valor");
		}
		
		//Imprime fin boleta
		public void fin_bol (System.IO.StreamWriter writer, int total, string tipo_pago, string hora, string ven_num, string ven_nom, string direccion)
		{
			writer.WriteLine("                                     TOTAL: "+total);
			writer.WriteLine("Tipo de Pago: "+tipo_pago);
			writer.WriteLine(ven_num+"-"+ven_nom+"-"+direccion+"  HORA: "+hora.Substring(0,2)+":"+hora.Substring(2,2));
		}
		public void salta_linea (System.IO.StreamWriter writer, int i)
		{
			for (int n = 0;n <= i; n++)
				writer.WriteLine(" ");
		}
		
		public bool imprimir(string ruta)
		{
			bool salida = false;
			try
			{
				//ejecuto comando en consola
				if (Shell("print","/d:lpt1 "+ruta))
					salida = true;
   			}
			catch(System.IO.FileNotFoundException ax)
			{
    			MessageBox.Show(ax.Message);
   			}
			return salida;
			
		}
		
		//metodo para ejecutar comandos en consola
		public bool Shell(string comando, string param)
		{
		   System.Diagnostics.Process process = new System.Diagnostics.Process(); 
		   process.EnableRaisingEvents        = false;
		   process.StartInfo.FileName         = comando; 
		   process.StartInfo.Arguments        = param;   
		   process.Start();                              
		   process.WaitForExit();                       
		   return (true);
 		 }
		
		public void remover_borrador(int ID, negocio neg)
		{
			string update = "update pos_venta set BORRADOR =' ' where ID='"+ID+"'";
			neg.update(update);
		}
		
		public int numero_boleta(negocio neg, int id)
		{
			string select = "select NO_DOCTO as doc from pos_parametros";
			MySqlDataReader reader = neg.select(select);
			reader.Read();
			int num_doc = (int)reader["doc"] + 1;
			string update = "update pos_parametros set NO_DOCTO = '"+num_doc+"'";
			neg.update(update);	
			update = "update pos_venta set NUMERO = '"+num_doc+"' where ID = '"+id+"'";
			neg.update(update);	
			return num_doc;
		}
		
		public int numero_boleta(negocio neg)
		{
			string select = "select NO_DOCTO as doc from pos_parametros";
			MySqlDataReader reader = neg.select(select);
			reader.Read();
			int num_doc = (int)reader["doc"] + 1;
			string update = "update pos_parametros set NO_DOCTO = '"+num_doc+"'";
			neg.update(update);	
			return num_doc;
		}
		
		public string mes(string n_mes)
		{
			switch (n_mes)
			{
				case "01":
					return "Enero";
				case "02":
					return "Febrero";
				case "03":
					return "Marzo";
				case "04":
					return "Abril";
				case "05":
					return "Mayo";
				case "06":
					return "Junio";
				case "07":
					return "Julio";
				case "08":
					return "Agosto";
				case "09":
					return "Septiembre";
				case "10":
					return "Octubre";
				case "11":
					return "Noviembre";
				case "12":
					return "Dciembre";
				default:
					return "ERROR";
			}
		}
	}
	
}
