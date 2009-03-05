/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 04/03/2009
 * Hora: 08:25 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
	/// <summary>
	/// Description of MantParam.
	/// </summary>
	public partial class MantParam : Form
	{
		private string	query;
		private string	query2;
		private	int		varId;		
		private	int		varIva;	
		private	string	varDatosBoleta;	
		private	string	varDatosFactura;
		private	int		varDiasHistorico;	
		private	string	varSuperCta;	
		private	string	varServerBd;	
		private	string	varPortBd;
		private	string	varServerCentral;	
		private	string	varPortCentral;	
		private	string	varServerDios;	
		
		public MantParam()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			query	= " SELECT ID AS ID, IVA AS IVA, DATOS_BOLETA AS DATOS_BOLETA, DATOS_FACTURA AS DATOS_FACTURA, DIAS_HISTORICO AS DIAS_HISTORICO, SUPERCTA AS SUPERCTA, SERVER_BD AS SERVER_BD, PORT_BD AS PORT_BD, SERVER_CENTRAL AS SERVER_CENTRAL, PORT_CENTRAL AS PORT_CENTRAL, SERVER_DIOS AS SERVER_DIOS FROM pos_parametros ";
			
			negocio neg				= new negocio();
			MySqlDataReader reader	= neg.select(query);
			
			if (reader.Read()){
					varId				= int.Parse(reader["ID"].ToString());
					varIva				= int.Parse(reader["IVA"].ToString());
					varDatosBoleta		= reader["DATOS_BOLETA"].ToString();
					varDatosFactura		= reader["DATOS_FACTURA"].ToString();
					varDiasHistorico	= int.Parse(reader["DIAS_HISTORICO"].ToString());
					varSuperCta			= reader["SUPERCTA"].ToString();
					varServerBd			= reader["SERVER_BD"].ToString();
					varPortBd			= reader["PORT_BD"].ToString();
					varServerCentral	= reader["SERVER_CENTRAL"].ToString();
					varPortCentral		= reader["PORT_CENTRAL"].ToString();
					varServerDios		= reader["SERVER_DIOS"].ToString();
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					textBox_idParametro.Text	= varId.ToString();
					textBox_iva.Text			= varIva.ToString();
					textBox_datosBoleta.Text	= varDatosBoleta;	
					textBox_datosFactura.Text	= varDatosFactura;		
					textBox_diasHistoricos.Text	= varDiasHistorico.ToString();
					textBox_superCta.Text		= varSuperCta;		
					textBox_serverBd.Text		= varServerBd;		
					textBox_portBd.Text			= varPortBd;			
					textBox_serverCentral.Text	= varServerCentral;	
					textBox_portCentral.Text	= varPortCentral;		
					textBox_serverDios.Text		= varServerDios;	
			}else{
				MessageBox.Show("No tiene datos este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idParametro.Text	= "0";			
				textBox_iva.Text			= "0";				
				textBox_datosBoleta.Text	= "";	
				textBox_datosFactura.Text	= "";		
				textBox_diasHistoricos.Text	= "0";	
				textBox_superCta.Text		= "";		
				textBox_serverBd.Text		= "";		
				textBox_portBd.Text			= "";			
				textBox_serverCentral.Text	= "";	
				textBox_portCentral.Text	= "";		
				textBox_serverDios.Text		= "";
			}
			
			neg.cerrar();
		}
		
		void Button_nuevoClick(object sender, EventArgs e)
		{
			// TextBox 
			textBox_idParametro.Text	= "0";			
			textBox_iva.Text			= "0";				
			textBox_datosBoleta.Text	= "";	
			textBox_datosFactura.Text	= "";		
			textBox_diasHistoricos.Text	= "0";	
			textBox_superCta.Text		= "";		
			textBox_serverBd.Text		= "";		
			textBox_portBd.Text			= "";			
			textBox_serverCentral.Text	= "";	
			textBox_portCentral.Text	= "";		
			textBox_serverDios.Text		= "";
			// Botones de Acción.
			button_nuevo.Enabled		= true;
			button_grabar.Enabled		= true;
			button_eliminar.Enabled		= false;
		}
		
		void Button_salirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir del mantenedor de parametros ?", "Salir", MessageBoxButtons.YesNo);
			
			switch(dr){
   				case	DialogResult.Yes: 
						this.Close(); break;
				case	DialogResult.No: 
						break;
			}
		}
		
		void Button_grabarClick(object sender, EventArgs e)
		{
			varId				= int.Parse(textBox_idParametro.Text);
			varIva				= int.Parse(textBox_iva.Text);
			varDatosBoleta		= textBox_datosBoleta.Text;
			varDatosFactura		= textBox_datosFactura.Text;
			varDiasHistorico	= int.Parse(textBox_diasHistoricos.Text);
			varSuperCta			= textBox_superCta.Text;
			varServerBd			= textBox_serverBd.Text;
			varPortBd			= textBox_portBd.Text;
			varServerCentral	= textBox_serverCentral.Text;
			varPortCentral		= textBox_portCentral.Text;
			varServerDios		= textBox_serverDios.Text;
			
			query	 = " DELETE FROM pos_parametros ";
			
			negocio neg				= new negocio();
			MySqlDataReader reader	= neg.select(query);
			
			try {
				if (reader.Read()){}
			}catch(MySql.Data.MySqlClient.MySqlException r){
				r.ToString();
			}
			neg.cerrar();
			
			query2	= " INSERT INTO pos_parametros (ID,IVA,DATOS_BOLETA,DATOS_FACTURA,DIAS_HISTORICO,SUPERCTA,SERVER_BD,PORT_BD,SERVER_CENTRAL,PORT_CENTRAL,SERVER_DIOS) VALUES (1,"+varIva+",'"+varDatosBoleta+"','"+varDatosFactura+"',"+varDiasHistorico+",'"+varSuperCta+"','"+varServerBd+"','"+varPortBd+"','"+varServerCentral+"','"+varPortCentral+"','"+varServerDios+"') ";

			negocio neg2			= new negocio();
			MySqlDataReader reader2	= neg2.select(query2);

			try {
				if (reader2.Read())
				{
					MessageBox.Show("Información grabada exitosamente.");
				}
			}catch(MySql.Data.MySqlClient.MySqlException r){
				r.ToString();
			}
			neg2.cerrar();					

			query	= " SELECT ID AS ID, IVA AS IVA, DATOS_BOLETA AS DATOS_BOLETA, DATOS_FACTURA AS DATOS_FACTURA, DIAS_HISTORICO AS DIAS_HISTORICO, SUPERCTA AS SUPERCTA, SERVER_BD AS SERVER_BD, PORT_BD AS PORT_BD, SERVER_CENTRAL AS SERVER_CENTRAL, PORT_CENTRAL AS PORT_CENTRAL, SERVER_DIOS AS SERVER_DIOS FROM pos_parametros ";
			
			neg				= new negocio();
			reader	= neg.select(query);
			
			if (reader.Read()){
					varId				= int.Parse(reader["ID"].ToString());
					varIva				= int.Parse(reader["IVA"].ToString());
					varDatosBoleta		= reader["DATOS_BOLETA"].ToString();
					varDatosFactura		= reader["DATOS_FACTURA"].ToString();
					varDiasHistorico	= int.Parse(reader["DIAS_HISTORICO"].ToString());
					varSuperCta			= reader["SUPERCTA"].ToString();
					varServerBd			= reader["SERVER_BD"].ToString();
					varPortBd			= reader["PORT_BD"].ToString();
					varServerCentral	= reader["SERVER_CENTRAL"].ToString();
					varPortCentral		= reader["PORT_CENTRAL"].ToString();
					varServerDios		= reader["SERVER_DIOS"].ToString();
					// Botones de Acción.
					button_nuevo.Enabled		= true;
					button_grabar.Enabled		= true;
					button_eliminar.Enabled		= true;
					textBox_idParametro.Text	= varId.ToString();
					textBox_iva.Text			= varIva.ToString();
					textBox_datosBoleta.Text	= varDatosBoleta;	
					textBox_datosFactura.Text	= varDatosFactura;		
					textBox_diasHistoricos.Text	= varDiasHistorico.ToString();
					textBox_superCta.Text		= varSuperCta;		
					textBox_serverBd.Text		= varServerBd;		
					textBox_portBd.Text			= varPortBd;			
					textBox_serverCentral.Text	= varServerCentral;	
					textBox_portCentral.Text	= varPortCentral;		
					textBox_serverDios.Text		= varServerDios;	
			}else{
				MessageBox.Show("No tiene datos este mantenedor.");
				// Botones de Acción.
				button_nuevo.Enabled		= true;
				button_grabar.Enabled		= false;
				button_eliminar.Enabled		= false;
				textBox_idParametro.Text	= "0";			
				textBox_iva.Text			= "0";				
				textBox_datosBoleta.Text	= "";	
				textBox_datosFactura.Text	= "";		
				textBox_diasHistoricos.Text	= "0";	
				textBox_superCta.Text		= "";		
				textBox_serverBd.Text		= "";		
				textBox_portBd.Text			= "";			
				textBox_serverCentral.Text	= "";	
				textBox_portCentral.Text	= "";		
				textBox_serverDios.Text		= "";
			}
			
		}
		
		void Button_eliminarClick(object sender, EventArgs e)
		{
			query	 = " DELETE FROM pos_parametros ";
			
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
		}
	}
}
