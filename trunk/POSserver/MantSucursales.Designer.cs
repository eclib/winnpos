/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/02/2009
 * Hora: 04:16 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POS
{
	partial class MantSucursales
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
			this.groupBox_sucursal = new System.Windows.Forms.GroupBox();
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.textBox_region = new System.Windows.Forms.TextBox();
			this.label_2puntos7 = new System.Windows.Forms.Label();
			this.label_region = new System.Windows.Forms.Label();
			this.textBox_comuna = new System.Windows.Forms.TextBox();
			this.label_2puntos6 = new System.Windows.Forms.Label();
			this.label_comuna = new System.Windows.Forms.Label();
			this.textBox_ciudad = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_ciudad = new System.Windows.Forms.Label();
			this.textBox_direccion = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_direccion = new System.Windows.Forms.Label();
			this.textBox_descripcion = new System.Windows.Forms.TextBox();
			this.label_2puntos3 = new System.Windows.Forms.Label();
			this.label_descripcion = new System.Windows.Forms.Label();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_idSucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idSucursal = new System.Windows.Forms.Label();
			this.groupBox_sucursales = new System.Windows.Forms.GroupBox();
			this.grilla_sucursales = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_sucursal.SuspendLayout();
			this.groupBox_sucursales.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grilla_sucursales)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox_sucursal
			// 
			this.groupBox_sucursal.Controls.Add(this.button_salir);
			this.groupBox_sucursal.Controls.Add(this.button_eliminar);
			this.groupBox_sucursal.Controls.Add(this.button_grabar);
			this.groupBox_sucursal.Controls.Add(this.button_nuevo);
			this.groupBox_sucursal.Controls.Add(this.textBox_region);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos7);
			this.groupBox_sucursal.Controls.Add(this.label_region);
			this.groupBox_sucursal.Controls.Add(this.textBox_comuna);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos6);
			this.groupBox_sucursal.Controls.Add(this.label_comuna);
			this.groupBox_sucursal.Controls.Add(this.textBox_ciudad);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos5);
			this.groupBox_sucursal.Controls.Add(this.label_ciudad);
			this.groupBox_sucursal.Controls.Add(this.textBox_direccion);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos4);
			this.groupBox_sucursal.Controls.Add(this.label_direccion);
			this.groupBox_sucursal.Controls.Add(this.textBox_descripcion);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos3);
			this.groupBox_sucursal.Controls.Add(this.label_descripcion);
			this.groupBox_sucursal.Controls.Add(this.textBox_sucursal);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos2);
			this.groupBox_sucursal.Controls.Add(this.label_sucursal);
			this.groupBox_sucursal.Controls.Add(this.textBox_idSucursal);
			this.groupBox_sucursal.Controls.Add(this.label_2puntos1);
			this.groupBox_sucursal.Controls.Add(this.label_idSucursal);
			this.groupBox_sucursal.Location = new System.Drawing.Point(12, 12);
			this.groupBox_sucursal.Name = "groupBox_sucursal";
			this.groupBox_sucursal.Size = new System.Drawing.Size(771, 220);
			this.groupBox_sucursal.TabIndex = 0;
			this.groupBox_sucursal.TabStop = false;
			this.groupBox_sucursal.Text = "Datos Sucursal";
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
			// textBox_region
			// 
			this.textBox_region.Location = new System.Drawing.Point(118, 187);
			this.textBox_region.Name = "textBox_region";
			this.textBox_region.Size = new System.Drawing.Size(146, 20);
			this.textBox_region.TabIndex = 20;
			// 
			// label_2puntos7
			// 
			this.label_2puntos7.Location = new System.Drawing.Point(101, 187);
			this.label_2puntos7.Name = "label_2puntos7";
			this.label_2puntos7.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos7.TabIndex = 19;
			this.label_2puntos7.Text = ":";
			// 
			// label_region
			// 
			this.label_region.Location = new System.Drawing.Point(6, 187);
			this.label_region.Name = "label_region";
			this.label_region.Size = new System.Drawing.Size(89, 20);
			this.label_region.TabIndex = 18;
			this.label_region.Text = "Región";
			// 
			// textBox_comuna
			// 
			this.textBox_comuna.Location = new System.Drawing.Point(118, 161);
			this.textBox_comuna.Name = "textBox_comuna";
			this.textBox_comuna.Size = new System.Drawing.Size(146, 20);
			this.textBox_comuna.TabIndex = 17;
			// 
			// label_2puntos6
			// 
			this.label_2puntos6.Location = new System.Drawing.Point(101, 161);
			this.label_2puntos6.Name = "label_2puntos6";
			this.label_2puntos6.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos6.TabIndex = 16;
			this.label_2puntos6.Text = ":";
			// 
			// label_comuna
			// 
			this.label_comuna.Location = new System.Drawing.Point(6, 161);
			this.label_comuna.Name = "label_comuna";
			this.label_comuna.Size = new System.Drawing.Size(89, 20);
			this.label_comuna.TabIndex = 15;
			this.label_comuna.Text = "Comuna";
			// 
			// textBox_ciudad
			// 
			this.textBox_ciudad.Location = new System.Drawing.Point(118, 135);
			this.textBox_ciudad.Name = "textBox_ciudad";
			this.textBox_ciudad.Size = new System.Drawing.Size(146, 20);
			this.textBox_ciudad.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_ciudad
			// 
			this.label_ciudad.Location = new System.Drawing.Point(6, 135);
			this.label_ciudad.Name = "label_ciudad";
			this.label_ciudad.Size = new System.Drawing.Size(89, 20);
			this.label_ciudad.TabIndex = 12;
			this.label_ciudad.Text = "Ciudad";
			// 
			// textBox_direccion
			// 
			this.textBox_direccion.Location = new System.Drawing.Point(118, 109);
			this.textBox_direccion.Name = "textBox_direccion";
			this.textBox_direccion.Size = new System.Drawing.Size(146, 20);
			this.textBox_direccion.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_direccion
			// 
			this.label_direccion.Location = new System.Drawing.Point(6, 109);
			this.label_direccion.Name = "label_direccion";
			this.label_direccion.Size = new System.Drawing.Size(89, 20);
			this.label_direccion.TabIndex = 9;
			this.label_direccion.Text = "Dirección";
			// 
			// textBox_descripcion
			// 
			this.textBox_descripcion.Location = new System.Drawing.Point(118, 83);
			this.textBox_descripcion.Name = "textBox_descripcion";
			this.textBox_descripcion.Size = new System.Drawing.Size(146, 20);
			this.textBox_descripcion.TabIndex = 8;
			// 
			// label_2puntos3
			// 
			this.label_2puntos3.Location = new System.Drawing.Point(101, 83);
			this.label_2puntos3.Name = "label_2puntos3";
			this.label_2puntos3.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos3.TabIndex = 7;
			this.label_2puntos3.Text = ":";
			// 
			// label_descripcion
			// 
			this.label_descripcion.Location = new System.Drawing.Point(6, 83);
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
			// textBox_idSucursal
			// 
			this.textBox_idSucursal.Location = new System.Drawing.Point(118, 31);
			this.textBox_idSucursal.Name = "textBox_idSucursal";
			this.textBox_idSucursal.Size = new System.Drawing.Size(146, 20);
			this.textBox_idSucursal.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idSucursal
			// 
			this.label_idSucursal.Location = new System.Drawing.Point(6, 31);
			this.label_idSucursal.Name = "label_idSucursal";
			this.label_idSucursal.Size = new System.Drawing.Size(89, 20);
			this.label_idSucursal.TabIndex = 0;
			this.label_idSucursal.Text = "ID Sucursal";
			// 
			// groupBox_sucursales
			// 
			this.groupBox_sucursales.Controls.Add(this.grilla_sucursales);
			this.groupBox_sucursales.Location = new System.Drawing.Point(12, 239);
			this.groupBox_sucursales.Name = "groupBox_sucursales";
			this.groupBox_sucursales.Size = new System.Drawing.Size(771, 189);
			this.groupBox_sucursales.TabIndex = 1;
			this.groupBox_sucursales.TabStop = false;
			this.groupBox_sucursales.Text = "Sucursales";
			// 
			// grilla_sucursales
			// 
			this.grilla_sucursales.AllowUserToAddRows = false;
			this.grilla_sucursales.AllowUserToDeleteRows = false;
			this.grilla_sucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_sucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Sucursal,
									this.Descripcion,
									this.Direccion,
									this.Ciudad,
									this.Comuna,
									this._Region});
			this.grilla_sucursales.Location = new System.Drawing.Point(6, 19);
			this.grilla_sucursales.MultiSelect = false;
			this.grilla_sucursales.Name = "grilla_sucursales";
			this.grilla_sucursales.ReadOnly = true;
			this.grilla_sucursales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_sucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_sucursales.Size = new System.Drawing.Size(759, 154);
			this.grilla_sucursales.TabIndex = 3;
			this.grilla_sucursales.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
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
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Direccion
			// 
			this.Direccion.HeaderText = "Direccion";
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			// 
			// Ciudad
			// 
			this.Ciudad.HeaderText = "Ciudad";
			this.Ciudad.Name = "Ciudad";
			this.Ciudad.ReadOnly = true;
			// 
			// Comuna
			// 
			this.Comuna.HeaderText = "Comuna";
			this.Comuna.Name = "Comuna";
			this.Comuna.ReadOnly = true;
			// 
			// _Region
			// 
			this._Region.HeaderText = "Region";
			this._Region.Name = "_Region";
			this._Region.ReadOnly = true;
			// 
			// MantSucursales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_sucursales);
			this.Controls.Add(this.groupBox_sucursal);
			this.Name = "MantSucursales";
			this.Text = "Mantenedor de Sucursales";
			this.groupBox_sucursal.ResumeLayout(false);
			this.groupBox_sucursal.PerformLayout();
			this.groupBox_sucursales.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grilla_sucursales)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Region;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comuna;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridView grilla_sucursales;
		private System.Windows.Forms.GroupBox groupBox_sucursales;
		private System.Windows.Forms.Label label_idSucursal;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.TextBox textBox_idSucursal;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_descripcion;
		private System.Windows.Forms.Label label_2puntos3;
		private System.Windows.Forms.TextBox textBox_descripcion;
		private System.Windows.Forms.Label label_direccion;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.TextBox textBox_direccion;
		private System.Windows.Forms.Label label_ciudad;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.TextBox textBox_ciudad;
		private System.Windows.Forms.Label label_comuna;
		private System.Windows.Forms.Label label_2puntos6;
		private System.Windows.Forms.TextBox textBox_comuna;
		private System.Windows.Forms.Label label_region;
		private System.Windows.Forms.Label label_2puntos7;
		private System.Windows.Forms.TextBox textBox_region;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.GroupBox groupBox_sucursal;
	}
}
