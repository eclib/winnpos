/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 15-03-2009
 * Hora: 21:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace POSinnovic
{
	public partial class FormDescuento : Form
	{
		public DataGridView Grilla;
		public Descuentos Descuento;
		public POS Padre;
		private string Codigo;
		public CierreVenta Cierre;
		public int Tipo;
		
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
		
		void FormDescuentoKeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.Enter:
					if (!IsTextValidated(textBox1.Text)){
						MessageBox.Show("Error solo se aceptan digitos numericos");
					}else{
						if (!IsTextValidated(textBox2.Text)){
							MessageBox.Show("Error solo se aceptan digitos numericos");
						}else{
							if (Tipo == 2){
								if (textBox1.Text.Trim().Equals("")){
									textBox1.Text="0";
								}
								if (textBox2.Text.Trim().Equals("")){
									textBox2.Text="0";
								}
								this.Descuento.DesctoTotal(Single.Parse(textBox1.Text));
								this.Descuento.DesctoTotal(Int32.Parse(textBox2.Text));
								this.Cierre.CalcTotal();
							}else{
								if (textBox1.Text.Trim().Equals("")){
									textBox1.Text="0";
								}
								if (textBox2.Text.Trim().Equals("")){
									textBox2.Text="0";
								}
								this.Descuento.addDesctoLinea(this.Codigo,Single.Parse(textBox1.Text));
								this.Descuento.addDesctoLinea(this.Codigo, Int32.Parse(textBox2.Text));
								this.Padre.calclinea(this.Grilla.CurrentRow.Index);
							}
							this.Close();
						}
					}
					break;
				case Keys.Escape:
					this.Close();
					break;
			
			}
		}
		
		void FormDescuentoLoad(object sender, EventArgs e)
		{
			if (Tipo==2){
				textBox1.Text = this.Descuento.GetDesctoTotPor().ToString();
				textBox2.Text = this.Descuento.GetDesctoTotImp().ToString();
			}else{
				this.Codigo = this.Grilla.Rows[this.Grilla.CurrentRow.Index].Cells[1].Value.ToString();
				textBox1.Text = this.Descuento.GetDesctoLineaPor(this.Codigo).ToString();
				textBox2.Text = this.Descuento.GetDesctoLineaImp(this.Codigo).ToString();
			}
		}
		private bool IsTextValidated(string strTextEntry)
        {           
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strTextEntry);            
        }		
	}
}
