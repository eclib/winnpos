/* INNOVIC 2009 - POSserver */

namespace POSserver
{
	partial class MantConvenios
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
			this.label_2puntos3 = new System.Windows.Forms.Label();
			this.label_descripcion = new System.Windows.Forms.Label();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_idConvenio = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idConvenio = new System.Windows.Forms.Label();
			this.groupBox_convenios = new System.Windows.Forms.GroupBox();
			this.grilla_convenios = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PorcDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox_descripcion = new System.Windows.Forms.TextBox();
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.textBox_fechaFinal = new System.Windows.Forms.TextBox();
			this.label_2puntos7 = new System.Windows.Forms.Label();
			this.label_fechaFinal = new System.Windows.Forms.Label();
			this.textBox_fechaInicio = new System.Windows.Forms.TextBox();
			this.groupBox_convenio = new System.Windows.Forms.GroupBox();
			this.label_2puntos6 = new System.Windows.Forms.Label();
			this.label_fechaInicio = new System.Windows.Forms.Label();
			this.textBox_porcDescuento = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_porcDescuento = new System.Windows.Forms.Label();
			this.textBox_rut = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_rut = new System.Windows.Forms.Label();
			this.groupBox_convenios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grilla_convenios)).BeginInit();
			this.groupBox_convenio.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_2puntos3
			// 
			this.label_2puntos3.Location = new System.Drawing.Point(101, 110);
			this.label_2puntos3.Name = "label_2puntos3";
			this.label_2puntos3.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos3.TabIndex = 7;
			this.label_2puntos3.Text = ":";
			// 
			// label_descripcion
			// 
			this.label_descripcion.Location = new System.Drawing.Point(6, 110);
			this.label_descripcion.Name = "label_descripcion";
			this.label_descripcion.Size = new System.Drawing.Size(89, 20);
			this.label_descripcion.TabIndex = 6;
			this.label_descripcion.Text = "Descripción";
			// 
			// textBox_sucursal
			// 
			this.textBox_sucursal.Location = new System.Drawing.Point(118, 57);
			this.textBox_sucursal.Name = "textBox_sucursal";
			this.textBox_sucursal.Size = new System.Drawing.Size(146, 20);
			this.textBox_sucursal.TabIndex = 5;
			// 
			// label_2puntos2
			// 
			this.label_2puntos2.Location = new System.Drawing.Point(101, 57);
			this.label_2puntos2.Name = "label_2puntos2";
			this.label_2puntos2.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos2.TabIndex = 4;
			this.label_2puntos2.Text = ":";
			// 
			// label_sucursal
			// 
			this.label_sucursal.Location = new System.Drawing.Point(6, 57);
			this.label_sucursal.Name = "label_sucursal";
			this.label_sucursal.Size = new System.Drawing.Size(89, 20);
			this.label_sucursal.TabIndex = 3;
			this.label_sucursal.Text = "Sucursal";
			// 
			// textBox_idConvenio
			// 
			this.textBox_idConvenio.Location = new System.Drawing.Point(118, 31);
			this.textBox_idConvenio.Name = "textBox_idConvenio";
			this.textBox_idConvenio.Size = new System.Drawing.Size(146, 20);
			this.textBox_idConvenio.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idConvenio
			// 
			this.label_idConvenio.Location = new System.Drawing.Point(6, 31);
			this.label_idConvenio.Name = "label_idConvenio";
			this.label_idConvenio.Size = new System.Drawing.Size(89, 20);
			this.label_idConvenio.TabIndex = 0;
			this.label_idConvenio.Text = "ID Convenios";
			// 
			// groupBox_convenios
			// 
			this.groupBox_convenios.Controls.Add(this.grilla_convenios);
			this.groupBox_convenios.Location = new System.Drawing.Point(12, 239);
			this.groupBox_convenios.Name = "groupBox_convenios";
			this.groupBox_convenios.Size = new System.Drawing.Size(771, 189);
			this.groupBox_convenios.TabIndex = 3;
			this.groupBox_convenios.TabStop = false;
			this.groupBox_convenios.Text = "Convenios";
			// 
			// grilla_convenios
			// 
			this.grilla_convenios.AllowUserToAddRows = false;
			this.grilla_convenios.AllowUserToDeleteRows = false;
			this.grilla_convenios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_convenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_convenios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Sucursal,
									this.Rut,
									this.Descripcion,
									this.PorcDescuento,
									this.FechaInicio,
									this.FechaFinal});
			this.grilla_convenios.Location = new System.Drawing.Point(6, 19);
			this.grilla_convenios.MultiSelect = false;
			this.grilla_convenios.Name = "grilla_convenios";
			this.grilla_convenios.ReadOnly = true;
			this.grilla_convenios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_convenios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_convenios.Size = new System.Drawing.Size(759, 154);
			this.grilla_convenios.TabIndex = 3;
			this.grilla_convenios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Sucursal
			// 
			this.Sucursal.HeaderText = "Sucursal";
			this.Sucursal.Name = "Sucursal";
			this.Sucursal.ReadOnly = true;
			// 
			// Rut
			// 
			this.Rut.HeaderText = "Rut";
			this.Rut.Name = "Rut";
			this.Rut.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// PorcDescuento
			// 
			this.PorcDescuento.HeaderText = "% Descuento";
			this.PorcDescuento.Name = "PorcDescuento";
			this.PorcDescuento.ReadOnly = true;
			// 
			// FechaInicio
			// 
			this.FechaInicio.HeaderText = "Fecha Inicio";
			this.FechaInicio.Name = "FechaInicio";
			this.FechaInicio.ReadOnly = true;
			// 
			// FechaFinal
			// 
			this.FechaFinal.HeaderText = "Fecha Final";
			this.FechaFinal.Name = "FechaFinal";
			this.FechaFinal.ReadOnly = true;
			// 
			// textBox_descripcion
			// 
			this.textBox_descripcion.Location = new System.Drawing.Point(118, 110);
			this.textBox_descripcion.Name = "textBox_descripcion";
			this.textBox_descripcion.Size = new System.Drawing.Size(543, 20);
			this.textBox_descripcion.TabIndex = 8;
			// 
			// button_salir
			// 
			this.button_salir.Location = new System.Drawing.Point(690, 161);
			this.button_salir.Name = "button_salir";
			this.button_salir.Size = new System.Drawing.Size(75, 20);
			this.button_salir.TabIndex = 25;
			this.button_salir.Text = "&Salir";
			this.button_salir.UseVisualStyleBackColor = true;
			this.button_salir.Click += new System.EventHandler(this.Button_salirClick);
			// 
			// button_eliminar
			// 
			this.button_eliminar.Enabled = false;
			this.button_eliminar.Location = new System.Drawing.Point(690, 83);
			this.button_eliminar.Name = "button_eliminar";
			this.button_eliminar.Size = new System.Drawing.Size(75, 20);
			this.button_eliminar.TabIndex = 24;
			this.button_eliminar.Text = "&Eliminar";
			this.button_eliminar.UseVisualStyleBackColor = true;
			this.button_eliminar.Click += new System.EventHandler(this.Button_eliminarClick);
			// 
			// button_grabar
			// 
			this.button_grabar.Enabled = false;
			this.button_grabar.Location = new System.Drawing.Point(690, 57);
			this.button_grabar.Name = "button_grabar";
			this.button_grabar.Size = new System.Drawing.Size(75, 20);
			this.button_grabar.TabIndex = 23;
			this.button_grabar.Text = "&Grabar";
			this.button_grabar.UseVisualStyleBackColor = true;
			this.button_grabar.Click += new System.EventHandler(this.Button_grabarClick);
			// 
			// button_nuevo
			// 
			this.button_nuevo.Location = new System.Drawing.Point(690, 31);
			this.button_nuevo.Name = "button_nuevo";
			this.button_nuevo.Size = new System.Drawing.Size(75, 20);
			this.button_nuevo.TabIndex = 21;
			this.button_nuevo.Text = "&Nuevo";
			this.button_nuevo.UseVisualStyleBackColor = true;
			this.button_nuevo.Click += new System.EventHandler(this.Button_nuevoClick);
			// 
			// textBox_fechaFinal
			// 
			this.textBox_fechaFinal.Location = new System.Drawing.Point(118, 187);
			this.textBox_fechaFinal.Name = "textBox_fechaFinal";
			this.textBox_fechaFinal.Size = new System.Drawing.Size(146, 20);
			this.textBox_fechaFinal.TabIndex = 20;
			// 
			// label_2puntos7
			// 
			this.label_2puntos7.Location = new System.Drawing.Point(101, 187);
			this.label_2puntos7.Name = "label_2puntos7";
			this.label_2puntos7.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos7.TabIndex = 19;
			this.label_2puntos7.Text = ":";
			// 
			// label_fechaFinal
			// 
			this.label_fechaFinal.Location = new System.Drawing.Point(6, 187);
			this.label_fechaFinal.Name = "label_fechaFinal";
			this.label_fechaFinal.Size = new System.Drawing.Size(89, 20);
			this.label_fechaFinal.TabIndex = 18;
			this.label_fechaFinal.Text = "Fecha Final";
			// 
			// textBox_fechaInicio
			// 
			this.textBox_fechaInicio.Location = new System.Drawing.Point(118, 161);
			this.textBox_fechaInicio.Name = "textBox_fechaInicio";
			this.textBox_fechaInicio.Size = new System.Drawing.Size(146, 20);
			this.textBox_fechaInicio.TabIndex = 17;
			// 
			// groupBox_convenio
			// 
			this.groupBox_convenio.Controls.Add(this.button_salir);
			this.groupBox_convenio.Controls.Add(this.button_eliminar);
			this.groupBox_convenio.Controls.Add(this.button_grabar);
			this.groupBox_convenio.Controls.Add(this.button_nuevo);
			this.groupBox_convenio.Controls.Add(this.textBox_fechaFinal);
			this.groupBox_convenio.Controls.Add(this.label_2puntos7);
			this.groupBox_convenio.Controls.Add(this.label_fechaFinal);
			this.groupBox_convenio.Controls.Add(this.textBox_fechaInicio);
			this.groupBox_convenio.Controls.Add(this.label_2puntos6);
			this.groupBox_convenio.Controls.Add(this.label_fechaInicio);
			this.groupBox_convenio.Controls.Add(this.textBox_porcDescuento);
			this.groupBox_convenio.Controls.Add(this.label_2puntos5);
			this.groupBox_convenio.Controls.Add(this.label_porcDescuento);
			this.groupBox_convenio.Controls.Add(this.textBox_rut);
			this.groupBox_convenio.Controls.Add(this.label_2puntos4);
			this.groupBox_convenio.Controls.Add(this.label_rut);
			this.groupBox_convenio.Controls.Add(this.textBox_descripcion);
			this.groupBox_convenio.Controls.Add(this.label_2puntos3);
			this.groupBox_convenio.Controls.Add(this.label_descripcion);
			this.groupBox_convenio.Controls.Add(this.textBox_sucursal);
			this.groupBox_convenio.Controls.Add(this.label_2puntos2);
			this.groupBox_convenio.Controls.Add(this.label_sucursal);
			this.groupBox_convenio.Controls.Add(this.textBox_idConvenio);
			this.groupBox_convenio.Controls.Add(this.label_2puntos1);
			this.groupBox_convenio.Controls.Add(this.label_idConvenio);
			this.groupBox_convenio.Location = new System.Drawing.Point(12, 12);
			this.groupBox_convenio.Name = "groupBox_convenio";
			this.groupBox_convenio.Size = new System.Drawing.Size(771, 220);
			this.groupBox_convenio.TabIndex = 2;
			this.groupBox_convenio.TabStop = false;
			this.groupBox_convenio.Text = "Datos Convenio";
			// 
			// label_2puntos6
			// 
			this.label_2puntos6.Location = new System.Drawing.Point(101, 161);
			this.label_2puntos6.Name = "label_2puntos6";
			this.label_2puntos6.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos6.TabIndex = 16;
			this.label_2puntos6.Text = ":";
			// 
			// label_fechaInicio
			// 
			this.label_fechaInicio.Location = new System.Drawing.Point(6, 161);
			this.label_fechaInicio.Name = "label_fechaInicio";
			this.label_fechaInicio.Size = new System.Drawing.Size(89, 20);
			this.label_fechaInicio.TabIndex = 15;
			this.label_fechaInicio.Text = "Fecha Inicio";
			// 
			// textBox_porcDescuento
			// 
			this.textBox_porcDescuento.Location = new System.Drawing.Point(118, 135);
			this.textBox_porcDescuento.Name = "textBox_porcDescuento";
			this.textBox_porcDescuento.Size = new System.Drawing.Size(46, 20);
			this.textBox_porcDescuento.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_porcDescuento
			// 
			this.label_porcDescuento.Location = new System.Drawing.Point(6, 135);
			this.label_porcDescuento.Name = "label_porcDescuento";
			this.label_porcDescuento.Size = new System.Drawing.Size(89, 20);
			this.label_porcDescuento.TabIndex = 12;
			this.label_porcDescuento.Text = "% Descuento";
			// 
			// textBox_rut
			// 
			this.textBox_rut.Location = new System.Drawing.Point(118, 84);
			this.textBox_rut.Name = "textBox_rut";
			this.textBox_rut.Size = new System.Drawing.Size(146, 20);
			this.textBox_rut.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 84);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_rut
			// 
			this.label_rut.Location = new System.Drawing.Point(6, 84);
			this.label_rut.Name = "label_rut";
			this.label_rut.Size = new System.Drawing.Size(89, 20);
			this.label_rut.TabIndex = 9;
			this.label_rut.Text = "Rut";
			// 
			// MantConvenios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_convenios);
			this.Controls.Add(this.groupBox_convenio);
			this.Name = "MantConvenios";
			this.Text = "Mantenedor Convenios";
			this.groupBox_convenios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grilla_convenios)).EndInit();
			this.groupBox_convenio.ResumeLayout(false);
			this.groupBox_convenio.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_rut;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.TextBox textBox_rut;
		private System.Windows.Forms.Label label_porcDescuento;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.TextBox textBox_porcDescuento;
		private System.Windows.Forms.Label label_fechaInicio;
		private System.Windows.Forms.Label label_2puntos6;
		private System.Windows.Forms.GroupBox groupBox_convenio;
		private System.Windows.Forms.TextBox textBox_fechaInicio;
		private System.Windows.Forms.Label label_fechaFinal;
		private System.Windows.Forms.Label label_2puntos7;
		private System.Windows.Forms.TextBox textBox_fechaFinal;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.TextBox textBox_descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn PorcDescuento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridView grilla_convenios;
		private System.Windows.Forms.GroupBox groupBox_convenios;
		private System.Windows.Forms.Label label_idConvenio;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.TextBox textBox_idConvenio;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_descripcion;
		private System.Windows.Forms.Label label_2puntos3;
	}
}
