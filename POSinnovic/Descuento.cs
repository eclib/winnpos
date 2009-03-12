/* INNOVIC */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;
using System.Management;
using Negocio;
using Rutinas;

namespace POSinnovic
{
	/// <summary>
	/// Objeto de Descuento.
	/// </summary>
	public class Descuento
	{
		public Descuento()
		{
		}
		
		/// <summary>
		/// Proceso para la obtención del descuento del cliente.
		/// </summary>
		/// <param name="RutCliente"> Rut Cliente.</param>
		public bool ObtenerDstoCliente(string RutCliente){
			bool salida = false;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			neg.user    = "innovic";
			neg.pass    = "1nn0v1c";
			MySqlDataReader reader = neg.select("SELECT * FROM pos_convenios where RUT='"+RutCliente+"'");
			if (reader.Read()){
				salida = true;
			}
			return salida;
		}
	}
}
