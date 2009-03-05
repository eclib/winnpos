/*
 * Created by SharpDevelop.
 * User: Dario
 * Date: 21-11-2006
 * Time: 11:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
	/// <summary>
	/// Description of Rutinas.
	/// </summary>
	public class Rutinas
	{
		private negocio neg = new negocio();			
		public Rutinas()
		{
		}
		
		public string exSQL( string sSQL )
		{
			negocio neg2 = new negocio();
			string sSalida = "";
		   	MySqlDataReader reader = neg2.select(sSQL);
		   	if (reader.Read())
		   	{
		   		sSalida = reader[0].ToString();
		   	}
			try{
				reader.Close();
				reader  = null;
			}catch(System.NullReferenceException r){
				r.ToString();
			}
		   	neg2.cerrar();
		   	
		   	return( sSalida );
		}
		public int GetProyCod( string Codigo )
		{
			int iSalida = 0;
		   	MySqlDataReader reader = neg.select("SELECT * FROM Proyecto where Proyecto='"+Codigo+"'");
		   	if (reader.Read())
		   	{
		   		iSalida = int.Parse(reader["idProyecto"].ToString());
		   	}
		   	neg.cerrar();
		   	return( iSalida );
		}

		public int GetNivCod( string Codigo )
		{
			int iSalida = 0;
		   	MySqlDataReader reader = neg.select("SELECT * FROM Nivel where Nivel='"+Codigo+"'");
		   	if (reader.Read())
		   	{
		   		iSalida = int.Parse(reader["idNivel"].ToString());
		   	}
		   	neg.cerrar();
		   	return( iSalida );
		}

		public void FillGridView(DataGridView DataView, string sSql){
			string query        = sSql;
			DataSet ds          = neg.byAdapter(query, "table");
			DataView.DataSource = ds;
			DataView.DataMember = "table";
		}
		public void FillGrid(DataGrid DataView, string sSql){
			string query        = sSql;
			DataSet ds          = neg.byAdapter(query, "table");
			DataView.DataSource = ds;
			DataView.DataMember = "table";
		}
	}
}
