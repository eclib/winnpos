/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/02/2009
 * Hora: 04:09 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSserver
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			//POSserver.MantSucursales xx = new MantSucursales();
			//POSserver.MantUsuarios xx = new MantUsuarios();
			//POSserver.MantPOSserver xx = 	new MantPOSserver();
			POSserver.MantParam xx = 	new MantParam();
			xx.Show();
			this.Hide();
		}
	}
}
