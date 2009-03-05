/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/02/2009
 * Hora: 04:45 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POS
{
	partial class MantPOS
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
			this.grilla_poss = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.groupBox_poss = new System.Windows.Forms.GroupBox();
			this.groupBox_pos = new System.Windows.Forms.GroupBox();
			this.textBox_codigo = new System.Windows.Forms.TextBox();
			this.label_2puntos3 = new System.Windows.Forms.Label();
			this.label_codigo = new System.Windows.Forms.Label();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_idPos = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idPos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grilla_poss)).BeginInit();
			this.groupBox_poss.SuspendLayout();
			this.groupBox_pos.SuspendLayout();
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
			// grilla_poss
			// 
			this.grilla_poss.AllowUserToAddRows = false;
			this.grilla_poss.AllowUserToOrderColumns = true;
			this.grilla_poss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_poss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_poss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Sucursal,
									this.Codigo});
			this.grilla_poss.Location = new System.Drawing.Point(6, 19);
			this.grilla_poss.MultiSelect = false;
			this.grilla_poss.Name = "grilla_poss";
			this.grilla_poss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_poss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_poss.Size = new System.Drawing.Size(759, 154);
			this.grilla_poss.TabIndex = 3;
			this.grilla_poss.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// Sucursal
			// 
			this.Sucursal.HeaderText = "Sucursal";
			this.Sucursal.Name = "Sucursal";
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
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
			// groupBox_poss
			// 
			this.groupBox_poss.Controls.Add(this.grilla_poss);
			this.groupBox_poss.Location = new System.Drawing.Point(12, 239);
			this.groupBox_poss.Name = "groupBox_poss";
			this.groupBox_poss.Size = new System.Drawing.Size(771, 189);
			this.groupBox_poss.TabIndex = 3;
			this.groupBox_poss.TabStop = false;
			this.groupBox_poss.Text = "POSs";
			// 
			// groupBox_pos
			// 
			this.groupBox_pos.Controls.Add(this.button_salir);
			this.groupBox_pos.Controls.Add(this.button_eliminar);
			this.groupBox_pos.Controls.Add(this.button_grabar);
			this.groupBox_pos.Controls.Add(this.button_nuevo);
			this.groupBox_pos.Controls.Add(this.textBox_codigo);
			this.groupBox_pos.Controls.Add(this.label_2puntos3);
			this.groupBox_pos.Controls.Add(this.label_codigo);
			this.groupBox_pos.Controls.Add(this.textBox_sucursal);
			this.groupBox_pos.Controls.Add(this.label_2puntos2);
			this.groupBox_pos.Controls.Add(this.label_sucursal);
			this.groupBox_pos.Controls.Add(this.textBox_idPos);
			this.groupBox_pos.Controls.Add(this.label_2puntos1);
			this.groupBox_pos.Controls.Add(this.label_idPos);
			this.groupBox_pos.Location = new System.Drawing.Point(12, 12);
			this.groupBox_pos.Name = "groupBox_pos";
			this.groupBox_pos.Size = new System.Drawing.Size(771, 220);
			this.groupBox_pos.TabIndex = 2;
			this.groupBox_pos.TabStop = false;
			this.groupBox_pos.Text = "Datos POS";
			// 
			// textBox_codigo
			// 
			this.textBox_codigo.Location = new System.Drawing.Point(118, 83);
			this.textBox_codigo.Name = "textBox_codigo";
			this.textBox_codigo.Size = new System.Drawing.Size(146, 20);
			this.textBox_codigo.TabIndex = 8;
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
			// textBox_idPos
			// 
			this.textBox_idPos.Location = new System.Drawing.Point(118, 31);
			this.textBox_idPos.Name = "textBox_idPos";
			this.textBox_idPos.Size = new System.Drawing.Size(146, 20);
			this.textBox_idPos.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idPos
			// 
			this.label_idPos.Location = new System.Drawing.Point(6, 31);
			this.label_idPos.Name = "label_idPos";
			this.label_idPos.Size = new System.Drawing.Size(89, 20);
			this.label_idPos.TabIndex = 0;
			this.label_idPos.Text = "ID POS";
			// 
			// MantPOS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_poss);
			this.Controls.Add(this.groupBox_pos);
			this.Name = "MantPOS";
			this.Text = "Mantenedor de POSs";
			((System.ComponentModel.ISupportInitialize)(this.grilla_poss)).EndInit();
			this.groupBox_poss.ResumeLayout(false);
			this.groupBox_pos.ResumeLayout(false);
			this.groupBox_pos.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.Label label_idPos;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.TextBox textBox_idPos;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_codigo;
		private System.Windows.Forms.Label label_2puntos3;
		private System.Windows.Forms.TextBox textBox_codigo;
		private System.Windows.Forms.GroupBox groupBox_pos;
		private System.Windows.Forms.GroupBox groupBox_poss;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.DataGridView grilla_poss;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
	}
}
