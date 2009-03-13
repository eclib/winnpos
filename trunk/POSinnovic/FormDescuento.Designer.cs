/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 12/03/2009
 * Hora: 01:23 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POSinnovic
{
	partial class FormDescuento
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_porcentaje = new System.Windows.Forms.Label();
			this.label_importe = new System.Windows.Forms.Label();
			this.textBox_porcentaje = new System.Windows.Forms.TextBox();
			this.textBox_importe = new System.Windows.Forms.TextBox();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label_porcentaje
			// 
			this.label_porcentaje.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_porcentaje.ForeColor = System.Drawing.Color.Black;
			this.label_porcentaje.Location = new System.Drawing.Point(28, 18);
			this.label_porcentaje.Name = "label_porcentaje";
			this.label_porcentaje.Size = new System.Drawing.Size(200, 23);
			this.label_porcentaje.TabIndex = 0;
			this.label_porcentaje.Text = "Porcentaje % [ F9 ]";
			this.label_porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label_importe
			// 
			this.label_importe.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_importe.ForeColor = System.Drawing.Color.Black;
			this.label_importe.Location = new System.Drawing.Point(278, 18);
			this.label_importe.Name = "label_importe";
			this.label_importe.Size = new System.Drawing.Size(200, 23);
			this.label_importe.TabIndex = 1;
			this.label_importe.Text = "Importe $ [ F10 ]";
			this.label_importe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_porcentaje
			// 
			this.textBox_porcentaje.BackColor = System.Drawing.Color.Silver;
			this.textBox_porcentaje.Enabled = false;
			this.textBox_porcentaje.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_porcentaje.Location = new System.Drawing.Point(12, 44);
			this.textBox_porcentaje.MaxLength = 3;
			this.textBox_porcentaje.Name = "textBox_porcentaje";
			this.textBox_porcentaje.Size = new System.Drawing.Size(216, 24);
			this.textBox_porcentaje.TabIndex = 2;
			this.textBox_porcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaTeclaNumerica);
			this.textBox_porcentaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comandoKeyDown);
			// 
			// textBox_importe
			// 
			this.textBox_importe.BackColor = System.Drawing.Color.Silver;
			this.textBox_importe.Enabled = false;
			this.textBox_importe.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_importe.Location = new System.Drawing.Point(262, 44);
			this.textBox_importe.MaxLength = 10;
			this.textBox_importe.Name = "textBox_importe";
			this.textBox_importe.Size = new System.Drawing.Size(216, 24);
			this.textBox_importe.TabIndex = 3;
			this.textBox_importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaTeclaNumerica);
			this.textBox_importe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comandoKeyDown);
			// 
			// textBox_codigo
			// 
			this.textBox_codigo.Enabled = false;
			this.textBox_codigo.Location = new System.Drawing.Point(234, 18);
			this.textBox_codigo.MaxLength = 20;
			this.textBox_codigo.Name = "textBox_codigo";
			this.textBox_codigo.Size = new System.Drawing.Size(51, 20);
			this.textBox_codigo.TabIndex = 4;
			this.textBox_codigo.Visible = false;
			// 
			// FormDescuento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(490, 81);
			this.Controls.Add(this.textBox_codigo);
			this.Controls.Add(this.textBox_importe);
			this.Controls.Add(this.textBox_porcentaje);
			this.Controls.Add(this.label_importe);
			this.Controls.Add(this.label_porcentaje);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDescuento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Descuento";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comandoKeyDown);
			this.Load += new System.EventHandler(this.FormDescuentoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.Label label_porcentaje;
		private System.Windows.Forms.Label label_importe;
		private System.Windows.Forms.TextBox textBox_porcentaje;
		private System.Windows.Forms.TextBox textBox_importe;
	}
}
