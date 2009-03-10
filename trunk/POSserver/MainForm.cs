/* INNOVIC 2009 - POSserver */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POSserver
{
	/// Descripción MainForm : Programa que contiene todas las interfaces de POSserver.

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			MantParam ventana = new MantParam();
			ventana.MdiParent = this;
			ventana.WindowState = FormWindowState.Maximized;
			ventana.Show();
		}
		
		int cantOpenVentanas (string textForm){
			int h	= 0; // Contador cantidad de ventanas hijos.
			int i	= 0; // Contador cantidad de ventanas repetidas del mismo tipo.
			
			while(this.MdiChildren.Length > h){
				// Verifica si existe abierto una ventana de este tipo.
				if	(this.MdiChildren[h].Text == textForm){	
					i++;
				}
				h++;
			}
			return i;
		}
		
		int buscarIndiceVentanas (string textForm){
			int h	= 0; // Contador cantidad de ventanas hijos.
			int i	= 0; // Contador cantidad de ventanas repetidas del mismo tipo.
			
			while(this.MdiChildren.Length > h){
				// Verifica si existe abierto una ventana de este tipo.
				if	(this.MdiChildren[h].Text == textForm){	
					i = h;
					return i;
				}
				h++;
			}
			return i;
		}
		
		void opcSalirClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Desea salir de POSserver ?", "Salir", MessageBoxButtons.YesNo);
			
			switch(dr){
   				case	DialogResult.Yes: 
						this.Close(); break;
				case	DialogResult.No: 
						break;
			}
		}
		
		void opcParametrosClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantParam ventana = new MantParam();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de Parametros") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de Parametros")
					{
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantParam ventana = new MantParam();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de Parametros")].Activate();
				}
			}
		}
		
		void opcUsuariosClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantUsuarios ventana = new MantUsuarios();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de Usuarios") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de Usuarios"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantUsuarios ventana = new MantUsuarios();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de Usuarios")].Activate();
				}
			}
		}
		
		void opcSucursalesClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantSucursales ventana = new MantSucursales();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de Sucursales") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de Sucursales"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantSucursales ventana = new MantSucursales();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de Sucursales")].Activate();
				}
			}
		}
		
		void opcPosClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantPOSserver ventana = new MantPOSserver();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de POS") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de POS"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantPOSserver ventana = new MantPOSserver();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de POS")].Activate();
				}
			}
		}
		
		void opcConveniosClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantConvenios ventana = new MantConvenios();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor Convenios") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor Convenios"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantConvenios ventana = new MantConvenios();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor Convenios")].Activate();
				}
			}
		}
		
		void opcFormasPagoClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantFormaPago ventana = new MantFormaPago();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de Formas de Pago") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de Formas de Pago"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantFormaPago ventana = new MantFormaPago();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de Formas de Pago")].Activate();
				}
			}
		}
		
		void opcInventarioClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantInventario ventana = new MantInventario();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de Inventario") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de Inventario"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantInventario ventana = new MantInventario();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de Inventario")].Activate();
				}
			}
		}
		
		void opcListaPreciosClick(object sender, EventArgs e)
		{
			if( this.ActiveMdiChild == null){
				// Crear una nueva ventana hija
				MantListaPrecios ventana = new MantListaPrecios();
				ventana.MdiParent = this;
				// Para mostrarlo maximizado:
				ventana.WindowState = FormWindowState.Maximized;
				ventana.Show();
			}else{
				if(cantOpenVentanas("Mantenedor de lista de precios") == 0){
					if(this.ActiveMdiChild.Text != "Mantenedor de lista de precios"){
						this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);	
						MantListaPrecios ventana = new MantListaPrecios();
						ventana.MdiParent = this;
						// Para mostrarlo maximizado:
						ventana.WindowState = FormWindowState.Maximized;
						ventana.Show();
					}
				}else{
					this.MdiChildren[buscarIndiceVentanas("Mantenedor de lista de precios")].Activate();
				}
			}
		}		
	}
}
