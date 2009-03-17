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
			//Preparo Conexión
			//int pag = 0;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			neg.user    = "innovic";
			neg.pass    = "1nn0v1c";
			//Consulto por numero venta enviado - DETALLE
			string select = "select ven.ID as id, usr.USUARIO as usr, pag.TIPO_PAGO as tip_pago ";
			select = "from pos_venta ven,pos_usuario usr, pos_venta_detalle_pago pag ";
			select += "where ven.NUMERO = '"+num_vta+"' ";
			select += "and ven.ID_USUARIO = usr.ID ";
			select += "and ven.NUMERO ="+ num_vta;
			MySqlDataReader reader = neg.select(select);
			reader.Read();
			
			//Busco articulos vendidos con el ID del encabezado
			select = "select pre.DESCRIPCION desc, det.CANTIDAD as can, det.PRECIO_UNITARIO as unit, det.TOTAL as total ";
			select += "from pos_venta_detalle det, pos_lista_precio pre ";
			select += "where ID = '"+reader["id"]+"' ";
			select += "and det.CODIGO = pre.CODIGO ";
			MySqlDataReader reader2 = neg.select(select);
			
			System.IO.StreamWriter writer;
			writer = System.IO.File.CreateText("C:\\BOLETA.txt");
			writer.WriteLine("    "+num_vta+"         FECHA");
			writer.WriteLine("VENDEDOR: "+reader["usr"]);
			writer.WriteLine("Articulo                      Cant.   P. Unit   Valor");
			int total = 0;
			
			while(reader2.Read())
			{
				writer.WriteLine(reader2["desc"]+"     "+reader2["can"]+"  "+reader2["unit"]+"  "+reader2["total"]);
				total += (int)reader2["total"];
			}
			
			writer.WriteLine("		TOTAL: "+total);
			writer.WriteLine(reader["tip_pago"]);
			writer.WriteLine("SUCURSAL : XXXXXXXXXX Nº 00           HORA");
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
		   return ( true);
 		 }
		
		public void remover_borrador(int ID, negocio neg)
		{
			string update = "update pos_venta BORRADOR =' ' where ID='"+ID+"'";
			neg.update(update);
		}
		
	}
	
}
