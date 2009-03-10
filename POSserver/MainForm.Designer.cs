/* INNOVIC 2009 - POSserver */

namespace POSserver
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disPOSservering">true if managed resources should be Disposed; otherwise, false.</param>
		protected override void Dispose(bool disPOSservering)
		{
			if (disPOSservering) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disPOSservering);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mantenedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.puntosDeVentasPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conveniosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.formasDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mantenedoresToolStripMenuItem,
									this.mantenedoresToolStripMenuItem1,
									this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(792, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mantenedoresToolStripMenuItem
			// 
			this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
			this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.mantenedoresToolStripMenuItem.Text = "Parametros";
			this.mantenedoresToolStripMenuItem.Click += new System.EventHandler(this.opcParametrosClick);
			// 
			// mantenedoresToolStripMenuItem1
			// 
			this.mantenedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.usuariosToolStripMenuItem,
									this.sucursalesToolStripMenuItem,
									this.puntosDeVentasPOSToolStripMenuItem,
									this.conveniosToolStripMenuItem,
									this.formasDePagoToolStripMenuItem,
									this.inventarioToolStripMenuItem,
									this.listaDePreciosToolStripMenuItem});
			this.mantenedoresToolStripMenuItem1.Name = "mantenedoresToolStripMenuItem1";
			this.mantenedoresToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
			this.mantenedoresToolStripMenuItem1.Text = "Mantenedores";
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.opcUsuariosClick);
			// 
			// sucursalesToolStripMenuItem
			// 
			this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
			this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.sucursalesToolStripMenuItem.Text = "Sucursales";
			this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.opcSucursalesClick);
			// 
			// puntosDeVentasPOSToolStripMenuItem
			// 
			this.puntosDeVentasPOSToolStripMenuItem.Name = "puntosDeVentasPOSToolStripMenuItem";
			this.puntosDeVentasPOSToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.puntosDeVentasPOSToolStripMenuItem.Text = "Puntos de Ventas (POS)";
			this.puntosDeVentasPOSToolStripMenuItem.Click += new System.EventHandler(this.opcPosClick);
			// 
			// conveniosToolStripMenuItem
			// 
			this.conveniosToolStripMenuItem.Name = "conveniosToolStripMenuItem";
			this.conveniosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.conveniosToolStripMenuItem.Text = "Convenios";
			this.conveniosToolStripMenuItem.Click += new System.EventHandler(this.opcConveniosClick);
			// 
			// formasDePagoToolStripMenuItem
			// 
			this.formasDePagoToolStripMenuItem.Name = "formasDePagoToolStripMenuItem";
			this.formasDePagoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.formasDePagoToolStripMenuItem.Text = "Formas de Pago";
			this.formasDePagoToolStripMenuItem.Click += new System.EventHandler(this.opcFormasPagoClick);
			// 
			// inventarioToolStripMenuItem
			// 
			this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
			this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.inventarioToolStripMenuItem.Text = "Inventario";
			this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.opcInventarioClick);
			// 
			// listaDePreciosToolStripMenuItem
			// 
			this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
			this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
			this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.opcListaPreciosClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.opcSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 467);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "POSserver";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem formasDePagoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conveniosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem puntosDeVentasPOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
