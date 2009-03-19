/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 2/18/2009
 * Time: 10:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using Rutinas;
using Negocio;

namespace POSinnovic
{
	/// <summary>
	/// Description of POS.
	/// </summary>
	public partial class POS : Form
	{
		public Login madre;
		private System.Windows.Forms.TextBox textBusqueda  = new System.Windows.Forms.TextBox();
		private bool swglobal = true;
		private int color     = 0;
		public string db;
		public string user;
		public string pass;
		public string port;
		public string server;
		public int idVendedor;
		private string NombreVendedor = "";
		negocio negGlogal     = new negocio();
		
		Descuentos Descuentos = new Descuentos();

		
		public POS(string Server, string Port, string User, string Pass, string Db)
		{
			this.db      = Db;
			this.user    = User;
			this.pass    = Pass;
			this.port    = Port;
			this.server  = Server;
			
			this.negGlogal.db     = Db;
			this.negGlogal.user   = User;
			this.negGlogal.pass   = Pass;
			this.negGlogal.port   = Port;
			this.negGlogal.server = Server;
			
			this.textBusqueda.Text="0";
			this.textBusqueda.TextChanged  += new EventHandler(this.infoCodigo);
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		void Label1Click(object sender, EventArgs e)
		{
//			ManagementClass oMClass = new ManagementClass ("Win32_NetworkAdapterConfiguration");
			
			ManagementClass oMClass = new ManagementClass ("Win32_BIOS");
			
			ManagementObjectCollection colMObj = oMClass.GetInstances();
			label1.Text="";
			foreach(ManagementObject objMO in colMObj)
			{
				try{
					label1.Text += (objMO["SerialNumber"].ToString());
//					label1.Text += (objMO["MacAddress"].ToString())+"<<<>>>";
				}catch(NullReferenceException){
				}

			}
			
		}
		
		void POSActivated(object sender, EventArgs e)
		{
			Rutinas.Rutinas Rut = new Rutinas.Rutinas(this.server, this.port, this.user, this.pass, this.db);
			string sql = "Select Nombre from pos_usuario where id = "+this.idVendedor.ToString();
			this.NombreVendedor				= Rut.exSQL(sql);
			if(this.NombreVendedor.Trim() != ""){
				this.label_vendedor.Text		= this.NombreVendedor.ToString();							
			}else{
				this.label_vendedor.Text		= "";					
			}

			int cont;
			for(int i=0; i<100; i++){
				dataGridView1.Rows.Add();
				dataGridView1.Rows[dataGridView1.Rows.Count-1].HeaderCell.Value=1;
				dataGridView1.RowHeadersVisible = false;
				cont = dataGridView1.Rows.Count;
				if (this.color == 0){
					dataGridView1.Rows[cont-1].DefaultCellStyle.BackColor = Color.FromArgb(220,220,220 );
					this.color = 1;
				}else{
					dataGridView1.Rows[cont-1].DefaultCellStyle.BackColor = Color.White;
					this.color = 0;
				}
			}
				
		}
		
		void POSResize(object sender, EventArgs e)
		{
			double ancho = dataGridView1.Width;
			dataGridView1.Columns[0].Width = (int)(ancho * 0.05);
			dataGridView1.Columns[1].Width = (int)(ancho * 0.22);
			dataGridView1.Columns[2].Width = (int)(ancho * 0.53);
			dataGridView1.Columns[3].Width = (int)(ancho * 0.10);
			dataGridView1.Columns[4].Width = (int)(ancho * 0.10);
			int pos=0;
			dataGridView1.Size = new Size(this.Size.Width-30    , this.Size.Height-250);
			pos                = dataGridView1.Size.Height+dataGridView1.Location.Y-1;
			panel1.Location = new Point(dataGridView1.Location.X, pos+5);
			label12.Location   = new Point(this.Size.Width-362  , pos);
			label11.Location   = new Point(this.Size.Width-360  , pos+5);
			label10.Location   = new Point(this.Size.Width-280  , pos+5);
			label4.Location    = new Point(this.Size.Width-118  , label4.Location.Y);
			label6.Location    = new Point(this.Size.Width-118  , label6.Location.Y);

			this.WindowState= FormWindowState.Maximized;

		}
		
		void actualizalinea(int linea){
			Rutinas.Rutinas ruti = new Rutinas.Rutinas(this.server, this.port, this.user, this.pass, this.db);;
			if (this.swglobal && dataGridView1.Rows[linea].Cells[1].Value != null){
				if (!dataGridView1.Rows[linea].Cells[1].Value.ToString().Equals("") ){
					string Codigo = dataGridView1.Rows[linea].Cells[1].Value.ToString().Trim();
					if (int.Parse(ruti.exSQL("SELECT count(*) FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'")) > 0){
						int xcant;
						try{
							xcant  = int.Parse(dataGridView1.Rows[linea].Cells[0].Value.ToString());
						}catch{
							xcant = 1;
						}
						dataGridView1.Rows[linea].Cells[0].Value = xcant.ToString();
						dataGridView1.Rows[linea].Cells[1].Value = ruti.exSQL("SELECT Codigo FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						dataGridView1.Rows[linea].Cells[2].Value = ruti.exSQL("SELECT Descripcion FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						dataGridView1.Rows[linea].Cells[3].Value = ruti.exSQL("SELECT Neto FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						calclinea(linea);
					}else{
						dataGridView1.Rows[linea].Cells[0].Value = "";
						dataGridView1.Rows[linea].Cells[1].Value = "";
						dataGridView1.Rows[linea].Cells[2].Value = "";
						dataGridView1.Rows[linea].Cells[3].Value = "";
						dataGridView1.Rows[linea].Cells[4].Value = "";
					}
				}
			}
		}
		
		void DataGridView1KeyDown(object sender, KeyEventArgs e)
		{
			string result;
			switch(e.KeyCode){
					case Keys.Delete:
						result = MessageBox.Show("¿Esta Seguro de eliminar el producto?", "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).ToString();
						if (result.Equals("Yes")){
							int pos1 =  dataGridView1.CurrentRow.Index;
							dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
							calctotal();
							dataGridView1.Rows.Add();
							if (dataGridView1.Rows[pos1].DefaultCellStyle.BackColor == Color.White){
								this.color = 0;
							}else{
								this.color = 1;
							}
							for (int i = pos1; i <dataGridView1.Rows.Count-1; i++){
								if (this.color == 0){
									dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(220,220,220 );
									this.color = 1;
								}else{
									dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
									this.color = 0;
								}
							}
						}
						break;
					case Keys.Down:
					case Keys.Up:
						actualizalinea(dataGridView1.CurrentRow.Index);
						break;
					case Keys.Left:
					case Keys.Right:
					case Keys.Clear:
					case Keys.Alt:
					case Keys.Control:
					case Keys.Shift:
					case Keys.PageDown:
					case Keys.PageUp:
					case Keys.End:
					case Keys.Home:
						break;
					case Keys.Subtract:
					case Keys.OemMinus:
						this.menosuno();
						break;
					case Keys.Add:
					case Keys.Oemplus:
						this.masuno();
						break;
					case Keys.Escape:
						result = MessageBox.Show("¿Esta Seguro de cancelar la venta?", "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).ToString();
						if (result.Equals("Yes")){
							this.Cancela();
							calctotal();
						}
						break;
					case Keys.Enter:
						dataGridView1.Columns[1].ReadOnly = true;
						break;
					case Keys.F2:
						string xdat  = "";
						try{
							xdat  = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
						}catch{}
						string Likee = "";
						if (!xdat.Trim().Equals("")){
							Likee = " where CODIGO like'%"+xdat+"%' or DESCRIPCION like'%"+xdat+"%'";	
						}
						string sql = "SELECT ID, CODIGO, DESCRIPCION, NETO FROM pos_lista_precio "+Likee+" ORDER BY `ID`";
						AyuGen AYG  = new AyuGen(sql);
						AYG.db      = this.db;
						AYG.user    = this.user;
						AYG.pass    = this.pass;
						AYG.server  = this.server;
						AYG.port    = this.port;
						AYG.AddOrigen("ID");
						AYG.AddDestino(this.textBusqueda);
						AYG.Text="Ayuda de Codigos";
						AYG.Show();
						break;
					case Keys.F3:
						CierreVenta cv = new CierreVenta();
						cv.Neg		= this.negGlogal;
						cv.dtgv		= this.dataGridView1;
						cv.Total	= Int32.Parse(label10.Text.Replace("$",""));
						cv.Desc		= this.Descuentos;
						cv.Padre	= this;
						cv.Show();
						break;
					case Keys.F4:
						break;
					case Keys.F5:
						FormDescuento Desct	= new FormDescuento();
						Desct.Padre         = this;
						Desct.Grilla	    = this.dataGridView1;
						Desct.Descuento     = this.Descuentos;
						Desct.Show();
						break;
					case Keys.F6:
						break;
					case Keys.F7:
						break;
					case Keys.F8:
						break;
					default:
						try{
							//MessageBox.Show(e.KeyCode.ToString());
							string car = e.KeyCode.ToString();
							if ((car.Length==2 && car.Substring(0,1).Equals("D")) ){
								car = car.Substring(1,1);
							}else{
								if (car.IndexOf("NumPad") > -1){
									car=car.Substring(6,1);
								}
							}
							
							int keyint = (int)Convert.ToChar(car);
							if (keyint >= 48 && keyint <= 122){
								dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Selected = true;
								dataGridView1.Columns[1].ReadOnly = false;
								SendKeys.Flush();
								SendKeys.Send(car);
							}
						}catch(System.FormatException err){
							err.ToString();
						}
						break;
			}
		}

		void infoCodigo(object sender, EventArgs e)
		{
			
			Rutinas.Rutinas ruti = new Rutinas.Rutinas(this.server, this.port, this.user, this.pass, this.db);
			if (!this.textBusqueda.Text.ToString().Trim().Equals("")){
				int linea = dataGridView1.CurrentRow.Index;
				int xcant;
				try{
					xcant  = int.Parse(dataGridView1.Rows[linea].Cells[0].Value.ToString());
				}catch{
					xcant = 1;
				}
				dataGridView1.Rows[linea].Cells[0].Value = xcant.ToString();
				dataGridView1.Rows[linea].Cells[1].Value = ruti.exSQL("SELECT Codigo FROM `innpos_pos`.`pos_lista_precio` where id="+this.textBusqueda.Text.ToString());
				dataGridView1.Rows[linea].Cells[2].Value = ruti.exSQL("SELECT Descripcion FROM `innpos_pos`.`pos_lista_precio` where id="+this.textBusqueda.Text.ToString());
				dataGridView1.Rows[linea].Cells[3].Value = ruti.exSQL("SELECT Neto FROM `innpos_pos`.`pos_lista_precio` where id="+this.textBusqueda.Text.ToString());
				calclinea(linea);
			}
		}

		public void Cancela(){
			dataGridView1.Rows.Clear();
			this.color = 0;
			for(int i=0; i<100; i++){
				dataGridView1.Rows.Add();
				dataGridView1.Rows[dataGridView1.Rows.Count-1].HeaderCell.Value=1;
				dataGridView1.RowHeadersVisible = false;
				if (this.color == 0){
					dataGridView1.Rows[dataGridView1.Rows.Count-1].DefaultCellStyle.BackColor = Color.FromArgb(220,220,220 );
					this.color = 1;
				}else{
					dataGridView1.Rows[dataGridView1.Rows.Count-1].DefaultCellStyle.BackColor = Color.White;
					this.color = 0;
				}
			}
		}
		void masuno(){
			int Y = dataGridView1.CurrentRow.Index;
			try{
				int x = int.Parse(dataGridView1.Rows[Y].Cells[0].Value.ToString());
				x++;
				dataGridView1.Rows[Y].Cells[0].Value = x;
			}catch(System.NullReferenceException){
				dataGridView1.Rows[Y].Cells[0].Value = 1;							
			}
			calclinea(Y);
		}
		
		public void calclinea(int Y){
			try{
				dataGridView1.Rows[Y].Cells[4].Value = double.Parse(dataGridView1.Rows[Y].Cells[0].Value.ToString()) * double.Parse(dataGridView1.Rows[Y].Cells[3].Value.ToString());
				Single Valor      = Single.Parse(dataGridView1.Rows[Y].Cells[4].Value.ToString());
				Valor -= Single.Parse(this.Descuentos.GetDesctoLineaImp(dataGridView1.Rows[Y].Cells[1].Value.ToString()).ToString());
				string Porcentaje = this.Descuentos.GetDesctoLineaPor(dataGridView1.Rows[Y].Cells[1].Value.ToString()).ToString();
				Single uno        = (1-(Single.Parse(Porcentaje)/100));
				Valor             =  Valor * uno;
				dataGridView1.Rows[Y].Cells[4].Value = Valor.ToString();
				int x = dataGridView1.Rows.Count;
				calctotal();
			}catch{}
		}

		public void calctotal(){
			int total = 0;
			try{
				for(int i=0; i< dataGridView1.Rows.Count; i++){
					total += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
				}
			}catch{}
			label10.Text = "$"+total.ToString();
		}
		
		void menosuno(){
			int Y = dataGridView1.CurrentRow.Index;
			try{
				int x = int.Parse(dataGridView1.Rows[Y].Cells[0].Value.ToString());
				x--;
				if (x < 0){
					x=0;
				}
				dataGridView1.Rows[Y].Cells[0].Value = x;
			}catch(System.NullReferenceException){
				dataGridView1.Rows[Y].Cells[0].Value = 0;							
			}
			calclinea(Y);
		}
		
		void DataGridView1CellLeave(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.Columns[1].ReadOnly = true;
			int linea = dataGridView1.CurrentRow.Index;
			Rutinas.Rutinas ruti = new Rutinas.Rutinas(this.server, this.port, this.user, this.pass, this.db);;
			if (this.swglobal && dataGridView1.Rows[linea].Cells[1].Value != null){
				if (!dataGridView1.Rows[linea].Cells[1].Value.ToString().Equals("") ){
					string Codigo = dataGridView1.Rows[linea].Cells[1].Value.ToString().Trim();
					if (int.Parse(ruti.exSQL("SELECT count(*) FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'")) > 0){
						int xcant;
						try{
							xcant  = int.Parse(dataGridView1.Rows[linea].Cells[0].Value.ToString());
						}catch{
							xcant = 1;
						}
						dataGridView1.Rows[linea].Cells[0].Value = xcant.ToString();
						dataGridView1.Rows[linea].Cells[1].Value = ruti.exSQL("SELECT Codigo FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						dataGridView1.Rows[linea].Cells[2].Value = ruti.exSQL("SELECT Descripcion FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						dataGridView1.Rows[linea].Cells[3].Value = ruti.exSQL("SELECT Neto FROM `innpos_pos`.`pos_lista_precio` where Codigo='"+Codigo+"'");
						calclinea(linea);
					}else{
						dataGridView1.Rows[linea].Cells[0].Value = "";
						dataGridView1.Rows[linea].Cells[1].Value = "";
						dataGridView1.Rows[linea].Cells[2].Value = "";
						dataGridView1.Rows[linea].Cells[3].Value = "";
						dataGridView1.Rows[linea].Cells[4].Value = "";
					}
				}
			}
		}
		
		void POSKeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.F2:
					if (dataGridView1.Columns[1].ReadOnly == false){
						this.swglobal = false;
						SendKeys.Send("{ENTER}{UP}");
						Application.DoEvents();
						this.swglobal = true;
						string xdat   = "";
						try{
							xdat  = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
						}catch{}
						string Likee = "";
						if (!xdat.Trim().Equals("")){
							Likee = " where CODIGO like'%"+xdat+"%' or DESCRIPCION like'%"+xdat+"%'";	
						}
						string sql = "SELECT ID, CODIGO, DESCRIPCION, NETO FROM pos_lista_precio "+Likee+" ORDER BY `ID`";
						AyuGen AYG  = new AyuGen(sql);
						AYG.db      = this.db;
						AYG.user    = this.user;
						AYG.pass    = this.pass;
						AYG.server  = this.server;
						AYG.port    = this.port;
							
						AYG.AddOrigen("ID");
						AYG.AddDestino(this.textBusqueda);
						AYG.Text="Ayuda de Codigos";
						AYG.Show();
					}
					break;
				case Keys.F4:
					string result = MessageBox.Show("¿Esta seguro de salir de la aplicación?", "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation).ToString();
					if (result.Equals("Yes")){
						this.madre.Close();
					}
					break;
				case Keys.Down:
				case Keys.Up:
					break;
			}

		}
		
		void POSFormClosed(object sender, FormClosedEventArgs e)
		{
			this.madre.Close();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			this.label1.Text	= DateTime.Now.ToShortDateString();
			this.label2.Text	= DateTime.Now.ToShortTimeString();
		}
	}
}
