/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 3/3/2009
 * Time: 5:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using MySql.Data.MySqlClient;
using Negocio;

namespace POSinnovic
{
	/// <summary>
	/// Description of ControlUsuarios.
	/// </summary>
	public class ControlUsuarios
	{
		public string usuario  = "";
		public string password = "";
		
		public bool check(){
			bool salida = false;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			neg.user    = "innovic";
			neg.pass    = "1nn0v1c";
			MySqlDataReader reader = neg.select("select * from pos_usuario where usuario='"+this.usuario+"' and password='"+this.password+"'");
			if (reader.Read()){
				salida = true;
			}
			return salida;
		}

		public bool check(string usr, string pass){
			bool salida = false;
			negocio neg = new negocio();
			neg.db      = "innpos_pos";
			MySqlDataReader reader = neg.select("select * from pos_usuario where usuario='"+usr+"' and password='"+pass+"'");
			if (reader.Read()){
				salida = true;
			}
			return salida;
		}
	}
}
