/*
 * Created by SharpDevelop.
 * User: ivan
 * Date: 8/9/2018
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ABMStock
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		/// 
		
		public System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.TabControl tabButtonAltaMercaderia;
		public System.Windows.Forms.TabPage tabAlta;
		public System.Windows.Forms.TabPage tabBaja;
		public System.Windows.Forms.TabPage tabConsulta;
		
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
		public void InitializeComponent()
		{
			
			this.tabButtonAltaMercaderia = new System.Windows.Forms.TabControl();
			this.tabAlta = new System.Windows.Forms.TabPage();
			this.tabBaja = new System.Windows.Forms.TabPage();
			this.tabConsulta = new System.Windows.Forms.TabPage();
			this.tabButtonAltaMercaderia.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabButtonAltaMercaderia
			// 
			this.tabButtonAltaMercaderia.Controls.Add(this.tabAlta);
			this.tabButtonAltaMercaderia.Controls.Add(this.tabBaja);
			this.tabButtonAltaMercaderia.Controls.Add(this.tabConsulta);
			this.tabButtonAltaMercaderia.Location = new System.Drawing.Point(13, 13);
			this.tabButtonAltaMercaderia.Name = "tabButtonAltaMercaderia";
			this.tabButtonAltaMercaderia.SelectedIndex = 0;
			this.tabButtonAltaMercaderia.Size = new System.Drawing.Size(1079, 501);
			this.tabButtonAltaMercaderia.TabIndex = 0;
			// 
			// tabAlta
			// 
			this.tabAlta.Location = new System.Drawing.Point(4, 25);
			this.tabAlta.Name = "tabAlta";
			this.tabAlta.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlta.Size = new System.Drawing.Size(1071, 472);
			this.tabAlta.TabIndex = 0;
			this.tabAlta.Text = "Alta de Mercadería";
			this.tabAlta.UseVisualStyleBackColor = true;
			// 
			// tabBaja
			// 
			this.tabBaja.Location = new System.Drawing.Point(4, 25);
			this.tabBaja.Name = "tabBaja";
			this.tabBaja.Padding = new System.Windows.Forms.Padding(3);
			this.tabBaja.Size = new System.Drawing.Size(1071, 472);
			this.tabBaja.TabIndex = 0;
			this.tabBaja.Text = "Baja de Mercadería";
			this.tabBaja.UseVisualStyleBackColor = true;
			// 
			// tabConsulta
			// 
			this.tabConsulta.Location = new System.Drawing.Point(4, 25);
			this.tabConsulta.Name = "tabConsulta";
			this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
			this.tabConsulta.Size = new System.Drawing.Size(1071, 472);
			this.tabConsulta.TabIndex = 0;
			this.tabConsulta.Text = "Consulta";
			this.tabConsulta.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 526);
			this.Controls.Add(this.tabButtonAltaMercaderia);
			this.Name = "MainForm";
			this.Text = "ABMStock";
			this.tabButtonAltaMercaderia.ResumeLayout(false);
			this.ResumeLayout(false);
			

		}
	}
}
