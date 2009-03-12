/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 11/03/2009
 * Hora: 11:17 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POSinnovic
{
	partial class ParamDsto
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox_importe = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox_convenio = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox_porcentaje.SuspendLayout();
			this.groupBox_importe.SuspendLayout();
			this.groupBox_convenio.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_porcentaje
			// 
			this.groupBox_porcentaje.Controls.Add(this.textBox2);
			this.groupBox_porcentaje.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_porcentaje.ForeColor = System.Drawing.Color.Black;
			this.groupBox_porcentaje.Location = new System.Drawing.Point(182, 12);
			this.groupBox_porcentaje.Name = "groupBox_porcentaje";
			this.groupBox_porcentaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox_porcentaje.Size = new System.Drawing.Size(164, 42);
			this.groupBox_porcentaje.TabIndex = 4;
			this.groupBox_porcentaje.TabStop = false;
			this.groupBox_porcentaje.Text = "Porcentaje % [ F10 ]";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(6, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 20);
			this.textBox2.TabIndex = 0;
			// 
			// groupBox_importe
			// 
			this.groupBox_importe.Controls.Add(this.textBox3);
			this.groupBox_importe.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_importe.ForeColor = System.Drawing.Color.Black;
			this.groupBox_importe.Location = new System.Drawing.Point(352, 12);
			this.groupBox_importe.Name = "groupBox_importe";
			this.groupBox_importe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox_importe.Size = new System.Drawing.Size(164, 42);
			this.groupBox_importe.TabIndex = 5;
			this.groupBox_importe.TabStop = false;
			this.groupBox_importe.Text = "Importe $ [ F11 ]";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(6, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 0;
			// 
			// groupBox_convenio
			// 
			this.groupBox_convenio.Controls.Add(this.textBox1);
			this.groupBox_convenio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_convenio.ForeColor = System.Drawing.Color.Black;
			this.groupBox_convenio.Location = new System.Drawing.Point(12, 12);
			this.groupBox_convenio.Name = "groupBox_convenio";
			this.groupBox_convenio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox_convenio.Size = new System.Drawing.Size(164, 42);
			this.groupBox_convenio.TabIndex = 3;
			this.groupBox_convenio.TabStop = false;
			this.groupBox_convenio.Text = "Convenio [ F9 ]";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.textBox1.TabIndex = 0;
			// 
			// ParamDsto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(529, 65);
			this.Controls.Add(this.groupBox_porcentaje);
			this.Controls.Add(this.groupBox_importe);
			this.Controls.Add(this.groupBox_convenio);
			this.Name = "ParamDsto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ParamDsto";
			this.Load += new System.EventHandler(this.ParamDstoLoad);
			this.groupBox_porcentaje.ResumeLayout(false);
			this.groupBox_porcentaje.PerformLayout();
			this.groupBox_importe.ResumeLayout(false);
			this.groupBox_importe.PerformLayout();
			this.groupBox_convenio.ResumeLayout(false);
			this.groupBox_convenio.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox_convenio;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox_importe;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox_porcentaje;
	}
}
