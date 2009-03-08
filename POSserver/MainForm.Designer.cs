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
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "POSserver";
			this.Name = "MainForm";
		}
	}
}
