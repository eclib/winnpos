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


namespace POS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
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
		
		void MainFormActivated(object sender, EventArgs e)
		{
//			groupBox1.Location = new Point(groupBox1.Location.X , this.Size.Height-54);
			for(int i=0; i<100; i++){
				dataGridView1.Rows.Add();
				dataGridView1.Rows[dataGridView1.Rows.Count-1].HeaderCell.Value=1;
				dataGridView1.RowHeadersVisible = false;
			}
				
		}
		
		void MainFormResize(object sender, EventArgs e)
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
		
		void DataGridView1KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode){
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
						break;
					case Keys.F2:
						break;
					case Keys.F3:
						break;
					case Keys.F4:
						break;
					case Keys.F5:
						break;
					case Keys.F6:
						break;
					case Keys.F7:
						break;
					case Keys.F8:
						break;
					default:
						try{
//							MessageBox.Show(e.KeyCode.ToString());
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
								SendKeys.Flush();
								SendKeys.Send(car);
							}
						}catch(System.FormatException err){
							err.ToString();
						}
						break;
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
		}
	}
}
