/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 07/03/2009
 * Hora: 08:10 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POSserver
{
	partial class MantInventario
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
			this.label_codigo = new System.Windows.Forms.Label();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_idInventario = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idInventario = new System.Windows.Forms.Label();
			this.groupBox_inventarios = new System.Windows.Forms.GroupBox();
			this.grilla_inventarios = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.groupBox_inventario = new System.Windows.Forms.GroupBox();
			this.textBox_stockMin = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_stockMin = new System.Windows.Forms.Label();
			this.textBox_stock = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_stock = new System.Windows.Forms.Label();
			this.groupBox_inventarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grilla_inventarios)).BeginInit();
			this.groupBox_inventario.SuspendLayout();
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
			// label_codigo
			// 
			this.label_codigo.Location = new System.Drawing.Point(6, 83);
			this.label_codigo.Name = "label_codigo";
			this.label_codigo.Size = new System.Drawing.Size(89, 20);
			this.label_codigo.TabIndex = 6;
			this.label_codigo.Text = "Codigo";
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
			// textBox_idInventario
			// 
			this.textBox_idInventario.Location = new System.Drawing.Point(118, 31);
			this.textBox_idInventario.Name = "textBox_idInventario";
			this.textBox_idInventario.Size = new System.Drawing.Size(146, 20);
			this.textBox_idInventario.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idInventario
			// 
			this.label_idInventario.Location = new System.Drawing.Point(6, 31);
			this.label_idInventario.Name = "label_idInventario";
			this.label_idInventario.Size = new System.Drawing.Size(89, 20);
			this.label_idInventario.TabIndex = 0;
			this.label_idInventario.Text = "ID Inventario";
			// 
			// groupBox_inventarios
			// 
			this.groupBox_inventarios.Controls.Add(this.grilla_inventarios);
			this.groupBox_inventarios.Location = new System.Drawing.Point(12, 239);
			this.groupBox_inventarios.Name = "groupBox_inventarios";
			this.groupBox_inventarios.Size = new System.Drawing.Size(771, 189);
			this.groupBox_inventarios.TabIndex = 3;
			this.groupBox_inventarios.TabStop = false;
			this.groupBox_inventarios.Text = "Inventarios";
			// 
			// grilla_inventarios
			// 
			this.grilla_inventarios.AllowUserToAddRows = false;
			this.grilla_inventarios.AllowUserToDeleteRows = false;
			this.grilla_inventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_inventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_inventarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Sucursal,
									this.Codigo,
									this.Stock,
									this.StockMin});
			this.grilla_inventarios.Location = new System.Drawing.Point(6, 19);
			this.grilla_inventarios.MultiSelect = false;
			this.grilla_inventarios.Name = "grilla_inventarios";
			this.grilla_inventarios.ReadOnly = true;
			this.grilla_inventarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_inventarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_inventarios.Size = new System.Drawing.Size(759, 154);
			this.grilla_inventarios.TabIndex = 3;
			this.grilla_inventarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
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
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Stock
			// 
			this.Stock.HeaderText = "Stock";
			this.Stock.Name = "Stock";
			this.Stock.ReadOnly = true;
			// 
			// StockMin
			// 
			this.StockMin.HeaderText = "Stock Minimo";
			this.StockMin.Name = "StockMin";
			this.StockMin.ReadOnly = true;
			// 
			// textBox_codigo
			// 
			this.textBox_codigo.Location = new System.Drawing.Point(118, 83);
			this.textBox_codigo.Name = "textBox_codigo";
			this.textBox_codigo.Size = new System.Drawing.Size(146, 20);
			this.textBox_codigo.TabIndex = 8;
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
			// groupBox_inventario
			// 
			this.groupBox_inventario.Controls.Add(this.button_salir);
			this.groupBox_inventario.Controls.Add(this.button_eliminar);
			this.groupBox_inventario.Controls.Add(this.button_grabar);
			this.groupBox_inventario.Controls.Add(this.button_nuevo);
			this.groupBox_inventario.Controls.Add(this.textBox_stockMin);
			this.groupBox_inventario.Controls.Add(this.label_2puntos5);
			this.groupBox_inventario.Controls.Add(this.label_stockMin);
			this.groupBox_inventario.Controls.Add(this.textBox_stock);
			this.groupBox_inventario.Controls.Add(this.label_2puntos4);
			this.groupBox_inventario.Controls.Add(this.label_stock);
			this.groupBox_inventario.Controls.Add(this.textBox_codigo);
			this.groupBox_inventario.Controls.Add(this.label_2puntos3);
			this.groupBox_inventario.Controls.Add(this.label_codigo);
			this.groupBox_inventario.Controls.Add(this.textBox_sucursal);
			this.groupBox_inventario.Controls.Add(this.label_2puntos2);
			this.groupBox_inventario.Controls.Add(this.label_sucursal);
			this.groupBox_inventario.Controls.Add(this.textBox_idInventario);
			this.groupBox_inventario.Controls.Add(this.label_2puntos1);
			this.groupBox_inventario.Controls.Add(this.label_idInventario);
			this.groupBox_inventario.Location = new System.Drawing.Point(12, 12);
			this.groupBox_inventario.Name = "groupBox_inventario";
			this.groupBox_inventario.Size = new System.Drawing.Size(771, 220);
			this.groupBox_inventario.TabIndex = 2;
			this.groupBox_inventario.TabStop = false;
			this.groupBox_inventario.Text = "Datos Inventario";
			// 
			// textBox_stockMin
			// 
			this.textBox_stockMin.Location = new System.Drawing.Point(118, 135);
			this.textBox_stockMin.Name = "textBox_stockMin";
			this.textBox_stockMin.Size = new System.Drawing.Size(146, 20);
			this.textBox_stockMin.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_stockMin
			// 
			this.label_stockMin.Location = new System.Drawing.Point(6, 135);
			this.label_stockMin.Name = "label_stockMin";
			this.label_stockMin.Size = new System.Drawing.Size(89, 20);
			this.label_stockMin.TabIndex = 12;
			this.label_stockMin.Text = "Stock Minimo";
			// 
			// textBox_stock
			// 
			this.textBox_stock.Location = new System.Drawing.Point(118, 109);
			this.textBox_stock.Name = "textBox_stock";
			this.textBox_stock.Size = new System.Drawing.Size(146, 20);
			this.textBox_stock.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_stock
			// 
			this.label_stock.Location = new System.Drawing.Point(6, 109);
			this.label_stock.Name = "label_stock";
			this.label_stock.Size = new System.Drawing.Size(89, 20);
			this.label_stock.TabIndex = 9;
			this.label_stock.Text = "Stock";
			// 
			// MantInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_inventarios);
			this.Controls.Add(this.groupBox_inventario);
			this.Name = "MantInventario";
			this.Text = "Mantenedor de Inventario";
			this.groupBox_inventarios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grilla_inventarios)).EndInit();
			this.groupBox_inventario.ResumeLayout(false);
			this.groupBox_inventario.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_stock;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.TextBox textBox_stock;
		private System.Windows.Forms.Label label_stockMin;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.TextBox textBox_stockMin;
		private System.Windows.Forms.GroupBox groupBox_inventario;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridView grilla_inventarios;
		private System.Windows.Forms.GroupBox groupBox_inventarios;
		private System.Windows.Forms.Label label_idInventario;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.TextBox textBox_idInventario;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_codigo;
		private System.Windows.Forms.Label label_2puntos3;
	}
}
