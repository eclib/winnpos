/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 3/3/2009
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSinnovic
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ControlUsuarios CTRL = new ControlUsuarios();
			if (CTRL.check(this.textBox1.Text,this.textBox2.Text)){

				POS FrmPOS = new POS("localhost","3306", "innovic","1nn0v1c", "innpos_pos" );
				FrmPOS.madre = this;
				FrmPOS.Show();
				this.Visible=false;
			}else{
				MessageBox.Show("Usuario o Contraseña no valido, favor intentar nuevamente", "Aviso");

				this.textBox1.Text="";
				this.textBox2.Text="";
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
