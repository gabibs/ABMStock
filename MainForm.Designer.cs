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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tabButtonAltaMercaderia.SuspendLayout();
			this.tabAlta.SuspendLayout();
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
			this.tabAlta.Controls.Add(this.button2);
			this.tabAlta.Controls.Add(this.button1);
			this.tabAlta.Controls.Add(this.textBox5);
			this.tabAlta.Controls.Add(this.textBox4);
			this.tabAlta.Controls.Add(this.textBox3);
			this.tabAlta.Controls.Add(this.textBox2);
			this.tabAlta.Controls.Add(this.textBox1);
			this.tabAlta.Controls.Add(this.label5);
			this.tabAlta.Controls.Add(this.label4);
			this.tabAlta.Controls.Add(this.label3);
			this.tabAlta.Controls.Add(this.label2);
			this.tabAlta.Controls.Add(this.label1);
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
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(113, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(113, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(113, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 22);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(113, 94);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 22);
			this.textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(113, 124);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 22);
			this.textBox5.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(102, 384);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(203, 384);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
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
			this.tabAlta.ResumeLayout(false);
			this.tabAlta.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
