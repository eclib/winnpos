/*
 * Created by SharpDevelop.
 * User: diaz60844
 * Date: 3/3/2009
 * Time: 5:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Rutinas;
using Negocio;
namespace POSinnovic
{
	/// <summary>
	/// Description of CierreVenta.
	/// </summary>
	public partial class CierreVenta : Form
	{
		public DataGridView dtgv;
		public negocio Neg;
		public Int32 Total;
		public Descuentos Desc;
		public POS Padre;
		public CierreVenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void CierreVentaLoad(object sender, EventArgs e)
		{
			negocio neg            = this.Neg;
			MySqlDataReader reader = neg.select("Select * from pos_formas_pago");
				
			dataGridView1.Columns[0].ReadOnly=true;
			dataGridView1.Columns[1].ReadOnly=false;
			while(reader.Read()){
				dataGridView1.Rows.Add();
				dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0].Value = reader["Descripcion"].ToString();
			}
			neg.cerrar();
			textBox1.Text = this.Total.ToString();
			CalcTotal()			;
		}
		
		void DataGridView1KeyDown(object sender, KeyEventArgs e)
		{
			
			switch(e.KeyCode){
					case Keys.Back:
						dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = "";
						CalcTotal();
						break;
					case Keys.Delete:
					case Keys.Down:
					case Keys.Up:
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
					case Keys.Subtract:
					case Keys.OemMinus:
					case Keys.Add:
					case Keys.Oemplus:
					case Keys.Escape:
					case Keys.Enter:
					case Keys.F2:
					case Keys.F3:
					case Keys.F4:
					case Keys.F5:
					case Keys.F6:
					case Keys.F7:
					case Keys.F8:
					default:
						try{
						
							string car = e.KeyCode.ToString();
							if ((car.Length==2 && car.Substring(0,1).Equals("D")) ){
								car = car.Substring(1,1);
							}else{
								if (car.IndexOf("NumPad") > -1){
									car=car.Substring(6,1);
								}
							}
							
							int keyint = (int)Convert.ToChar(car);
							if (keyint >= 48 && keyint <= 57){
								dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1];								
								SendKeys.Flush();
								SendKeys.Send(car);
							}
						
						}catch(System.FormatException err){
							err.ToString();
						}
						break;
			}
			
		}
		
		void CierreVentaKeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
				case Keys.Enter:
					CalcTotal();
					break;
				case Keys.F5:
					FormDescuento FRD = new FormDescuento();
					FRD.Descuento     = this.Desc;
					FRD.Cierre        = this;
					FRD.Tipo          = 2;
					FRD.Show();
					break;
				case Keys.F7:
					dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value = textBox6.Text;
					CalcTotal();
					break;
				case Keys.F3:
					impresion imp = new impresion();
					int id = GrabaBoletaTemporal();
					imp.gentxt(id);
					this.Close();
					break;
					
			}
		}
		
		private int GrabaBoletaTemporal(){
			Rutinas.Rutinas Rut = new Rutinas.Rutinas();
			Rut.user   = this.Neg.user;
			Rut.pass   = this.Neg.pass;
			Rut.port   = this.Neg.port;
			Rut.server = this.Neg.server;
			Rut.db     = this.Neg.db;
			int Salida      = 0;
			DateTime FecHoy = DateTime.Now;
			string USR_VEN  = this.Padre.idVendedor.ToString();
			string Fecha    = FecHoy.Year.ToString()+string.Format("{00}",FecHoy.Month.ToString())+string.Format("{00}",FecHoy.Day.ToString());
			string Hora     = string.Format("{00}",FecHoy.Hour.ToString())+string.Format("{00}",FecHoy.Minute.ToString());
			string Total       = textBox4.Text;
			// Encabezado de la Boleta //
			string sql = "insert into pos_venta ( usr_ven, fecha, hora, valor_total) values("+USR_VEN+","+Fecha+",'"+Hora+"','"+Total+"')";
			Rut.exSQL(sql);
			sql = "Select id from pos_venta where Borrador='*'";
			Salida = int.Parse(Rut.exSQL(sql).ToString());
			// Detalle de la Boleta //
			for (int i=0; i< this.dtgv.Rows.Count;i++){
				try{
					string Codigo = this.dtgv.Rows[i].Cells[1].Value.ToString();
					int cantidad  = int.Parse(this.dtgv.Rows[i].Cells[0].Value.ToString());
					int preuni    = int.Parse(this.dtgv.Rows[i].Cells[3].Value.ToString());
					int total     = int.Parse(this.dtgv.Rows[i].Cells[4].Value.ToString());
					int impdescto = int.Parse(this.Desc.GetDesctoLineaImp(Codigo).ToString());
					int pordescto = int.Parse(this.Desc.GetDesctoLineaPor(Codigo).ToString());
					int descto    = ((total - impdescto)  * ((100-pordescto)/100));
					sql = "insert into pos_venta_detalle ( id_venta, codigo, cantidad, precio_unitario, total, descuento, importe_descuento, porcentaje_descuento) values(";
					sql+= Salida.ToString()+",'"+Codigo+"',"+cantidad.ToString()+","+preuni.ToString()+","+total.ToString()+","+descto.ToString()+","+impdescto.ToString()+","+pordescto.ToString()+")";
					Rut.exSQL(sql);
				}catch(System.NullReferenceException e){
					e.ToString();
				}
			}
			
			return(Salida);
		}
		public void CalcTotal(){
			int largo        = dataGridView1.Rows.Count;
			Int32 TotalPagos = 0;
			Int32 Total      = 0;
			Int32 Resta      = 0;
			for(int t=0; t<largo; t++){
				try{
					TotalPagos += Int32.Parse(dataGridView1.Rows[t].Cells[1].Value.ToString());
				}catch(Exception e){
					e.ToString();
				}
			}
			textBox3.Text = (this.Desc.GetDesctoTotImp()*-1).ToString();
			textBox2.Text = "-"+(Single.Parse(textBox1.Text) * (this.Desc.GetDesctoTotPor()/100)).ToString();
			label2.Text= "Descuento   "+this.Desc.GetDesctoTotPor().ToString()+"%";
			Total        += Convert.ToInt32( Single.Parse(textBox1.Text)+Single.Parse(textBox2.Text)+Single.Parse(textBox3.Text));
			textBox4.Text = Total.ToString();
			textBox5.Text = TotalPagos.ToString();
			Resta         = (Total - TotalPagos);
			if (Resta < 0){
				textBox6.Text = "0";
				textBox7.Text = (Resta*-1).ToString();
			}else{
				textBox6.Text = (Resta).ToString();
				textBox7.Text = "0";
			}
			
		}
		
		void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			CalcTotal();
		}
	}
}
