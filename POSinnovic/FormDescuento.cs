/* POSinnovic - INNOVIC 2009 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace POSinnovic
{
	/// <summary>
	/// Formulario para el ingreso de Descuento.
	/// </summary>
	public partial class FormDescuento : Form
	{
		public DataGridView grilla;
		public int 			lin;
		public string		TipoDesct;
		public string		CodigoDesct;
		public int			ValorDesct;			
		
		public FormDescuento()
		{
			InitializeComponent();
		}
		
		void FormDescuentoLoad(object sender, EventArgs e)
		{
			lin								= this.grilla.CurrentRow.Index;
			textBox_codigo.Text				= this.grilla.Rows[lin].Cells[1].Value.ToString();	
			textBox_porcentaje.BackColor	= System.Drawing.Color.Silver;		
			textBox_importe.BackColor		= System.Drawing.Color.Silver;
			textBox_porcentaje.Enabled		= false;
			textBox_importe.Enabled			= false;
			textBox_porcentaje.Text			= "";
			textBox_importe.Text			= "";
		}
		
		void comandoKeyDown(object sender, KeyEventArgs e)
		{	
			switch(e.KeyCode){
				case Keys.F9:	
					textBox_importe.BackColor		= System.Drawing.Color.Silver;
					textBox_porcentaje.BackColor	= System.Drawing.Color.White;
					textBox_importe.Enabled			= false;
					textBox_porcentaje.Text			= "";
					textBox_porcentaje.Enabled		= true;
					textBox_porcentaje.Focus();
				break;
				case Keys.F10:	
					textBox_porcentaje.BackColor	= System.Drawing.Color.Silver;
					textBox_importe.BackColor		= System.Drawing.Color.White;
					textBox_porcentaje.Enabled		= false;
					textBox_importe.Text			= "";
					textBox_importe.Enabled			= true;
					textBox_importe.Focus();
					break;
				case Keys.Enter:
					if(textBox_porcentaje.Enabled == true){
						if(textBox_porcentaje.Text != ""){
							TipoDesct	= "Porcentaje";
							ValorDesct	= Convert.ToInt32(textBox_porcentaje.Text.ToString());
						}
					}else{
						if(textBox_importe.Enabled == true){
							if(textBox_importe.Text != ""){
								TipoDesct	= "Importe";
								ValorDesct	= Convert.ToInt32(textBox_importe.Text.ToString());
							}
						}
					}

					CodigoDesct = textBox_codigo.Text.ToString();
					this.Close();
					break;
				case Keys.Escape:	
					this.Close();
				break;
				default:
				break;
			}
		}
	}
}
