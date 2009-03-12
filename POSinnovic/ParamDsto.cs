/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 11/03/2009
 * Hora: 11:17 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace POSinnovic
{
	/// <summary>
	/// Description of ParamDsto.
	/// </summary>
	public partial class ParamDsto : Form
	{
		public DataGridView grilla;
		
		public ParamDsto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ParamDstoLoad(object sender, EventArgs e)
		{
			int lin = this.grilla.CurrentRow.Index;
			textBox1.Text = this.grilla.Rows[lin].Cells[1].Value.ToString();
			
		}
	}
}
