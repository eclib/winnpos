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
	public partial class MantListaPrecios : Form
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
		private	int		varSucursal;
		private string	varDescripcion;
		private int		varNeto;
		private	int		status; 		// Bandera para el boton grabar.
		private string	varExiste;		
		
		public MantListaPrecios()
		{

			InitializeComponent();
			
			status = 0;
			
			query	= " SELECT ID AS ID, CODIGO AS CODIGO, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, NETO AS NETO FROM pos_lista_precio ORDER BY SUCURSAL ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_lista_precio ";
			
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
					varSucursal		= int.Parse(reader["SUCURSAL"].ToString());
					varDescripcion	= reader["DESCRIPCION"].ToString();
					varNeto			= int.Parse(reader["NETO"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_listaPrecios.Rows.Add();
					this.grilla_listaPrecios.Rows[contFilas].Cells[0].Value	= varId;
					this.grilla_listaPrecios.Rows[contFilas].Cells[1].Value	= varCodigo;
					this.grilla_listaPrecios.Rows[contFilas].Cells[2].Value	= varSucursal;
					this.grilla_listaPrecios.Rows[contFilas].Cells[3].Value	= varDescripcion;
					this.grilla_listaPrecios.Rows[contFilas].Cells[4].Value	= varNeto;
					contFilas = contFilas + 1;
				} while(reader.Read() && contFilas <= maxFilas);
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
			}
			
			neg.cerrar();
			neg2.cerrar();

		}
		
		void Button_nuevoClick(object sender, EventArgs e)
		{
			// TextBox 
			textBox_idListaPrecio.Text	= "0";
			textBox_codigo.Text			= "";
			textBox_sucursal.Text		= "0";
			textBox_descripcion.Text	= "";
			textBox_neto.Text			= "0";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;	
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de lista de precios ?", "Salir", MessageBoxButtons.YesNo);
			
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
				textBox_idListaPrecio.Text	= grilla_listaPrecios.Rows[Fila].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_listaPrecios.Rows[Fila].Cells[1].Value.ToString();
				textBox_sucursal.Text		= grilla_listaPrecios.Rows[Fila].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_listaPrecios.Rows[Fila].Cells[3].Value.ToString();
				textBox_neto.Text			= grilla_listaPrecios.Rows[Fila].Cells[4].Value.ToString();
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
			varId			= int.Parse(textBox_idListaPrecio.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varSucursal		= int.Parse(textBox_sucursal.Text.ToString());
			varDescripcion	= textBox_descripcion.Text.ToString();
			varNeto			= int.Parse(textBox_neto.Text.ToString());
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_lista_precio WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de las Listas.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_lista_precio) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_lista_precio) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de las listas.");
				}
	
				query2	= " INSERT INTO pos_lista_precio (ID,CODIGO,SUCURSAL,DESCRIPCION,NETO) VALUES ("+varId+",'"+varCodigo+"',"+varSucursal+",'"+varDescripcion+"',"+varNeto+") ";
	
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

				query2	= " UPDATE pos_lista_precio SET CODIGO = '"+varCodigo+"', SUCURSAL = "+varSucursal+",DESCRIPCION = '"+varDescripcion+"' ,NETO = "+varNeto+" WHERE ID = "+varId+" ";
	
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
			
			grilla_listaPrecios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, CODIGO AS CODIGO, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, NETO AS NETO FROM pos_lista_precio ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_lista_precio ";
			
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
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varNeto			= int.Parse(reader3["NETO"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_listaPrecios.Rows.Add();
					grilla_listaPrecios.Rows[contFilas].Cells[0].Value	= varId;
					grilla_listaPrecios.Rows[contFilas].Cells[1].Value	= varCodigo;
					grilla_listaPrecios.Rows[contFilas].Cells[2].Value	= varSucursal;
					grilla_listaPrecios.Rows[contFilas].Cells[3].Value	= varDescripcion;
					grilla_listaPrecios.Rows[contFilas].Cells[4].Value	= varNeto;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idListaPrecio.Text	= grilla_listaPrecios.Rows[0].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_listaPrecios.Rows[0].Cells[1].Value.ToString();
				textBox_sucursal.Text		= grilla_listaPrecios.Rows[0].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_listaPrecios.Rows[0].Cells[3].Value.ToString();
				textBox_neto.Text			= grilla_listaPrecios.Rows[0].Cells[4].Value.ToString();
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
			varId			= int.Parse(textBox_idListaPrecio.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varSucursal		= int.Parse(textBox_sucursal.Text.ToString());
			varDescripcion	= textBox_descripcion.Text.ToString();
			varNeto			= int.Parse(textBox_neto.Text.ToString());
			status	= 1;

			query	 = " DELETE FROM pos_lista_precio WHERE ID = "+varId+" ";

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
			
			grilla_listaPrecios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, CODIGO AS CODIGO, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, NETO AS NETO FROM pos_lista_precio ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_lista_precio ";
			
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
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varNeto			= int.Parse(reader3["NETO"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_listaPrecios.Rows.Add();
					grilla_listaPrecios.Rows[contFilas].Cells[0].Value	= varId;
					grilla_listaPrecios.Rows[contFilas].Cells[1].Value	= varCodigo;
					grilla_listaPrecios.Rows[contFilas].Cells[2].Value	= varSucursal;
					grilla_listaPrecios.Rows[contFilas].Cells[3].Value	= varDescripcion;
					grilla_listaPrecios.Rows[contFilas].Cells[4].Value	= varNeto;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idListaPrecio.Text	= grilla_listaPrecios.Rows[0].Cells[0].Value.ToString();
				textBox_codigo.Text			= grilla_listaPrecios.Rows[0].Cells[1].Value.ToString();
				textBox_sucursal.Text		= grilla_listaPrecios.Rows[0].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_listaPrecios.Rows[0].Cells[3].Value.ToString();
				textBox_neto.Text			= grilla_listaPrecios.Rows[0].Cells[4].Value.ToString();
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
	}
}
