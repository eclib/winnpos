/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/02/2009
 * Hora: 04:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POS
{
	partial class MantUsuarios
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
			this.textBox_tipoAcceso = new System.Windows.Forms.TextBox();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.label_tipoAcceso = new System.Windows.Forms.Label();
			this.button_salir = new System.Windows.Forms.Button();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.grilla_usuarios = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Acceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.button_grabar = new System.Windows.Forms.Button();
			this.groupBox_usuarios = new System.Windows.Forms.GroupBox();
			this.groupBox_usuario = new System.Windows.Forms.GroupBox();
			this.textBox_password = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_password = new System.Windows.Forms.Label();
			this.textBox_sucursal = new System.Windows.Forms.TextBox();
			this.label_2puntos3 = new System.Windows.Forms.Label();
			this.label_sucursal = new System.Windows.Forms.Label();
			this.textBox_usuario = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_usuario = new System.Windows.Forms.Label();
			this.textBox_idUsuario = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).BeginInit();
			this.groupBox_usuarios.SuspendLayout();
			this.groupBox_usuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_tipoAcceso
			// 
			this.textBox_tipoAcceso.Location = new System.Drawing.Point(118, 135);
			this.textBox_tipoAcceso.Name = "textBox_tipoAcceso";
			this.textBox_tipoAcceso.Size = new System.Drawing.Size(146, 20);
			this.textBox_tipoAcceso.TabIndex = 14;
			// 
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// label_tipoAcceso
			// 
			this.label_tipoAcceso.Location = new System.Drawing.Point(6, 135);
			this.label_tipoAcceso.Name = "label_tipoAcceso";
			this.label_tipoAcceso.Size = new System.Drawing.Size(89, 20);
			this.label_tipoAcceso.TabIndex = 12;
			this.label_tipoAcceso.Text = "Tipo Acceso";
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
			// grilla_usuarios
			// 
			this.grilla_usuarios.AllowUserToAddRows = false;
			this.grilla_usuarios.AllowUserToOrderColumns = true;
			this.grilla_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grilla_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grilla_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Id,
									this.Usuario,
									this.Sucursal,
									this.Password,
									this.Tipo_Acceso});
			this.grilla_usuarios.Location = new System.Drawing.Point(6, 19);
			this.grilla_usuarios.MultiSelect = false;
			this.grilla_usuarios.Name = "grilla_usuarios";
			this.grilla_usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.grilla_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grilla_usuarios.Size = new System.Drawing.Size(759, 154);
			this.grilla_usuarios.TabIndex = 3;
			this.grilla_usuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Selecciona_Fila);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			// 
			// Usuario
			// 
			this.Usuario.HeaderText = "Usuario";
			this.Usuario.Name = "Usuario";
			// 
			// Sucursal
			// 
			this.Sucursal.HeaderText = "Sucursal";
			this.Sucursal.Name = "Sucursal";
			// 
			// Password
			// 
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			// 
			// Tipo_Acceso
			// 
			this.Tipo_Acceso.HeaderText = "Tipo Acceso";
			this.Tipo_Acceso.Name = "Tipo_Acceso";
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
			// groupBox_usuarios
			// 
			this.groupBox_usuarios.Controls.Add(this.grilla_usuarios);
			this.groupBox_usuarios.Location = new System.Drawing.Point(12, 239);
			this.groupBox_usuarios.Name = "groupBox_usuarios";
			this.groupBox_usuarios.Size = new System.Drawing.Size(771, 189);
			this.groupBox_usuarios.TabIndex = 3;
			this.groupBox_usuarios.TabStop = false;
			this.groupBox_usuarios.Text = "Usuarios";
			// 
			// groupBox_usuario
			// 
			this.groupBox_usuario.Controls.Add(this.button_salir);
			this.groupBox_usuario.Controls.Add(this.button_eliminar);
			this.groupBox_usuario.Controls.Add(this.button_grabar);
			this.groupBox_usuario.Controls.Add(this.button_nuevo);
			this.groupBox_usuario.Controls.Add(this.textBox_tipoAcceso);
			this.groupBox_usuario.Controls.Add(this.label_2puntos5);
			this.groupBox_usuario.Controls.Add(this.label_tipoAcceso);
			this.groupBox_usuario.Controls.Add(this.textBox_password);
			this.groupBox_usuario.Controls.Add(this.label_2puntos4);
			this.groupBox_usuario.Controls.Add(this.label_password);
			this.groupBox_usuario.Controls.Add(this.textBox_sucursal);
			this.groupBox_usuario.Controls.Add(this.label_2puntos3);
			this.groupBox_usuario.Controls.Add(this.label_sucursal);
			this.groupBox_usuario.Controls.Add(this.textBox_usuario);
			this.groupBox_usuario.Controls.Add(this.label_2puntos2);
			this.groupBox_usuario.Controls.Add(this.label_usuario);
			this.groupBox_usuario.Controls.Add(this.textBox_idUsuario);
			this.groupBox_usuario.Controls.Add(this.label_2puntos1);
			this.groupBox_usuario.Controls.Add(this.label_idUsuario);
			this.groupBox_usuario.Location = new System.Drawing.Point(12, 12);
			this.groupBox_usuario.Name = "groupBox_usuario";
			this.groupBox_usuario.Size = new System.Drawing.Size(771, 220);
			this.groupBox_usuario.TabIndex = 2;
			this.groupBox_usuario.TabStop = false;
			this.groupBox_usuario.Text = "Datos Usuario";
			// 
			// textBox_password
			// 
			this.textBox_password.Location = new System.Drawing.Point(118, 109);
			this.textBox_password.Name = "textBox_password";
			this.textBox_password.Size = new System.Drawing.Size(146, 20);
			this.textBox_password.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_password
			// 
			this.label_password.Location = new System.Drawing.Point(6, 109);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(89, 20);
			this.label_password.TabIndex = 9;
			this.label_password.Text = "Password";
			// 
			// textBox_sucursal
			// 
			this.textBox_sucursal.Location = new System.Drawing.Point(118, 83);
			this.textBox_sucursal.Name = "textBox_sucursal";
			this.textBox_sucursal.Size = new System.Drawing.Size(146, 20);
			this.textBox_sucursal.TabIndex = 8;
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
			// textBox_usuario
			// 
			this.textBox_usuario.Location = new System.Drawing.Point(118, 57);
			this.textBox_usuario.Name = "textBox_usuario";
			this.textBox_usuario.Size = new System.Drawing.Size(146, 20);
			this.textBox_usuario.TabIndex = 5;
			// 
			// label_2puntos2
			// 
			this.label_2puntos2.Location = new System.Drawing.Point(101, 57);
			this.label_2puntos2.Name = "label_2puntos2";
			this.label_2puntos2.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos2.TabIndex = 4;
			this.label_2puntos2.Text = ":";
			// 
			// label_usuario
			// 
			this.label_usuario.Location = new System.Drawing.Point(6, 57);
			this.label_usuario.Name = "label_usuario";
			this.label_usuario.Size = new System.Drawing.Size(89, 20);
			this.label_usuario.TabIndex = 3;
			this.label_usuario.Text = "Usuario";
			// 
			// textBox_idUsuario
			// 
			this.textBox_idUsuario.Location = new System.Drawing.Point(118, 31);
			this.textBox_idUsuario.Name = "textBox_idUsuario";
			this.textBox_idUsuario.Size = new System.Drawing.Size(146, 20);
			this.textBox_idUsuario.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idUsuario
			// 
			this.label_idUsuario.Location = new System.Drawing.Point(6, 31);
			this.label_idUsuario.Name = "label_idUsuario";
			this.label_idUsuario.Size = new System.Drawing.Size(89, 20);
			this.label_idUsuario.TabIndex = 0;
			this.label_idUsuario.Text = "ID Usuario";
			// 
			// MantUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_usuarios);
			this.Controls.Add(this.groupBox_usuario);
			this.Name = "MantUsuarios";
			this.Text = "Mantenedor de Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.grilla_usuarios)).EndInit();
			this.groupBox_usuarios.ResumeLayout(false);
			this.groupBox_usuario.ResumeLayout(false);
			this.groupBox_usuario.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Acceso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.GroupBox groupBox_usuarios;
		private System.Windows.Forms.DataGridView grilla_usuarios;
		private System.Windows.Forms.Label label_idUsuario;
		private System.Windows.Forms.TextBox textBox_idUsuario;
		private System.Windows.Forms.Label label_usuario;
		private System.Windows.Forms.TextBox textBox_usuario;
		private System.Windows.Forms.Label label_password;
		private System.Windows.Forms.TextBox textBox_password;
		private System.Windows.Forms.GroupBox groupBox_usuario;
		private System.Windows.Forms.Label label_tipoAcceso;
		private System.Windows.Forms.TextBox textBox_tipoAcceso;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.Label label_sucursal;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.TextBox textBox_sucursal;
		private System.Windows.Forms.Label label_2puntos3;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.Button button_grabar;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.Label label_2puntos5;
	}
}
