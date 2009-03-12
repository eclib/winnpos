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
			this.groupBox_porcentaje = new System.Windows.Forms.GroupBox();
			this.textBox_porcentaje = new System.Windows.Forms.TextBox();
			this.groupBox_importe = new System.Windows.Forms.GroupBox();
			this.textBox_importe = new System.Windows.Forms.TextBox();
			this.groupBox_porcentaje.SuspendLayout();
			this.groupBox_importe.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_porcentaje
			// 
			this.groupBox_porcentaje.Controls.Add(this.textBox_porcentaje);
			this.groupBox_porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_porcentaje.ForeColor = System.Drawing.Color.Black;
			this.groupBox_porcentaje.Location = new System.Drawing.Point(34, 12);
			this.groupBox_porcentaje.Name = "groupBox_porcentaje";
			this.groupBox_porcentaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox_porcentaje.Size = new System.Drawing.Size(199, 56);
			this.groupBox_porcentaje.TabIndex = 0;
			this.groupBox_porcentaje.TabStop = false;
			this.groupBox_porcentaje.Text = "PORCENTAJE % [ F9 ]";
			// 
			// textBox_porcentaje
			// 
			this.textBox_porcentaje.Font = new System.Drawing.Font("Courier New", 12F);
			this.textBox_porcentaje.Location = new System.Drawing.Point(6, 19);
			this.textBox_porcentaje.Name = "textBox_porcentaje";
			this.textBox_porcentaje.Size = new System.Drawing.Size(187, 26);
			this.textBox_porcentaje.TabIndex = 1;
			// 
			// groupBox_importe
			// 
			this.groupBox_importe.Controls.Add(this.textBox_importe);
			this.groupBox_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_importe.ForeColor = System.Drawing.Color.Black;
			this.groupBox_importe.Location = new System.Drawing.Point(239, 12);
			this.groupBox_importe.Name = "groupBox_importe";
			this.groupBox_importe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox_importe.Size = new System.Drawing.Size(199, 56);
			this.groupBox_importe.TabIndex = 1;
			this.groupBox_importe.TabStop = false;
			this.groupBox_importe.Text = "IMPORTE $ [ F10 ]";
			// 
			// textBox_importe
			// 
			this.textBox_importe.Font = new System.Drawing.Font("Courier New", 12F);
			this.textBox_importe.Location = new System.Drawing.Point(6, 19);
			this.textBox_importe.Name = "textBox_importe";
			this.textBox_importe.Size = new System.Drawing.Size(187, 26);
			this.textBox_importe.TabIndex = 1;
			// 
			// FormDescuento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(474, 82);
			this.Controls.Add(this.groupBox_importe);
			this.Controls.Add(this.groupBox_porcentaje);
			this.Name = "FormDescuento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Descuento";
			this.Load += new System.EventHandler(this.FormDescuentoLoad);
			this.groupBox_porcentaje.ResumeLayout(false);
			this.groupBox_porcentaje.PerformLayout();
			this.groupBox_importe.ResumeLayout(false);
			this.groupBox_importe.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textBox_importe;
		private System.Windows.Forms.GroupBox groupBox_importe;
		private System.Windows.Forms.TextBox textBox_porcentaje;
		private System.Windows.Forms.GroupBox groupBox_porcentaje;
	}
}
