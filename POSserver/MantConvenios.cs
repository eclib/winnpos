/* INNOVIC 2009 - POSserver */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POSserver
{
	/// <summary>
	/// Description of MantConvenios.
	/// </summary>
	public partial class MantConvenios : Form
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
		private	string	varRut;	
		private	string	varDescripcion;	
		private	int		varPorcDescuento;	
		private	string	varFechaInicio;		
		private	string	varFechaFinal;	
		private	int		status; // Bandera para el boton grabar.
		private string	varExiste;
		
		public MantConvenios()
		{
			InitializeComponent();
			
			status = 0;
			
			query	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, RUT AS RUT, DESCRIPCION AS DESCRIPCION, PORC_DESCUENTO AS PORC_DESCUENTO, FECHA_INICIO AS FECHA_INICIO, FECHA_FINAL AS FECHA_FINAL FROM pos_convenios ORDER BY SUCURSAL ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_convenios ";
			
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
					varId				= int.Parse(reader["ID"].ToString());
					varSucursal			= int.Parse(reader["SUCURSAL"].ToString());
					varRut				= reader["RUT"].ToString();
					varDescripcion		= reader["DESCRIPCION"].ToString();
					varPorcDescuento	= int.Parse(reader["PORC_DESCUENTO"].ToString());
					varFechaInicio		= reader["FECHA_INICIO"].ToString();
					varFechaFinal		= reader["FECHA_FINAL"].ToString();
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_convenios.Rows.Add();
					this.grilla_convenios.Rows[contFilas].Cells[0].Value		= varId;
					this.grilla_convenios.Rows[contFilas].Cells[1].Value		= varSucursal;
					this.grilla_convenios.Rows[contFilas].Cells[2].Value		= varRut;
					this.grilla_convenios.Rows[contFilas].Cells[3].Value		= varDescripcion;
					this.grilla_convenios.Rows[contFilas].Cells[4].Value		= varPorcDescuento;
					this.grilla_convenios.Rows[contFilas].Cells[5].Value		= varFechaInicio;
					this.grilla_convenios.Rows[contFilas].Cells[6].Value		= varFechaFinal;
					contFilas = contFilas + 1;
				} while(reader.Read() && contFilas <= maxFilas);
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idConvenio.Text		= "";
				textBox_sucursal.Text		= "";
				textBox_rut.Text			= "";
				textBox_descripcion.Text	= "";
				textBox_porcDescuento.Text	= "";
				textBox_fechaInicio.Text	= "";
				textBox_fechaFinal.Text		= "";
			}
			
			neg.cerrar();
			neg2.cerrar();
		}
		
		void Button_nuevoClick(object sender, EventArgs e)
		{
			// TextBox //
			textBox_idConvenio.Text		= "0";
			textBox_sucursal.Text		= "0";
			textBox_rut.Text			= "";
			textBox_descripcion.Text	= "";
			textBox_porcDescuento.Text	= "0";
			textBox_fechaInicio.Text	= "";
			textBox_fechaFinal.Text		= "";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de convenios ?", "Salir", MessageBoxButtons.YesNo);
			
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
				textBox_idConvenio.Text		= grilla_convenios.Rows[Fila].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_convenios.Rows[Fila].Cells[1].Value.ToString();
				textBox_rut.Text			= grilla_convenios.Rows[Fila].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_convenios.Rows[Fila].Cells[3].Value.ToString();
				textBox_porcDescuento.Text	= grilla_convenios.Rows[Fila].Cells[4].Value.ToString();
				textBox_fechaInicio.Text	= grilla_convenios.Rows[Fila].Cells[5].Value.ToString();
				textBox_fechaFinal.Text		= grilla_convenios.Rows[Fila].Cells[6].Value.ToString();
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
			varId				= int.Parse(textBox_idConvenio.Text.ToString());
			varSucursal			= int.Parse(textBox_sucursal.Text.ToString());
			varRut				= textBox_rut.Text.ToString();
			varDescripcion		= textBox_descripcion.Text.ToString();
			varPorcDescuento	= int.Parse(textBox_porcDescuento.Text.ToString());
			varFechaInicio		= textBox_fechaInicio.Text.ToString();
			varFechaFinal		= textBox_fechaFinal.Text.ToString();
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_convenios WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0				= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de convenios.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_convenios) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_convenios) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de convenios.");
				}
	
				query2	= " INSERT INTO pos_convenios (ID,SUCURSAL,RUT,DESCRIPCION,PORC_DESCUENTO,FECHA_INICIO,FECHA_FINAL) VALUES ("+varId+","+varSucursal+",'"+varRut+"','"+varDescripcion+"',"+varPorcDescuento+",'"+varFechaInicio+"','"+varFechaFinal+"') ";
	
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

				query2	= " UPDATE pos_convenios SET SUCURSAL = "+varSucursal+",RUT = '"+varRut+"' , DESCRIPCION = '"+varDescripcion+"' ,PORC_DESCUENTO = "+varPorcDescuento+",FECHA_INICIO = '"+varFechaInicio+"',FECHA_FINAL = '"+varFechaFinal+"' WHERE ID = "+varId+" ";
	
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
			
			grilla_convenios.Rows.Clear();
			
	        query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, RUT AS RUT, DESCRIPCION AS DESCRIPCION, PORC_DESCUENTO AS PORC_DESCUENTO, FECHA_INICIO AS FECHA_INICIO, FECHA_FINAL AS FECHA_FINAL FROM pos_convenios ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_convenios ";
			
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
					varId				= int.Parse(reader3["ID"].ToString());
					varSucursal			= int.Parse(reader3["SUCURSAL"].ToString());
					varRut				= reader3["RUT"].ToString();
					varDescripcion		= reader3["DESCRIPCION"].ToString();
					varPorcDescuento	= int.Parse(reader3["PORC_DESCUENTO"].ToString());
					varFechaInicio		= reader3["FECHA_INICIO"].ToString();
					varFechaFinal		= reader3["FECHA_FINAL"].ToString();
					grilla_convenios.Rows.Add();
					grilla_convenios.Rows[contFilas].Cells[0].Value		= varId;
					grilla_convenios.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_convenios.Rows[contFilas].Cells[2].Value		= varRut;
					grilla_convenios.Rows[contFilas].Cells[3].Value		= varDescripcion;
					grilla_convenios.Rows[contFilas].Cells[4].Value		= varPorcDescuento;
					grilla_convenios.Rows[contFilas].Cells[5].Value		= varFechaInicio;
					grilla_convenios.Rows[contFilas].Cells[6].Value		= varFechaFinal;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idConvenio.Text		= grilla_convenios.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_convenios.Rows[0].Cells[1].Value.ToString();
				textBox_rut.Text			= grilla_convenios.Rows[0].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_convenios.Rows[0].Cells[3].Value.ToString();
				textBox_porcDescuento.Text	= grilla_convenios.Rows[0].Cells[4].Value.ToString();
				textBox_fechaInicio.Text	= grilla_convenios.Rows[0].Cells[5].Value.ToString();
				textBox_fechaFinal.Text		= grilla_convenios.Rows[0].Cells[6].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idConvenio.Text		= "";
				textBox_sucursal.Text		= "";
				textBox_rut.Text			= "";
				textBox_descripcion.Text	= "";
				textBox_porcDescuento.Text	= "";
				textBox_fechaInicio.Text	= "";
				textBox_fechaFinal.Text		= "";
			}
			
			neg4.cerrar();
			neg3.cerrar();
		}
		
		void Button_eliminarClick(object sender, EventArgs e)
		{			
			varId	= int.Parse(textBox_idConvenio.Text);	
			status	= 1;

			query	 = " DELETE FROM pos_convenios WHERE ID = "+varId+" ";

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
			
			grilla_convenios.Rows.Clear();
			
	        query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, RUT AS RUT, DESCRIPCION AS DESCRIPCION, PORC_DESCUENTO AS PORC_DESCUENTO, FECHA_INICIO AS FECHA_INICIO, FECHA_FINAL AS FECHA_FINAL FROM pos_convenios ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_convenios ";
			
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
					varId				= int.Parse(reader3["ID"].ToString());
					varSucursal			= int.Parse(reader3["SUCURSAL"].ToString());
					varRut				= reader3["RUT"].ToString();
					varDescripcion		= reader3["DESCRIPCION"].ToString();
					varPorcDescuento	= int.Parse(reader3["PORC_DESCUENTO"].ToString());
					varFechaInicio		= reader3["FECHA_INICIO"].ToString();
					varFechaFinal		= reader3["FECHA_FINAL"].ToString();
					grilla_convenios.Rows.Add();
					grilla_convenios.Rows[contFilas].Cells[0].Value		= varId;
					grilla_convenios.Rows[contFilas].Cells[1].Value		= varSucursal;
					grilla_convenios.Rows[contFilas].Cells[2].Value		= varRut;
					grilla_convenios.Rows[contFilas].Cells[3].Value		= varDescripcion;
					grilla_convenios.Rows[contFilas].Cells[4].Value		= varPorcDescuento;
					grilla_convenios.Rows[contFilas].Cells[5].Value		= varFechaInicio;
					grilla_convenios.Rows[contFilas].Cells[6].Value		= varFechaFinal;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idConvenio.Text		= grilla_convenios.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_convenios.Rows[0].Cells[1].Value.ToString();
				textBox_rut.Text			= grilla_convenios.Rows[0].Cells[2].Value.ToString();
				textBox_descripcion.Text	= grilla_convenios.Rows[0].Cells[3].Value.ToString();
				textBox_porcDescuento.Text	= grilla_convenios.Rows[0].Cells[4].Value.ToString();
				textBox_fechaInicio.Text	= grilla_convenios.Rows[0].Cells[5].Value.ToString();
				textBox_fechaFinal.Text		= grilla_convenios.Rows[0].Cells[6].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idConvenio.Text		= "";
				textBox_sucursal.Text		= "";
				textBox_rut.Text			= "";
				textBox_descripcion.Text	= "";
				textBox_porcDescuento.Text	= "";
				textBox_fechaInicio.Text	= "";
				textBox_fechaFinal.Text		= "";
			}
			
			neg4.cerrar();
			neg3.cerrar();
		}
	}
}
