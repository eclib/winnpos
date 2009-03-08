/* INNOVIC 2009 - POSserver */

using System;
using System.Data;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;

namespace POSserver
{
	/// <summary>
	/// Description of MantListaPrecios.
	/// </summary>
	public partial class MantFormaPago : Form
	{
		private string	query;
		private string	query2;
		private string	query3;
		private string	query4;
		private string	query0;
		private	int		contFilas;
		private	int		maxFilas;
		private	int		maxId;
		private int		Fila;
		private	int		varId;		
		private	string	varCodigo;
		private string	varDescripcion;
		private int		varFraccion;
		private	int		status; 		// Bandera para el boton grabar.
		private string	varExiste;		
		
		public MantFormaPago()
		{

			InitializeComponent();
			
			status = 0;
			
			query	= " SELECT ID AS ID, CODIGO AS CODIGO, DESCRIPCION AS DESCRIPCION, FRACCION AS FRACCION FROM pos_formas_pago ORDER BY CODIGO ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_formas_pago ";
			
			negocio neg				= new negocio();
			negocio neg2			= new negocio();
			MySqlDataReader reader	= neg.select(query);
			MySqlDataReader reader2	= neg2.select(query2);
			
			if (reader2.Read()){
				maxFilas = int.Parse(reader2["CANTFILAS"].ToString());
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención de la cantidad de registros del mantenedor.");
			}
			
			contFilas = 0;
			
			if (reader.Read()){
				do {
					varId			= int.Parse(reader["ID"].ToString());
					varCodigo		= reader["CODIGO"].ToString();
					varDescripcion	= reader["DESCRIPCION"].ToString();
					varFraccion		= int.Parse(reader["FRACCION"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_formaPagos.Rows.Add();
					this.grilla_formaPagos.Rows[contFilas].Cells[0].Value	= varId;
					this.grilla_formaPagos.Rows[contFilas].Cells[1].Value	= varCodigo;
					this.grilla_formaPagos.Rows[contFilas].Cells[2].Value	= varDescripcion;
					this.grilla_formaPagos.Rows[contFilas].Cells[3].Value	= varFraccion;
					contFilas = contFilas + 1;
				} while(reader.Read() && contFilas <= maxFilas);
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idFormaPago.Text	= "";
				textBox_codigo.Text			= "";
				textBox_descripcion.Text	= "";
				textBox_fraccion.Text		= "";
			}
			
			neg.cerrar();
			neg2.cerrar();

		}
		
		void Button_nuevoClick(object sender, EventArgs e)
		{
			// TextBox 
			textBox_idFormaPago.Text	= "0";
			textBox_codigo.Text			= "";
			textBox_descripcion.Text	= "";
			textBox_fraccion.Text		= "0";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;	
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de formas de pago ?", "Salir", MessageBoxButtons.YesNo);
			
			switch(dr){
   				case	DialogResult.Yes: 
						this.Close(); break;
				case	DialogResult.No: 
						break;
			}
		}
		
		void Selecciona_Fila(object sender, DataGridViewCellEventArgs e)
		{
			Fila = e.RowIndex;

			if(status != 1){
				textBox_idFormaPago.Text	= grilla_formaPagos.Rows[Fila].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_formaPagos.Rows[Fila].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_formaPagos.Rows[Fila].Cells[2].Value.ToString();
				textBox_fraccion.Text		= grilla_formaPagos.Rows[Fila].Cells[3].Value.ToString();
			}else{
				status = 0;
			}
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= true;
		}
		
		
		
		void Button_grabarClick(object sender, EventArgs e)
		{
			varId			= int.Parse(textBox_idFormaPago.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varDescripcion	= textBox_descripcion.Text.ToString();
			varFraccion		= int.Parse(textBox_fraccion.Text.ToString());
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_formas_pago WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de formas de pago.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_formas_pago) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_formas_pago) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de formas de pago.");
				}
	
				query2	= " INSERT INTO pos_formas_pago (ID,CODIGO,DESCRIPCION,FRACCION) VALUES ("+varId+",'"+varCodigo+"','"+varDescripcion+"',"+varFraccion+") ";
	
				negocio neg2			= new negocio();
				MySqlDataReader reader2	= neg2.select(query2);

				try {
					if (reader2.Read())
					{
						MessageBox.Show("Información almacenada");
					}
				}catch(MySql.Data.MySqlClient.MySqlException r){
					r.ToString();
				}
				
				neg.cerrar();
				neg2.cerrar();
			}else{

				query2	= " UPDATE pos_formas_pago SET CODIGO = '"+varCodigo+"', DESCRIPCION = '"+varDescripcion+"' ,FRACCION = "+varFraccion+" WHERE ID = "+varId+" ";
	
				negocio neg2			= new negocio();
				MySqlDataReader reader2	= neg2.select(query2);

				try {
					if (reader2.Read())
					{
						MessageBox.Show("Información almacenada");
					}
				}catch(MySql.Data.MySqlClient.MySqlException r){
					r.ToString();
				}
				
				neg2.cerrar();
			}
			
			grilla_formaPagos.Rows.Clear();
			
			query3	= " SELECT ID AS ID, CODIGO AS CODIGO, DESCRIPCION AS DESCRIPCION, FRACCION AS FRACCION FROM pos_formas_pago ORDER BY CODIGO ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_formas_pago ";
			
			negocio neg3			= new negocio();
			negocio neg4			= new negocio();
			MySqlDataReader reader3	= neg3.select(query3);
			MySqlDataReader reader4	= neg4.select(query4);
			
			if (reader4.Read()){
				maxFilas = int.Parse(reader4["CANTFILAS"].ToString());
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención de la cantidad de registros del mantenedor.");
			}
			
			contFilas = 0;
			
			if (reader3.Read()){
				do {
					varId			= int.Parse(reader3["ID"].ToString());
					varCodigo		= reader3["CODIGO"].ToString();
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varFraccion		= int.Parse(reader3["FRACCION"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_formaPagos.Rows.Add();
					grilla_formaPagos.Rows[contFilas].Cells[0].Value	= varId;
					grilla_formaPagos.Rows[contFilas].Cells[1].Value	= varCodigo;
					grilla_formaPagos.Rows[contFilas].Cells[2].Value	= varDescripcion;
					grilla_formaPagos.Rows[contFilas].Cells[3].Value	= varFraccion;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idFormaPago.Text	= grilla_formaPagos.Rows[0].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_formaPagos.Rows[0].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_formaPagos.Rows[0].Cells[2].Value.ToString();
				textBox_fraccion.Text		= grilla_formaPagos.Rows[0].Cells[3].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
			}
			
			neg3.cerrar();
			neg4.cerrar();
		}
		
		void Button_eliminarClick(object sender, EventArgs e)
		{
			varId			= int.Parse(textBox_idFormaPago.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varDescripcion	= textBox_descripcion.Text.ToString();
			varFraccion		= int.Parse(textBox_fraccion.Text.ToString());
			status	= 1;

			query	 = " DELETE FROM pos_formas_pago WHERE ID = "+varId+" ";

			negocio neg				= new negocio();
			MySqlDataReader reader	= neg.select(query);
			
			try {
				if (reader.Read())
				{
					MessageBox.Show("Información eliminada.");
				}
			}catch(MySql.Data.MySqlClient.MySqlException r){
				r.ToString();
			}
				
			neg.cerrar();		
			
			grilla_formaPagos.Rows.Clear();
			
			query3	= " SELECT ID AS ID, CODIGO AS CODIGO, DESCRIPCION AS DESCRIPCION, FRACCION AS FRACCION FROM pos_formas_pago ORDER BY CODIGO ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_formas_pago ";
			
			negocio neg3			= new negocio();
			negocio neg4			= new negocio();
			MySqlDataReader reader3	= neg3.select(query3);
			MySqlDataReader reader4	= neg4.select(query4);
			
			if (reader4.Read()){
				maxFilas = int.Parse(reader4["CANTFILAS"].ToString());
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención de la cantidad de registros del mantenedor.");
			}
			
			contFilas = 0;
			
			if (reader3.Read()){
				do {
					varId			= int.Parse(reader3["ID"].ToString());
					varCodigo		= reader3["CODIGO"].ToString();
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varFraccion		= int.Parse(reader3["FRACCION"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_formaPagos.Rows.Add();
					grilla_formaPagos.Rows[contFilas].Cells[0].Value	= varId;
					grilla_formaPagos.Rows[contFilas].Cells[1].Value	= varCodigo;
					grilla_formaPagos.Rows[contFilas].Cells[2].Value	= varDescripcion;
					grilla_formaPagos.Rows[contFilas].Cells[3].Value	= varFraccion;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idFormaPago.Text	= grilla_formaPagos.Rows[0].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_formaPagos.Rows[0].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_formaPagos.Rows[0].Cells[2].Value.ToString();
				textBox_fraccion.Text		= grilla_formaPagos.Rows[0].Cells[3].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idFormaPago.Text	= "";
				textBox_codigo.Text			= "";
				textBox_descripcion.Text	= "";
				textBox_fraccion.Text		= "";
			}
			
			neg3.cerrar();
			neg4.cerrar();	
		}
	}
}
