/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 07/03/2009
 * Hora: 09:05 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POSserver
{
	partial class MantFormaPago
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
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.textBox_fraccion = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_fraccion = new System.Windows.Forms.Label();
			this.textBox_descripcion = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_descripcion = new System.Windows.Forms.Label();
			this.groupBox_formaPago = new System.Windows.Forms.GroupBox();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_codigo = new System.Windows.Forms.Label();
			this.textBox_idFormaPago = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idFormaPago = new System.Windows.Forms.Label();
			this.groupBox_formaPagos = new System.Windows.Forms.GroupBox();
			this.grilla_formaPagos = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fraccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_formaPago.SuspendLayout();
			this.groupBox_formaPagos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grilla_formaPagos)).BeginInit();
			this.SuspendLayout();
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
			// textBox_fraccion
			// 
			this.textBox_fraccion.Location = new System.Drawing.Point(118, 109);
			this.textBox_fraccion.Name = "textBox_fraccion";
			this.textBox_fraccion.Size = new System.Drawing.Size(146, 20);
			this.textBox_fraccion.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_fraccion
			// 
			this.label_fraccion.Location = new System.Drawing.Point(6, 109);
			this.label_fraccion.Name = "label_fraccion";
			this.label_fraccion.Size = new System.Drawing.Size(89, 20);
			this.label_fraccion.TabIndex = 12;
			this.label_fraccion.Text = "Fracción";
			// 
			// textBox_descripcion
			// 
			this.textBox_descripcion.Location = new System.Drawing.Point(118, 83);
			this.textBox_descripcion.Name = "textBox_descripcion";
			this.textBox_descripcion.Size = new System.Drawing.Size(146, 20);
			this.textBox_descripcion.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 83);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_descripcion
			// 
			this.label_descripcion.Location = new System.Drawing.Point(6, 83);
			this.label_descripcion.Name = "label_descripcion";
			this.label_descripcion.Size = new System.Drawing.Size(89, 20);
			this.label_descripcion.TabIndex = 9;
			this.label_descripcion.Text = "Descripción";
			// 
			// groupBox_formaPago
			// 
			this.groupBox_formaPago.Controls.Add(this.button_salir);
			this.groupBox_formaPago.Controls.Add(this.button_eliminar);
			this.groupBox_formaPago.Controls.Add(this.button_grabar);
			this.groupBox_formaPago.Controls.Add(this.button_nuevo);
			this.groupBox_formaPago.Controls.Add(this.textBox_fraccion);
			this.groupBox_formaPago.Controls.Add(this.label_2puntos5);
			this.groupBox_formaPago.Controls.Add(this.label_fraccion);
			this.groupBox_formaPago.Controls.Add(this.textBox_descripcion);
			this.groupBox_formaPago.Controls.Add(this.label_2puntos4);
			this.groupBox_formaPago.Controls.Add(this.label_descripcion);
			this.groupBox_formaPago.Controls.Add(this.textBox_codigo);
			this.groupBox_formaPago.Controls.Add(this.label_2puntos2);
			this.groupBox_formaPago.Controls.Add(this.label_codigo);
			this.groupBox_formaPago.Controls.Add(this.textBox_idFormaPago);
			this.groupBox_formaPago.Controls.Add(this.label_2puntos1);
			this.groupBox_formaPago.Controls.Add(this.label_idFormaPago);
			this.groupBox_formaPago.Location = new System.Drawing.Point(12, 12);
			this.groupBox_formaPago.Name = "groupBox_formaPago";
			this.groupBox_formaPago.Size = new System.Drawing.Size(771, 220);
			this.groupBox_formaPago.TabIndex = 4;
			this.groupBox_formaPago.TabStop = false;
			this.groupBox_formaPago.Text = "Datos Forma de Pago";
			// 
			// textBox_codigo
			// 
			this.textBox_codigo.Location = new System.Drawing.Point(118, 57);
			this.textBox_codigo.Name = "textBox_codigo";
			this.textBox_codigo.Size = new System.Drawing.Size(146, 20);
			this.textBox_codigo.TabIndex = 5;
			// 
			// label_2puntos2
			// 
			this.label_2puntos2.Location = new System.Drawing.Point(101, 57);
			this.label_2puntos2.Name = "label_2puntos2";
			this.label_2puntos2.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos2.TabIndex = 4;
			this.label_2puntos2.Text = ":";
			// 
			// label_codigo
			// 
			this.label_codigo.Location = new System.Drawing.Point(6, 57);
			this.label_codigo.Name = "label_codigo";
			this.label_codigo.Size = new System.Drawing.Size(89, 20);
			this.label_codigo.TabIndex = 3;
			this.label_codigo.Text = "Codigo";
			// 
			// textBox_idFormaPago
			// 
			this.textBox_idFormaPago.Location = new System.Drawing.Point(118, 31);
			this.textBox_idFormaPago.Name = "textBox_idFormaPago";
			this.textBox_idFormaPago.Size = new System.Drawing.Size(146, 20);
			this.textBox_idFormaPago.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idFormaPago
			// 
			this.label_idFormaPago.Location = new System.Drawing.Point(6, 31);
			this.label_idFormaPago.Name = "label_idFormaPago";
			this.label_idFormaPago.Size = new System.Drawing.Size(89, 20);
			this.label_idFormaPago.TabIndex = 0;
			this.label_idFormaPago.Text = "ID Lista";
			// 
			// groupBox_formaPagos
			// 
			this.groupBox_formaPagos.Controls.Add(this.grilla_formaPagos);
			this.groupBox_formaPagos.Location = new System.Drawing.Point(12, 239);
			this.groupBox_formaPagos.Name = "groupBox_formaPagos";
			this.groupBox_formaPagos.Size = new System.Drawing.Size(771, 189);
			this.groupBox_formaPagos.TabIndex = 5;
			this.groupBox_formaPagos.TabStop = false;
			this.groupBox_formaPagos.Text = "Listas de precios";
			// 
			// grilla_formaPagos
			// 
			this.grilla_formaPagos.AllowUserToAddRows = false;
			this.grilla_formaPagos.AllowUserToDeleteRows = false;
			this.grilla_formaPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_formaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_formaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Codigo,
									this.Descripcion,
									this.Fraccion});
			this.grilla_formaPagos.Location = new System.Drawing.Point(6, 19);
			this.grilla_formaPagos.MultiSelect = false;
			this.grilla_formaPagos.Name = "grilla_formaPagos";
			this.grilla_formaPagos.ReadOnly = true;
			this.grilla_formaPagos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_formaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_formaPagos.Size = new System.Drawing.Size(759, 154);
			this.grilla_formaPagos.TabIndex = 3;
			this.grilla_formaPagos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Fraccion
			// 
			this.Fraccion.HeaderText = "Fracción";
			this.Fraccion.Name = "Fraccion";
			this.Fraccion.ReadOnly = true;
			// 
			// MantFormaPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_formaPago);
			this.Controls.Add(this.groupBox_formaPagos);
			this.Name = "MantFormaPago";
			this.Text = "Mantenedor de Formas de Pago";
			this.groupBox_formaPago.ResumeLayout(false);
			this.groupBox_formaPago.PerformLayout();
			this.groupBox_formaPagos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grilla_formaPagos)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Fraccion;
		private System.Windows.Forms.DataGridView grilla_formaPagos;
		private System.Windows.Forms.GroupBox groupBox_formaPagos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.Label label_idFormaPago;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.TextBox textBox_idFormaPago;
		private System.Windows.Forms.Label label_codigo;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.GroupBox groupBox_formaPago;
		private System.Windows.Forms.Label label_descripcion;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.TextBox textBox_descripcion;
		private System.Windows.Forms.Label label_fraccion;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.TextBox textBox_fraccion;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
	}
}
