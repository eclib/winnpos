/* INNOVIC 2009 - POSserver */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSserver
{
	/// <summary>
	/// Description of MantUsuarios.
	/// </summary>
	public partial class MantUsuarios : Form
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
		private	string	varUsuario;	
		private	int		varSucursal;	
		private	string	varPassword;
		private	string	varTipoAcceso;		
		private	int		status; 		// Bandera para el boton grabar.
		private string	varExiste;
		
		public MantUsuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			status = 0;
			
			query	= " SELECT ID AS ID, USUARIO AS USUARIO,SUCURSAL AS SUCURSAL, PASSWORD AS PASSWORD, TIPO_ACCESO AS TIPO_ACCESO FROM pos_usuario ORDER BY USUARIO ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_usuario ";
			
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
					varUsuario		= reader["USUARIO"].ToString();
					varSucursal		= int.Parse(reader["SUCURSAL"].ToString());
					varPassword		= reader["PASSWORD"].ToString();
					varTipoAcceso	= reader["TIPO_ACCESO"].ToString();
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_usuarios.Rows.Add();
					this.grilla_usuarios.Rows[contFilas].Cells[0].Value		= varId;
					this.grilla_usuarios.Rows[contFilas].Cells[1].Value		= varUsuario;
					this.grilla_usuarios.Rows[contFilas].Cells[2].Value		= varSucursal;
					this.grilla_usuarios.Rows[contFilas].Cells[3].Value		= varPassword;
					this.grilla_usuarios.Rows[contFilas].Cells[4].Value		= varTipoAcceso;
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
			textBox_idUsuario.Text		= "0";
			textBox_usuario.Text		= "";
			textBox_sucursal.Text		= "0";
			textBox_password.Text		= "";
			textBox_tipoAcceso.Text		= "";
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
				textBox_idUsuario.Text	= grilla_usuarios.Rows[Fila].Cells[0].Value.ToString();
				textBox_usuario.Text	= grilla_usuarios.Rows[Fila].Cells[1].Value.ToString();
				textBox_sucursal.Text	= grilla_usuarios.Rows[Fila].Cells[2].Value.ToString();
				textBox_password.Text	= grilla_usuarios.Rows[Fila].Cells[3].Value.ToString();
				textBox_tipoAcceso.Text	= grilla_usuarios.Rows[Fila].Cells[4].Value.ToString();
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
			varId			= int.Parse(textBox_idUsuario.Text);			
			varUsuario		= textBox_usuario.Text;
			varSucursal		= int.Parse(textBox_sucursal.Text);
			varPassword		= textBox_password.Text;
			varTipoAcceso	= textBox_tipoAcceso.Text;
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_usuario WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del id. del usuario.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_usuario) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_usuario) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de los usuarios.");
				}
	
				query2	= " INSERT INTO pos_usuario (ID,USUARIO,SUCURSAL,PASSWORD,TIPO_ACCESO) VALUES ("+varId+",'"+varUsuario+"',"+varSucursal+",'"+varPassword+"','"+varTipoAcceso+"') ";
	
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

				query2	= " UPDATE pos_usuario SET USUARIO = '"+varUsuario+"',SUCURSAL = "+varSucursal+",PASSWORD = '"+varPassword+"' ,TIPO_ACCESO = '"+varTipoAcceso+"' WHERE ID = "+varId+" ";
	
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
			
			grilla_usuarios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, USUARIO AS USUARIO,SUCURSAL AS SUCURSAL, PASSWORD AS PASSWORD, TIPO_ACCESO AS TIPO_ACCESO FROM pos_usuario ORDER BY USUARIO ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_usuario ";
			
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
					varUsuario		= reader3["USUARIO"].ToString();
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varPassword		= reader3["PASSWORD"].ToString();
					varTipoAcceso	= reader3["TIPO_ACCESO"].ToString();
					grilla_usuarios.Rows.Add();
					grilla_usuarios.Rows[contFilas].Cells[0].Value		= varId;
					grilla_usuarios.Rows[contFilas].Cells[1].Value		= varUsuario;
					grilla_usuarios.Rows[contFilas].Cells[2].Value		= varSucursal;
					grilla_usuarios.Rows[contFilas].Cells[3].Value		= varPassword;
					grilla_usuarios.Rows[contFilas].Cells[4].Value		= varTipoAcceso;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idUsuario.Text	= grilla_usuarios.Rows[0].Cells[0].Value.ToString();
				textBox_usuario.Text	= grilla_usuarios.Rows[0].Cells[1].Value.ToString();
				textBox_sucursal.Text	= grilla_usuarios.Rows[0].Cells[2].Value.ToString();
				textBox_password.Text	= grilla_usuarios.Rows[0].Cells[3].Value.ToString();
				textBox_tipoAcceso.Text	= grilla_usuarios.Rows[0].Cells[4].Value.ToString();
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
			varId	= int.Parse(textBox_idUsuario.Text);	
			status	= 1;

			query	 = " DELETE FROM pos_usuario WHERE ID = "+varId+" ";

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
			
			grilla_usuarios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, USUARIO AS USUARIO,SUCURSAL AS SUCURSAL, PASSWORD AS PASSWORD, TIPO_ACCESO AS TIPO_ACCESO FROM pos_usuario ORDER BY USUARIO ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_usuario ";
			
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
					varUsuario		= reader3["USUARIO"].ToString();
					varSucursal		= int.Parse(reader3["SUCURSAL"].ToString());
					varPassword		= reader3["PASSWORD"].ToString();
					varTipoAcceso	= reader3["TIPO_ACCESO"].ToString();
					grilla_usuarios.Rows.Add();
					grilla_usuarios.Rows[contFilas].Cells[0].Value		= varId;
					grilla_usuarios.Rows[contFilas].Cells[1].Value		= varUsuario;
					grilla_usuarios.Rows[contFilas].Cells[2].Value		= varSucursal;
					grilla_usuarios.Rows[contFilas].Cells[3].Value		= varPassword;
					grilla_usuarios.Rows[contFilas].Cells[4].Value		= varTipoAcceso;
					contFilas	= contFilas + 1;
					status		= 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idUsuario.Text	= grilla_usuarios.Rows[0].Cells[0].Value.ToString();
				textBox_usuario.Text	= grilla_usuarios.Rows[0].Cells[1].Value.ToString();
				textBox_sucursal.Text	= grilla_usuarios.Rows[0].Cells[2].Value.ToString();
				textBox_password.Text	= grilla_usuarios.Rows[0].Cells[3].Value.ToString();
				textBox_tipoAcceso.Text	= grilla_usuarios.Rows[0].Cells[4].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				textBox_idUsuario.Text	= "0";
				textBox_usuario.Text	= "";
				textBox_sucursal.Text	= "0";
				textBox_password.Text	= "";
				textBox_tipoAcceso.Text	= "";
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
