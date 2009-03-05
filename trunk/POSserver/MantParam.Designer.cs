/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 04/03/2009
 * Hora: 08:25 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace POS
{
	partial class MantParam
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
			this.button_grabar = new System.Windows.Forms.Button();
			this.button_nuevo = new System.Windows.Forms.Button();
			this.label_2puntos5 = new System.Windows.Forms.Label();
			this.textBox_diasHistoricos = new System.Windows.Forms.TextBox();
			this.button_eliminar = new System.Windows.Forms.Button();
			this.button_salir = new System.Windows.Forms.Button();
			this.label_diasHitoricos = new System.Windows.Forms.Label();
			this.groupBox_parametro = new System.Windows.Forms.GroupBox();
			this.textBox_serverDios = new System.Windows.Forms.TextBox();
			this.label_2puntos11 = new System.Windows.Forms.Label();
			this.label_serverDios = new System.Windows.Forms.Label();
			this.textBox_portCentral = new System.Windows.Forms.TextBox();
			this.label_2puntos10 = new System.Windows.Forms.Label();
			this.label_portCentral = new System.Windows.Forms.Label();
			this.textBox_serverCentral = new System.Windows.Forms.TextBox();
			this.label_2puntos9 = new System.Windows.Forms.Label();
			this.label_serverCentral = new System.Windows.Forms.Label();
			this.textBox_portBd = new System.Windows.Forms.TextBox();
			this.label_2puntos8 = new System.Windows.Forms.Label();
			this.label_portBd = new System.Windows.Forms.Label();
			this.textBox_serverBd = new System.Windows.Forms.TextBox();
			this.label_2puntos7 = new System.Windows.Forms.Label();
			this.label_serverBd = new System.Windows.Forms.Label();
			this.textBox_superCta = new System.Windows.Forms.TextBox();
			this.label_2puntos6 = new System.Windows.Forms.Label();
			this.label_superCta = new System.Windows.Forms.Label();
			this.textBox_datosFactura = new System.Windows.Forms.TextBox();
			this.label_2puntos4 = new System.Windows.Forms.Label();
			this.label_datosFactura = new System.Windows.Forms.Label();
			this.textBox_datosBoleta = new System.Windows.Forms.TextBox();
			this.label_2puntos3 = new System.Windows.Forms.Label();
			this.label_datosBoleta = new System.Windows.Forms.Label();
			this.textBox_iva = new System.Windows.Forms.TextBox();
			this.label_2puntos2 = new System.Windows.Forms.Label();
			this.label_iva = new System.Windows.Forms.Label();
			this.textBox_idParametro = new System.Windows.Forms.TextBox();
			this.label_2puntos1 = new System.Windows.Forms.Label();
			this.label_idParametro = new System.Windows.Forms.Label();
			this.groupBox_parametro.SuspendLayout();
			this.SuspendLayout();
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
			// label_2puntos5
			// 
			this.label_2puntos5.Location = new System.Drawing.Point(101, 135);
			this.label_2puntos5.Name = "label_2puntos5";
			this.label_2puntos5.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos5.TabIndex = 13;
			this.label_2puntos5.Text = ":";
			// 
			// textBox_diasHistoricos
			// 
			this.textBox_diasHistoricos.Location = new System.Drawing.Point(118, 135);
			this.textBox_diasHistoricos.Name = "textBox_diasHistoricos";
			this.textBox_diasHistoricos.Size = new System.Drawing.Size(146, 20);
			this.textBox_diasHistoricos.TabIndex = 14;
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
			// label_diasHitoricos
			// 
			this.label_diasHitoricos.Location = new System.Drawing.Point(6, 135);
			this.label_diasHitoricos.Name = "label_diasHitoricos";
			this.label_diasHitoricos.Size = new System.Drawing.Size(89, 20);
			this.label_diasHitoricos.TabIndex = 12;
			this.label_diasHitoricos.Text = "Días Históricos";
			// 
			// groupBox_parametro
			// 
			this.groupBox_parametro.Controls.Add(this.textBox_serverDios);
			this.groupBox_parametro.Controls.Add(this.label_2puntos11);
			this.groupBox_parametro.Controls.Add(this.label_serverDios);
			this.groupBox_parametro.Controls.Add(this.textBox_portCentral);
			this.groupBox_parametro.Controls.Add(this.label_2puntos10);
			this.groupBox_parametro.Controls.Add(this.label_portCentral);
			this.groupBox_parametro.Controls.Add(this.textBox_serverCentral);
			this.groupBox_parametro.Controls.Add(this.label_2puntos9);
			this.groupBox_parametro.Controls.Add(this.label_serverCentral);
			this.groupBox_parametro.Controls.Add(this.textBox_portBd);
			this.groupBox_parametro.Controls.Add(this.label_2puntos8);
			this.groupBox_parametro.Controls.Add(this.label_portBd);
			this.groupBox_parametro.Controls.Add(this.textBox_serverBd);
			this.groupBox_parametro.Controls.Add(this.label_2puntos7);
			this.groupBox_parametro.Controls.Add(this.label_serverBd);
			this.groupBox_parametro.Controls.Add(this.textBox_superCta);
			this.groupBox_parametro.Controls.Add(this.label_2puntos6);
			this.groupBox_parametro.Controls.Add(this.label_superCta);
			this.groupBox_parametro.Controls.Add(this.button_salir);
			this.groupBox_parametro.Controls.Add(this.button_eliminar);
			this.groupBox_parametro.Controls.Add(this.button_grabar);
			this.groupBox_parametro.Controls.Add(this.button_nuevo);
			this.groupBox_parametro.Controls.Add(this.textBox_diasHistoricos);
			this.groupBox_parametro.Controls.Add(this.label_2puntos5);
			this.groupBox_parametro.Controls.Add(this.label_diasHitoricos);
			this.groupBox_parametro.Controls.Add(this.textBox_datosFactura);
			this.groupBox_parametro.Controls.Add(this.label_2puntos4);
			this.groupBox_parametro.Controls.Add(this.label_datosFactura);
			this.groupBox_parametro.Controls.Add(this.textBox_datosBoleta);
			this.groupBox_parametro.Controls.Add(this.label_2puntos3);
			this.groupBox_parametro.Controls.Add(this.label_datosBoleta);
			this.groupBox_parametro.Controls.Add(this.textBox_iva);
			this.groupBox_parametro.Controls.Add(this.label_2puntos2);
			this.groupBox_parametro.Controls.Add(this.label_iva);
			this.groupBox_parametro.Controls.Add(this.textBox_idParametro);
			this.groupBox_parametro.Controls.Add(this.label_2puntos1);
			this.groupBox_parametro.Controls.Add(this.label_idParametro);
			this.groupBox_parametro.Location = new System.Drawing.Point(12, 12);
			this.groupBox_parametro.Name = "groupBox_parametro";
			this.groupBox_parametro.Size = new System.Drawing.Size(771, 416);
			this.groupBox_parametro.TabIndex = 4;
			this.groupBox_parametro.TabStop = false;
			this.groupBox_parametro.Text = "Datos Parametros";
			// 
			// textBox_serverDios
			// 
			this.textBox_serverDios.Location = new System.Drawing.Point(499, 136);
			this.textBox_serverDios.Name = "textBox_serverDios";
			this.textBox_serverDios.Size = new System.Drawing.Size(146, 20);
			this.textBox_serverDios.TabIndex = 43;
			// 
			// label_2puntos11
			// 
			this.label_2puntos11.Location = new System.Drawing.Point(483, 135);
			this.label_2puntos11.Name = "label_2puntos11";
			this.label_2puntos11.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos11.TabIndex = 42;
			this.label_2puntos11.Text = ":";
			// 
			// label_serverDios
			// 
			this.label_serverDios.Location = new System.Drawing.Point(339, 136);
			this.label_serverDios.Name = "label_serverDios";
			this.label_serverDios.Size = new System.Drawing.Size(89, 20);
			this.label_serverDios.TabIndex = 41;
			this.label_serverDios.Text = "Servidor Dios";
			// 
			// textBox_portCentral
			// 
			this.textBox_portCentral.Location = new System.Drawing.Point(499, 110);
			this.textBox_portCentral.Name = "textBox_portCentral";
			this.textBox_portCentral.Size = new System.Drawing.Size(146, 20);
			this.textBox_portCentral.TabIndex = 40;
			// 
			// label_2puntos10
			// 
			this.label_2puntos10.Location = new System.Drawing.Point(483, 109);
			this.label_2puntos10.Name = "label_2puntos10";
			this.label_2puntos10.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos10.TabIndex = 39;
			this.label_2puntos10.Text = ":";
			// 
			// label_portCentral
			// 
			this.label_portCentral.Location = new System.Drawing.Point(339, 110);
			this.label_portCentral.Name = "label_portCentral";
			this.label_portCentral.Size = new System.Drawing.Size(89, 20);
			this.label_portCentral.TabIndex = 38;
			this.label_portCentral.Text = "Puerto Central";
			// 
			// textBox_serverCentral
			// 
			this.textBox_serverCentral.Location = new System.Drawing.Point(499, 84);
			this.textBox_serverCentral.Name = "textBox_serverCentral";
			this.textBox_serverCentral.Size = new System.Drawing.Size(146, 20);
			this.textBox_serverCentral.TabIndex = 37;
			// 
			// label_2puntos9
			// 
			this.label_2puntos9.Location = new System.Drawing.Point(483, 84);
			this.label_2puntos9.Name = "label_2puntos9";
			this.label_2puntos9.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos9.TabIndex = 36;
			this.label_2puntos9.Text = ":";
			// 
			// label_serverCentral
			// 
			this.label_serverCentral.Location = new System.Drawing.Point(339, 84);
			this.label_serverCentral.Name = "label_serverCentral";
			this.label_serverCentral.Size = new System.Drawing.Size(89, 20);
			this.label_serverCentral.TabIndex = 35;
			this.label_serverCentral.Text = "Servidor Central";
			// 
			// textBox_portBd
			// 
			this.textBox_portBd.Location = new System.Drawing.Point(499, 57);
			this.textBox_portBd.Name = "textBox_portBd";
			this.textBox_portBd.Size = new System.Drawing.Size(146, 20);
			this.textBox_portBd.TabIndex = 34;
			// 
			// label_2puntos8
			// 
			this.label_2puntos8.Location = new System.Drawing.Point(483, 57);
			this.label_2puntos8.Name = "label_2puntos8";
			this.label_2puntos8.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos8.TabIndex = 33;
			this.label_2puntos8.Text = ":";
			// 
			// label_portBd
			// 
			this.label_portBd.Location = new System.Drawing.Point(339, 58);
			this.label_portBd.Name = "label_portBd";
			this.label_portBd.Size = new System.Drawing.Size(115, 20);
			this.label_portBd.TabIndex = 32;
			this.label_portBd.Text = "Puerto Base de Datos";
			// 
			// textBox_serverBd
			// 
			this.textBox_serverBd.Location = new System.Drawing.Point(499, 31);
			this.textBox_serverBd.Name = "textBox_serverBd";
			this.textBox_serverBd.Size = new System.Drawing.Size(146, 20);
			this.textBox_serverBd.TabIndex = 31;
			// 
			// label_2puntos7
			// 
			this.label_2puntos7.Location = new System.Drawing.Point(483, 31);
			this.label_2puntos7.Name = "label_2puntos7";
			this.label_2puntos7.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos7.TabIndex = 30;
			this.label_2puntos7.Text = ":";
			// 
			// label_serverBd
			// 
			this.label_serverBd.Location = new System.Drawing.Point(339, 32);
			this.label_serverBd.Name = "label_serverBd";
			this.label_serverBd.Size = new System.Drawing.Size(138, 20);
			this.label_serverBd.TabIndex = 29;
			this.label_serverBd.Text = "Servidor Base de Datos";
			// 
			// textBox_superCta
			// 
			this.textBox_superCta.Location = new System.Drawing.Point(118, 162);
			this.textBox_superCta.Name = "textBox_superCta";
			this.textBox_superCta.Size = new System.Drawing.Size(146, 20);
			this.textBox_superCta.TabIndex = 28;
			// 
			// label_2puntos6
			// 
			this.label_2puntos6.Location = new System.Drawing.Point(101, 162);
			this.label_2puntos6.Name = "label_2puntos6";
			this.label_2puntos6.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos6.TabIndex = 27;
			this.label_2puntos6.Text = ":";
			// 
			// label_superCta
			// 
			this.label_superCta.Location = new System.Drawing.Point(6, 162);
			this.label_superCta.Name = "label_superCta";
			this.label_superCta.Size = new System.Drawing.Size(89, 20);
			this.label_superCta.TabIndex = 26;
			this.label_superCta.Text = "Super Cuenta";
			// 
			// textBox_datosFactura
			// 
			this.textBox_datosFactura.Location = new System.Drawing.Point(118, 109);
			this.textBox_datosFactura.Name = "textBox_datosFactura";
			this.textBox_datosFactura.Size = new System.Drawing.Size(146, 20);
			this.textBox_datosFactura.TabIndex = 11;
			// 
			// label_2puntos4
			// 
			this.label_2puntos4.Location = new System.Drawing.Point(101, 109);
			this.label_2puntos4.Name = "label_2puntos4";
			this.label_2puntos4.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos4.TabIndex = 10;
			this.label_2puntos4.Text = ":";
			// 
			// label_datosFactura
			// 
			this.label_datosFactura.Location = new System.Drawing.Point(6, 109);
			this.label_datosFactura.Name = "label_datosFactura";
			this.label_datosFactura.Size = new System.Drawing.Size(89, 20);
			this.label_datosFactura.TabIndex = 9;
			this.label_datosFactura.Text = "Datos Factura";
			// 
			// textBox_datosBoleta
			// 
			this.textBox_datosBoleta.Location = new System.Drawing.Point(118, 83);
			this.textBox_datosBoleta.Name = "textBox_datosBoleta";
			this.textBox_datosBoleta.Size = new System.Drawing.Size(146, 20);
			this.textBox_datosBoleta.TabIndex = 8;
			// 
			// label_2puntos3
			// 
			this.label_2puntos3.Location = new System.Drawing.Point(101, 83);
			this.label_2puntos3.Name = "label_2puntos3";
			this.label_2puntos3.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos3.TabIndex = 7;
			this.label_2puntos3.Text = ":";
			// 
			// label_datosBoleta
			// 
			this.label_datosBoleta.Location = new System.Drawing.Point(6, 83);
			this.label_datosBoleta.Name = "label_datosBoleta";
			this.label_datosBoleta.Size = new System.Drawing.Size(89, 20);
			this.label_datosBoleta.TabIndex = 6;
			this.label_datosBoleta.Text = "Datos Boleta";
			// 
			// textBox_iva
			// 
			this.textBox_iva.Location = new System.Drawing.Point(118, 57);
			this.textBox_iva.Name = "textBox_iva";
			this.textBox_iva.Size = new System.Drawing.Size(146, 20);
			this.textBox_iva.TabIndex = 5;
			// 
			// label_2puntos2
			// 
			this.label_2puntos2.Location = new System.Drawing.Point(101, 57);
			this.label_2puntos2.Name = "label_2puntos2";
			this.label_2puntos2.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos2.TabIndex = 4;
			this.label_2puntos2.Text = ":";
			// 
			// label_iva
			// 
			this.label_iva.Location = new System.Drawing.Point(6, 57);
			this.label_iva.Name = "label_iva";
			this.label_iva.Size = new System.Drawing.Size(89, 20);
			this.label_iva.TabIndex = 3;
			this.label_iva.Text = "IVA";
			// 
			// textBox_idParametro
			// 
			this.textBox_idParametro.Location = new System.Drawing.Point(118, 31);
			this.textBox_idParametro.Name = "textBox_idParametro";
			this.textBox_idParametro.ReadOnly = true;
			this.textBox_idParametro.Size = new System.Drawing.Size(146, 20);
			this.textBox_idParametro.TabIndex = 2;
			// 
			// label_2puntos1
			// 
			this.label_2puntos1.Location = new System.Drawing.Point(101, 31);
			this.label_2puntos1.Name = "label_2puntos1";
			this.label_2puntos1.Size = new System.Drawing.Size(10, 20);
			this.label_2puntos1.TabIndex = 1;
			this.label_2puntos1.Text = ":";
			// 
			// label_idParametro
			// 
			this.label_idParametro.Location = new System.Drawing.Point(6, 31);
			this.label_idParametro.Name = "label_idParametro";
			this.label_idParametro.Size = new System.Drawing.Size(89, 20);
			this.label_idParametro.TabIndex = 0;
			this.label_idParametro.Text = "ID Parametro";
			// 
			// MantParam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 440);
			this.Controls.Add(this.groupBox_parametro);
			this.Name = "MantParam";
			this.Text = "Mantenedor de Parametros";
			this.groupBox_parametro.ResumeLayout(false);
			this.groupBox_parametro.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_superCta;
		private System.Windows.Forms.Label label_2puntos6;
		private System.Windows.Forms.TextBox textBox_superCta;
		private System.Windows.Forms.Label label_serverBd;
		private System.Windows.Forms.Label label_2puntos7;
		private System.Windows.Forms.TextBox textBox_serverBd;
		private System.Windows.Forms.Label label_portBd;
		private System.Windows.Forms.Label label_2puntos8;
		private System.Windows.Forms.TextBox textBox_portBd;
		private System.Windows.Forms.Label label_serverCentral;
		private System.Windows.Forms.Label label_2puntos9;
		private System.Windows.Forms.TextBox textBox_serverCentral;
		private System.Windows.Forms.Label label_portCentral;
		private System.Windows.Forms.Label label_2puntos10;
		private System.Windows.Forms.TextBox textBox_portCentral;
		private System.Windows.Forms.Label label_serverDios;
		private System.Windows.Forms.Label label_2puntos11;
		private System.Windows.Forms.TextBox textBox_serverDios;
		private System.Windows.Forms.Label label_idParametro;
		private System.Windows.Forms.TextBox textBox_idParametro;
		private System.Windows.Forms.Label label_iva;
		private System.Windows.Forms.TextBox textBox_iva;
		private System.Windows.Forms.Label label_datosBoleta;
		private System.Windows.Forms.TextBox textBox_datosBoleta;
		private System.Windows.Forms.Label label_datosFactura;
		private System.Windows.Forms.TextBox textBox_datosFactura;
		private System.Windows.Forms.GroupBox groupBox_parametro;
		private System.Windows.Forms.Label label_diasHitoricos;
		private System.Windows.Forms.TextBox textBox_diasHistoricos;
		private System.Windows.Forms.Label label_2puntos1;
		private System.Windows.Forms.Label label_2puntos2;
		private System.Windows.Forms.Label label_2puntos3;
		private System.Windows.Forms.Label label_2puntos4;
		private System.Windows.Forms.Button button_salir;
		private System.Windows.Forms.Button button_eliminar;
		private System.Windows.Forms.Label label_2puntos5;
		private System.Windows.Forms.Button button_nuevo;
		private System.Windows.Forms.Button button_grabar;
	}
}
