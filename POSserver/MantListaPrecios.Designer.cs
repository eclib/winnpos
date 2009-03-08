/* INNOVIC 2008 | WinnPOS */

namespace POSserver
{
	partial class MantListaPrecios
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
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_codigo = new System.Windows.Forms.Label();
			this.textBox_idListaPrecio = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idListaPrecio = new System.Windows.Forms.Label();
			this.groupBox_listaPrecios = new System.Windows.Forms.GroupBox();
			this.grilla_listaPrecios = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.groupBox_listaPrecio = new System.Windows.Forms.GroupBox();
			this.textBox_neto = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_neto = new System.Windows.Forms.Label();
			this.textBox_descripcion = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_descripcion = new System.Windows.Forms.Label();
			this.groupBox_listaPrecios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grilla_listaPrecios)).BeginInit();
			this.groupBox_listaPrecio.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_2puntos3
			// 
			this.label_2puntos3.Location = new System.Drawing.Point(101, 83);
			this.label_2puntos3.Name = "label_2puntos3";
			this.label_2puntos3.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos3.TabIndex = 7;
			this.label_2puntos3.Text = ":";
			// 
			// label_sucursal
			// 
			this.label_sucursal.Location = new System.Drawing.Point(6, 83);
			this.label_sucursal.Name = "label_sucursal";
			this.label_sucursal.Size = new System.Drawing.Size(89, 20);
			this.label_sucursal.TabIndex = 6;
			this.label_sucursal.Text = "Sucursal";
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
			// textBox_idListaPrecio
			// 
			this.textBox_idListaPrecio.Location = new System.Drawing.Point(118, 31);
			this.textBox_idListaPrecio.Name = "textBox_idListaPrecio";
			this.textBox_idListaPrecio.Size = new System.Drawing.Size(146, 20);
			this.textBox_idListaPrecio.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idListaPrecio
			// 
			this.label_idListaPrecio.Location = new System.Drawing.Point(6, 31);
			this.label_idListaPrecio.Name = "label_idListaPrecio";
			this.label_idListaPrecio.Size = new System.Drawing.Size(89, 20);
			this.label_idListaPrecio.TabIndex = 0;
			this.label_idListaPrecio.Text = "ID Lista";
			// 
			// groupBox_listaPrecios
			// 
			this.groupBox_listaPrecios.Controls.Add(this.grilla_listaPrecios);
			this.groupBox_listaPrecios.Location = new System.Drawing.Point(12, 239);
			this.groupBox_listaPrecios.Name = "groupBox_listaPrecios";
			this.groupBox_listaPrecios.Size = new System.Drawing.Size(771, 189);
			this.groupBox_listaPrecios.TabIndex = 3;
			this.groupBox_listaPrecios.TabStop = false;
			this.groupBox_listaPrecios.Text = "Listas de precios";
			// 
			// grilla_listaPrecios
			// 
			this.grilla_listaPrecios.AllowUserToAddRows = false;
			this.grilla_listaPrecios.AllowUserToDeleteRows = false;
			this.grilla_listaPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_listaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_listaPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Codigo,
									this.Sucursal,
									this.Descripcion,
									this.Neto});
			this.grilla_listaPrecios.Location = new System.Drawing.Point(6, 19);
			this.grilla_listaPrecios.MultiSelect = false;
			this.grilla_listaPrecios.Name = "grilla_listaPrecios";
			this.grilla_listaPrecios.ReadOnly = true;
			this.grilla_listaPrecios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_listaPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_listaPrecios.Size = new System.Drawing.Size(759, 154);
			this.grilla_listaPrecios.TabIndex = 3;
			this.grilla_listaPrecios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
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
			// Sucursal
			// 
			this.Sucursal.HeaderText = "Sucursal";
			this.Sucursal.Name = "Sucursal";
			this.Sucursal.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Neto
			// 
			this.Neto.HeaderText = "Neto";
			this.Neto.Name = "Neto";
			this.Neto.ReadOnly = true;
			// 
			// textBox_sucursal
			// 
			this.textBox_sucursal.Location = new System.Drawing.Point(118, 83);
			this.textBox_sucursal.Name = "textBox_sucursal";
			this.textBox_sucursal.Size = new System.Drawing.Size(146, 20);
			this.textBox_sucursal.TabIndex = 8;
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
			// groupBox_listaPrecio
			// 
			this.groupBox_listaPrecio.Controls.Add(this.button_salir);
			this.groupBox_listaPrecio.Controls.Add(this.button_eliminar);
			this.groupBox_listaPrecio.Controls.Add(this.button_grabar);
			this.groupBox_listaPrecio.Controls.Add(this.button_nuevo);
			this.groupBox_listaPrecio.Controls.Add(this.textBox_neto);
			this.groupBox_listaPrecio.Controls.Add(this.label_2puntos5);
			this.groupBox_listaPrecio.Controls.Add(this.label_neto);
			this.groupBox_listaPrecio.Controls.Add(this.textBox_descripcion);
			this.groupBox_listaPrecio.Controls.Add(this.label_2puntos4);
			this.groupBox_listaPrecio.Controls.Add(this.label_descripcion);
			this.groupBox_listaPrecio.Controls.Add(this.textBox_sucursal);
			this.groupBox_listaPrecio.Controls.Add(this.label_2puntos3);
			this.groupBox_listaPrecio.Controls.Add(this.label_sucursal);
			this.groupBox_listaPrecio.Controls.Add(this.textBox_codigo);
			this.groupBox_listaPrecio.Controls.Add(this.label_2puntos2);
			this.groupBox_listaPrecio.Controls.Add(this.label_codigo);
			this.groupBox_listaPrecio.Controls.Add(this.textBox_idListaPrecio);
			this.groupBox_listaPrecio.Controls.Add(this.label_2puntos1);
			this.groupBox_listaPrecio.Controls.Add(this.label_idListaPrecio);
			this.groupBox_listaPrecio.Location = new System.Drawing.Point(12, 12);
			this.groupBox_listaPrecio.Name = "groupBox_listaPrecio";
			this.groupBox_listaPrecio.Size = new System.Drawing.Size(771, 220);
			this.groupBox_listaPrecio.TabIndex = 2;
			this.groupBox_listaPrecio.TabStop = false;
			this.groupBox_listaPrecio.Text = "Datos Lista de precios";
			// 
			// textBox_neto
			// 
			this.textBox_neto.Location = new System.Drawing.Point(118, 135);
			this.textBox_neto.Name = "textBox_neto";
			this.textBox_neto.Size = new System.Drawing.Size(146, 20);
			this.textBox_neto.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_neto
			// 
			this.label_neto.Location = new System.Drawing.Point(6, 135);
			this.label_neto.Name = "label_neto";
			this.label_neto.Size = new System.Drawing.Size(89, 20);
			this.label_neto.TabIndex = 12;
			this.label_neto.Text = "Neto";
			// 
			// textBox_descripcion
			// 
			this.textBox_descripcion.Location = new System.Drawing.Point(118, 109);
			this.textBox_descripcion.Name = "textBox_descripcion";
			this.textBox_descripcion.Size = new System.Drawing.Size(146, 20);
			this.textBox_descripcion.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_descripcion
			// 
			this.label_descripcion.Location = new System.Drawing.Point(6, 109);
			this.label_descripcion.Name = "label_descripcion";
			this.label_descripcion.Size = new System.Drawing.Size(89, 20);
			this.label_descripcion.TabIndex = 9;
			this.label_descripcion.Text = "Descripción";
			// 
			// MantListaPrecios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_listaPrecios);
			this.Controls.Add(this.groupBox_listaPrecio);
			this.Name = "MantListaPrecios";
			this.Text = "Mantenedor de lista de precios";
			this.groupBox_listaPrecios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grilla_listaPrecios)).EndInit();
			this.groupBox_listaPrecio.ResumeLayout(false);
			this.groupBox_listaPrecio.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.Label label_codigo;
		private System.Windows.Forms.TextBox textBox_idListaPrecio;
		private System.Windows.Forms.Label label_idListaPrecio;
		private System.Windows.Forms.DataGridView grilla_listaPrecios;
		private System.Windows.Forms.GroupBox groupBox_listaPrecio;
		private System.Windows.Forms.TextBox textBox_neto;
		private System.Windows.Forms.Label label_neto;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.GroupBox groupBox_listaPrecios;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.TextBox textBox_descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_descripcion;
		private System.Windows.Forms.Label label_2puntos3;
	}
}
