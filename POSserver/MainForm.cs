/* INNOVIC 2009 - POSserver */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSserver
{
	/// Descripción MainForm : Programa que contiene todas las interfaces de POSserver.

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			//POSserver.MantSucursales		xx	= new MantSucursales();
			//POSserver.MantUsuarios		xx	= new MantUsuarios();
			//POSserver.MantPOSserver		xx	= new MantPOSserver();
			//POSserver.MantParam			xx	= new MantParam();
			//POSserver.MantListaPrecios	xx	= new MantListaPrecios();
			//POSserver.MantInventario		xx = new MantInventario();
			//POSserver.MantFormaPago		xx = new MantFormaPago();
			POSserver.MantConvenios			xx = new MantConvenios();
			xx.Show();
			this.Hide();
		}
	}
}
