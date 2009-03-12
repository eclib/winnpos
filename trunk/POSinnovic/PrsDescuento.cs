/* POSinnovic - INNOVIC 2009 */

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
	/// Class para el proceso de Descuento.
	/// </summary>
	public class PrsDescuento
	{
		public PrsDescuento()
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
