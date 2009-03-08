/* INNOVIC 2008 | WinnPOSserver */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSserver
{
	/// <summary>
	/// Description of MantPOSserver.
	/// </summary>
	public partial class MantPOSserver : Form
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
		private	string	varSucursal;	
		private	int		varCodigo;
		private	int		status; 		// Bandera para el boton grabar.
		private string	varExiste;
		
		public MantPOSserver()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			status = 0;
			
			query	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO FROM pos_pos ORDER BY SUCURSAL ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_pos ";
			
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
					varId		= int.Parse(reader["ID"].ToString());
					varSucursal	= reader["SUCURSAL"].ToString();
					varCodigo	= int.Parse(reader["CODIGO"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_POSservers.Rows.Add();
					this.grilla_POSservers.Rows[contFilas].Cells[0].Value	= varId;
					this.grilla_POSservers.Rows[contFilas].Cells[2].Value	= varSucursal;
					this.grilla_POSservers.Rows[contFilas].Cells[1].Value	= varCodigo;
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
			textBox_idPOSserver.Text		= "0";
			textBox_sucursal.Text	= "";
			textBox_codigo.Text		= "0";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;			
		}
		

		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de usuarios ?", "Salir", MessageBoxButtons.YesNo);
			
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
				textBox_idPOSserver.Text		= grilla_POSservers.Rows[Fila].Cells[0].Value.ToString();
				textBox_sucursal.Text	= grilla_POSservers.Rows[Fila].Cells[1].Value.ToString();
				textBox_codigo.Text		= grilla_POSservers.Rows[Fila].Cells[2].Value.ToString();
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
			varId			= int.Parse(textBox_idPOSserver.Text);			
			varSucursal		= textBox_sucursal.Text;
			varCodigo		= int.Parse(textBox_codigo.Text);
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_pos WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del id. del Punto de Venta.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_pos) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_pos) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de los Puntos de Ventas.");
				}
	
				query2	= " INSERT INTO pos_pos (ID,SUCURSAL,CODIGO) VALUES ("+varId+",'"+varSucursal+"',"+varCodigo+") ";
	
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

				query2	= " UPDATE pos_pos SET SUCURSAL = '"+varSucursal+"',CODIGO = "+varCodigo+" WHERE ID = "+varId+" ";
	
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
			
			grilla_POSservers.Rows.Clear();
			
			query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO FROM pos_pos ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_pos ";
			
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
					varId		= int.Parse(reader3["ID"].ToString());
					varSucursal	= reader3["SUCURSAL"].ToString();
					varCodigo	= int.Parse(reader3["CODIGO"].ToString());
					grilla_POSservers.Rows.Add();
					grilla_POSservers.Rows[contFilas].Cells[0].Value		= varId;
					grilla_POSservers.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_POSservers.Rows[contFilas].Cells[2].Value		= varCodigo;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idPOSserver.Text		= grilla_POSservers.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text	= grilla_POSservers.Rows[0].Cells[1].Value.ToString();
				textBox_codigo.Text		= grilla_POSservers.Rows[0].Cells[2].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
			}
			
			neg4.cerrar();
			neg3.cerrar();
		}
		

		
		void Button_eliminarClick(object sender, EventArgs e)
		{
			varId	= int.Parse(textBox_idPOSserver.Text);	
			status	= 1;

			query	 = " DELETE FROM pos_pos WHERE ID = "+varId+" ";

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
			
			grilla_POSservers.Rows.Clear();
			
			query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO FROM pos_pos ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_pos ";
			
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
					varId		= int.Parse(reader3["ID"].ToString());
					varSucursal	= reader3["SUCURSAL"].ToString();
					varCodigo	= int.Parse(reader3["CODIGO"].ToString());
					grilla_POSservers.Rows.Add();
					grilla_POSservers.Rows[contFilas].Cells[0].Value		= varId;
					grilla_POSservers.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_POSservers.Rows[contFilas].Cells[2].Value		= varCodigo;
					contFilas	= contFilas + 1;
					status		= 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idPOSserver.Text		= grilla_POSservers.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text	= grilla_POSservers.Rows[0].Cells[1].Value.ToString();
				textBox_codigo.Text		= grilla_POSservers.Rows[0].Cells[2].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				textBox_idPOSserver.Text		= "0";
				textBox_sucursal.Text	= "";
				textBox_codigo.Text		= "0";
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
			}
			
			neg4.cerrar();
			neg3.cerrar();
		}
	}
}
