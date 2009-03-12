/* POSinnovic - INNOVIC 2009 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace POSinnovic
{
	/// <summary>
	/// Description of FormDescuento.
	/// </summary>
	public partial class FormDescuento : Form
	{
		public DataGridView grilla;
		
		public FormDescuento()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FormDescuentoLoad(object sender, EventArgs e)
		{
			int lin					= this.grilla.CurrentRow.Index;
			textBox_porcentaje.Text	= this.grilla.Rows[lin].Cells[1].Value.ToString();			
		}
	}
}
