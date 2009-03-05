/* INNOVIC 2008 | WinnPOSserver */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSserver
{
	/// <summary>
	/// Description of MantSucursales.
	/// </summary>
	public partial class MantSucursales : Form
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
		private	int		varSucursal;	
		private	string	varDescripcion;	
		private	string	varDireccion;	
		private	string	varCiudad;		
		private	string	varComuna;	
		private	string	varRegion;	
		private	int		status; // Bandera para el boton grabar.
		private string	varExiste;
		
		public MantSucursales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			status = 0;
			
			query	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, DIRECCION AS DIRECCION, CIUDAD AS CIUDAD, COMUNA AS COMUNA, REGION AS REGION FROM pos_sucursal ORDER BY SUCURSAL ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_sucursal ";
			
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
					varSucursal		= int.Parse(reader["SUCURSAL"].ToString());
					varDescripcion	= reader["DESCRIPCION"].ToString();
					varDireccion	= reader["DIRECCION"].ToString();
					varCiudad		= reader["CIUDAD"].ToString();
					varComuna		= reader["COMUNA"].ToString();
					varRegion		= reader["REGION"].ToString();
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_sucursales.Rows.Add();
					this.grilla_sucursales.Rows[contFilas].Cells[0].Value		= varId;
					this.grilla_sucursales.Rows[contFilas].Cells[1].Value		= varSucursal;
					this.grilla_sucursales.Rows[contFilas].Cells[2].Value		= varDescripcion;
					this.grilla_sucursales.Rows[contFilas].Cells[3].Value		= varDireccion;
					this.grilla_sucursales.Rows[contFilas].Cells[4].Value		= varCiudad;
					this.grilla_sucursales.Rows[contFilas].Cells[5].Value		= varComuna;
					this.grilla_sucursales.Rows[contFilas].Cells[6].Value		= varRegion;
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
			// TextBox //
			textBox_idSucursal.Text		= "0";
			textBox_sucursal.Text		= "0";
			textBox_descripcion.Text	= "";
			textBox_direccion.Text		= "";
			textBox_ciudad.Text			= "";
			textBox_comuna.Text			= "";
			textBox_region.Text			= "";	
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de sucursales ?", "Salir", MessageBoxButtons.YesNo);
			
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
				textBox_idSucursal.Text		= grilla_sucursales.Rows[Fila].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_sucursales.Rows[Fila].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_sucursales.Rows[Fila].Cells[2].Value.ToString();
				textBox_direccion.Text		= grilla_sucursales.Rows[Fila].Cells[3].Value.ToString();
				textBox_ciudad.Text			= grilla_sucursales.Rows[Fila].Cells[4].Value.ToString();
				textBox_comuna.Text			= grilla_sucursales.Rows[Fila].Cells[5].Value.ToString();
				textBox_region.Text			= grilla_sucursales.Rows[Fila].Cells[6].Value.ToString();
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
			varId			= int.Parse(textBox_idSucursal.Text);			
			varSucursal		= int.Parse(textBox_sucursal.Text);
			varDescripcion	= textBox_descripcion.Text;
			varDireccion	= textBox_direccion.Text;
			varCiudad		= textBox_ciudad.Text;
			varComuna		= textBox_comuna.Text;
			varRegion		= textBox_region.Text;
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_sucursal WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de las sucursales.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_sucursal) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_sucursal) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de las sucursales.");
				}
	
				query2	= " INSERT INTO pos_sucursal (ID,SUCURSAL,DESCRIPCION,DIRECCION,CIUDAD,COMUNA,REGION) VALUES ("+varId+","+varSucursal+",'"+varDescripcion+"','"+varDireccion+"','"+varCiudad+"','"+varComuna+"','"+varRegion+"') ";
	
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

				query2	= " UPDATE pos_sucursal SET SUCURSAL = "+varSucursal+",DESCRIPCION = '"+varDescripcion+"' ,DIRECCION = '"+varDireccion+"',CIUDAD = '"+varCiudad+"',COMUNA = '"+varComuna+"',REGION = '"+varRegion+"' WHERE ID = "+varId+" ";
	
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
			
			grilla_sucursales.Rows.Clear();
			
	        query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, DIRECCION AS DIRECCION, CIUDAD AS CIUDAD, COMUNA AS COMUNA, REGION AS REGION FROM pos_sucursal ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_sucursal ";
			
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
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varDireccion	= reader3["DIRECCION"].ToString();
					varCiudad		= reader3["CIUDAD"].ToString();
					varComuna		= reader3["COMUNA"].ToString();
					varRegion		= reader3["REGION"].ToString();
					grilla_sucursales.Rows.Add();
					grilla_sucursales.Rows[contFilas].Cells[0].Value		= varId;
					grilla_sucursales.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_sucursales.Rows[contFilas].Cells[2].Value		= varDescripcion;
					grilla_sucursales.Rows[contFilas].Cells[3].Value		= varDireccion;
					grilla_sucursales.Rows[contFilas].Cells[4].Value		= varCiudad;
					grilla_sucursales.Rows[contFilas].Cells[5].Value		= varComuna;
					grilla_sucursales.Rows[contFilas].Cells[6].Value		= varRegion;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idSucursal.Text		= grilla_sucursales.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_sucursales.Rows[0].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_sucursales.Rows[0].Cells[2].Value.ToString();
				textBox_direccion.Text		= grilla_sucursales.Rows[0].Cells[3].Value.ToString();
				textBox_ciudad.Text			= grilla_sucursales.Rows[0].Cells[4].Value.ToString();
				textBox_comuna.Text			= grilla_sucursales.Rows[0].Cells[5].Value.ToString();
				textBox_region.Text			= grilla_sucursales.Rows[0].Cells[6].Value.ToString();
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
			varId	= int.Parse(textBox_idSucursal.Text);	
			status	= 1;

			query	 = " DELETE FROM pos_sucursal WHERE ID = "+varId+" ";

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
			
			grilla_sucursales.Rows.Clear();
			
	        query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, DESCRIPCION AS DESCRIPCION, DIRECCION AS DIRECCION, CIUDAD AS CIUDAD, COMUNA AS COMUNA, REGION AS REGION FROM pos_sucursal ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_sucursal ";
			
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
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varDescripcion	= reader3["DESCRIPCION"].ToString();
					varDireccion	= reader3["DIRECCION"].ToString();
					varCiudad		= reader3["CIUDAD"].ToString();
					varComuna		= reader3["COMUNA"].ToString();
					varRegion		= reader3["REGION"].ToString();
					grilla_sucursales.Rows.Add();
					grilla_sucursales.Rows[contFilas].Cells[0].Value		= varId;
					grilla_sucursales.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_sucursales.Rows[contFilas].Cells[2].Value		= varDescripcion;
					grilla_sucursales.Rows[contFilas].Cells[3].Value		= varDireccion;
					grilla_sucursales.Rows[contFilas].Cells[4].Value		= varCiudad;
					grilla_sucursales.Rows[contFilas].Cells[5].Value		= varComuna;
					grilla_sucursales.Rows[contFilas].Cells[6].Value		= varRegion;
					contFilas		= contFilas + 1;
					status			= 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idSucursal.Text		= grilla_sucursales.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_sucursales.Rows[0].Cells[1].Value.ToString();
				textBox_descripcion.Text	= grilla_sucursales.Rows[0].Cells[2].Value.ToString();
				textBox_direccion.Text		= grilla_sucursales.Rows[0].Cells[3].Value.ToString();
				textBox_ciudad.Text			= grilla_sucursales.Rows[0].Cells[4].Value.ToString();
				textBox_comuna.Text			= grilla_sucursales.Rows[0].Cells[5].Value.ToString();
				textBox_region.Text			= grilla_sucursales.Rows[0].Cells[6].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				textBox_idSucursal.Text		= "0";
				textBox_sucursal.Text		= "0";
				textBox_descripcion.Text	= "";
				textBox_direccion.Text		= "";
				textBox_ciudad.Text			= "";
				textBox_comuna.Text			= "";
				textBox_region.Text			= "";
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
