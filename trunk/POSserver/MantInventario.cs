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
	public partial class MantInventario : Form
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
		private	string	varCodigo;
		private int		varStock;
		private int		varStockMin;
		private	int		status; 		// Bandera para el boton grabar.
		private string	varExiste;		
		
		public MantInventario()
		{

			InitializeComponent();
			
			status = 0;
			
			query	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO, STOCK AS STOCK, STOCK_MIN AS STOCK_MIN FROM pos_inventario ORDER BY SUCURSAL ASC ";
			query2	= " SELECT COUNT(*) AS CANTFILAS FROM pos_inventario ";
			
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
					varCodigo		= reader["CODIGO"].ToString();
					varStock		= int.Parse(reader["STOCK"].ToString());
					varStockMin		= int.Parse(reader["STOCK_MIN"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					this.grilla_inventarios.Rows.Add();
					this.grilla_inventarios.Rows[contFilas].Cells[0].Value	= varId;
					this.grilla_inventarios.Rows[contFilas].Cells[1].Value	= varSucursal;
					this.grilla_inventarios.Rows[contFilas].Cells[2].Value	= varCodigo;
					this.grilla_inventarios.Rows[contFilas].Cells[3].Value	= varStock;
					this.grilla_inventarios.Rows[contFilas].Cells[4].Value	= varStockMin;
					contFilas = contFilas + 1;
				} while(reader.Read() && contFilas <= maxFilas);
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idInventario.Text	= "";
				textBox_sucursal.Text		= "";
				textBox_codigo.Text			= "";
				textBox_stock.Text			= "";
				textBox_stockMin.Text		= "";
			}
			
			neg.cerrar();
			neg2.cerrar();

		}
		
		void Button_nuevoClick(object sender, EventArgs e)
		{
			// TextBox 
			textBox_idInventario.Text	= "0";
			textBox_sucursal.Text		= "0";
			textBox_codigo.Text			= "";
			textBox_stock.Text			= "0";
			textBox_stockMin.Text		= "0";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;	
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de inventarios ?", "Salir", MessageBoxButtons.YesNo);
			
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
				textBox_idInventario.Text	= grilla_inventarios.Rows[Fila].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_inventarios.Rows[Fila].Cells[1].Value.ToString();
				textBox_codigo.Text			= grilla_inventarios.Rows[Fila].Cells[2].Value.ToString();
				textBox_stock.Text			= grilla_inventarios.Rows[Fila].Cells[3].Value.ToString();
				textBox_stockMin.Text		= grilla_inventarios.Rows[Fila].Cells[4].Value.ToString();
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
			varId			= int.Parse(textBox_idInventario.Text.ToString());
			varSucursal		= int.Parse(textBox_sucursal.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varStock		= int.Parse(textBox_stock.Text.ToString());
			varStockMin		= int.Parse(textBox_stockMin.Text.ToString());
			status			= 1;
			
			query0	 = " SELECT CASE WHEN (SELECT 1 AS EXISTE FROM pos_inventario WHERE ID = "+varId+" ) = 1 THEN 'SI EXISTE' ELSE 'NO EXISTE' END AS EXISTE ";
			
			negocio neg0			= new negocio();
			MySqlDataReader reader0	= neg0.select(query0);
			
			if (reader0.Read()){
				varExiste	= reader0["EXISTE"].ToString();
			}else{
				MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de inventario.");
			}
			
			neg0.cerrar();	
			
			if(varExiste != "SI EXISTE"){ // Insertara.
				query	= " SELECT CASE WHEN (SELECT ISNULL(MAX(ID)) AS MAXIMOID FROM pos_inventario) = 1 THEN 0 ELSE (SELECT MAX(ID) AS MAXIMOID FROM pos_inventario) END AS MAXIMOID  ";
				
				negocio neg				= new negocio();
				MySqlDataReader reader	= neg.select(query);
				
				if (reader.Read()){
					maxId = int.Parse(reader["MAXIMOID"].ToString());
					varId = maxId + 1;				
				}else{
					MessageBox.Show("Error : A ocurrido un problema con la obtención del maximo id. de inventario.");
				}
	
				query2	= " INSERT INTO pos_inventario (ID,SUCURSAL,CODIGO,STOCK,STOCK_MIN) VALUES ("+varId+","+varSucursal+",'"+varCodigo+"',"+varStock+","+varStockMin+") ";
	
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

				query2	= " UPDATE pos_inventario SET SUCURSAL = "+varSucursal+", CODIGO = '"+varCodigo+"', STOCK = "+varStock+" , STOCK_MIN = "+varStockMin+" WHERE ID = "+varId+" ";
	
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
			
			grilla_inventarios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO, STOCK AS STOCK, STOCK_MIN AS STOCK_MIN FROM pos_inventario ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_inventario ";
			
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
					varCodigo		= reader3["CODIGO"].ToString();
					varStock		= int.Parse(reader3["STOCK"].ToString());
					varStockMin		= int.Parse(reader3["STOCK_MIN"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_inventarios.Rows.Add();
					grilla_inventarios.Rows[contFilas].Cells[0].Value	= varId;
					grilla_inventarios.Rows[contFilas].Cells[1].Value	= varSucursal;
					grilla_inventarios.Rows[contFilas].Cells[2].Value	= varCodigo;
					grilla_inventarios.Rows[contFilas].Cells[3].Value	= varStock;
					grilla_inventarios.Rows[contFilas].Cells[4].Value	= varStockMin;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idInventario.Text	= grilla_inventarios.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_inventarios.Rows[0].Cells[1].Value.ToString();
				textBox_codigo.Text			= grilla_inventarios.Rows[0].Cells[2].Value.ToString();
				textBox_stock.Text			= grilla_inventarios.Rows[0].Cells[3].Value.ToString();
				textBox_stockMin.Text		= grilla_inventarios.Rows[0].Cells[4].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idInventario.Text	= "";
				textBox_sucursal.Text		= "";
				textBox_codigo.Text			= "";
				textBox_stock.Text			= "";
				textBox_stockMin.Text		= "";
			}
			
			neg3.cerrar();
			neg4.cerrar();
		}
		
		void Button_eliminarClick(object sender, EventArgs e)
		{
			varId			= int.Parse(textBox_idInventario.Text.ToString());
			varSucursal		= int.Parse(textBox_sucursal.Text.ToString());
			varCodigo		= textBox_codigo.Text.ToString();
			varStock		= int.Parse(textBox_stock.Text.ToString());
			varStockMin		= int.Parse(textBox_stockMin.Text.ToString());
			status	= 1;

			query	 = " DELETE FROM pos_inventario WHERE ID = "+varId+" ";

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
			
			grilla_inventarios.Rows.Clear();
			
			query3	= " SELECT ID AS ID, SUCURSAL AS SUCURSAL, CODIGO AS CODIGO, STOCK AS STOCK, STOCK_MIN AS STOCK_MIN FROM pos_inventario ORDER BY SUCURSAL ASC ";
			query4	= " SELECT COUNT(*) AS CANTFILAS FROM pos_inventario ";
			
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
					varCodigo		= reader3["CODIGO"].ToString();
					varStock		= int.Parse(reader3["STOCK"].ToString());
					varStockMin		= int.Parse(reader3["STOCK_MIN"].ToString());
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					grilla_inventarios.Rows.Add();
					grilla_inventarios.Rows[contFilas].Cells[0].Value	= varId;
					grilla_inventarios.Rows[contFilas].Cells[1].Value	= varSucursal;
					grilla_inventarios.Rows[contFilas].Cells[2].Value	= varCodigo;
					grilla_inventarios.Rows[contFilas].Cells[3].Value	= varStock;
					grilla_inventarios.Rows[contFilas].Cells[4].Value	= varStockMin;
					contFilas = contFilas + 1;
				} while(reader3.Read() && contFilas <= maxFilas);
				textBox_idInventario.Text	= grilla_inventarios.Rows[0].Cells[0].Value.ToString();
				textBox_sucursal.Text		= grilla_inventarios.Rows[0].Cells[1].Value.ToString();
				textBox_codigo.Text			= grilla_inventarios.Rows[0].Cells[2].Value.ToString();
				textBox_stock.Text			= grilla_inventarios.Rows[0].Cells[3].Value.ToString();
				textBox_stockMin.Text		= grilla_inventarios.Rows[0].Cells[4].Value.ToString();
			}else{
				MessageBox.Show("No tiene registros este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idInventario.Text	= "";
				textBox_sucursal.Text		= "";
				textBox_codigo.Text			= "";
				textBox_stock.Text			= "";
				textBox_stockMin.Text		= "";
			}
			
			neg3.cerrar();
			neg4.cerrar();	
		}
	}
}
