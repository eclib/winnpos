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
		public void gentxt(int num_vta)
		{
			//Preparo Conexi�n
			//int pag = 0;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			neg.user    = "innovic";
			neg.pass    = "1nn0v1c";
			//Consulto por numero venta enviado - DETALLE
			string select = "select ven.FECHA as fecha, ven.HORA as hora,ven.ID as id, usr.USUARIO as usr, usr.ID as usrid, pag.TIPO_PAGO as tip_pago ";
			select += "from pos_venta ven,pos_usuario usr, pos_venta_detalle_pago pag ";
			select += "where ven.NUMERO = '"+num_vta+"' ";
			select += "and ven.USR_CAJ = usr.ID ";
			//select += "and ven.NUMERO ="+ num_vta;
			MySqlDataReader reader = neg.select(select);
			reader.Read();
			
			
			//Busco articulos vendidos con el ID del encabezado
			select = "select pre.DESCRIPCION as descr, det.CANTIDAD as can, det.PRECIO_UNITARIO as unit, det.TOTAL as total ";
			select += "from pos_venta_detalle det, pos_lista_precio pre ";
			select += "where ID_VENTA = '"+reader["id"]+"' ";
			select += "and det.CODIGO = pre.CODIGO ";
			MySqlDataReader reader2 = neg.select(select);
			
			//SUCURSAL
			select = "select N_SUCURSAL as num,  NO_SUCURSAL as nom, DIRECCION as dir from pos_parametros ";
			MySqlDataReader reader3 = neg.select(select);
			reader3.Read();
			System.IO.StreamWriter writer;
			writer = System.IO.File.CreateText("C:\\BOLETA.txt");
			string fecha = reader["fecha"].ToString();
			writer.WriteLine("Boleta: "+String.Format("{0,-20}",num_vta)+fecha.Substring(6,2)+" "+ mes(fecha.Substring(4,2))+" "+fecha.Substring(0,4));
			writer.WriteLine("VENDEDOR: "+reader["usrid"]+" "+reader["usr"]);
			writer.WriteLine("Articulo                     Cant. P. Unit. Valor");
			int total = 0;
			
			while(reader2.Read())
			{
				writer.WriteLine(String.Format("{0,-20}",reader2["descr"])+String.Format("{0,-6}",reader2["can"])+String.Format("{0,-8}",reader2["unit"])+String.Format("{0,-6}",reader2["total"]));
				total += (int)reader2["total"];
			}
			
			writer.WriteLine("                                     TOTAL: "+total);
			writer.WriteLine("Tipo de Pago: "+reader["tip_pago"]);
			string hora = reader["hora"].ToString();
			writer.WriteLine(reader3["num"]+"-"+reader3["nom"]+"-"+reader3["dir"]+"  HORA: "+hora.Substring(0,2)+":"+hora.Substring(2,2));
			writer.Close();
			
			//funcion imprimir
			if (imprimir("C:\\BOLETA.txt") == false)
			{
				MessageBox.Show("ERROR AL IMPRIMIR   :-S  ");
			}
			
			//Como esta imprimida la boleta ahora es valida
			remover_borrador((int)reader["id"], neg);
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