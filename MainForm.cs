/*
 * Created by SharpDevelop.
 * User: ivan
 * Date: 8/9/2018
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABMStock
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public ConexionBBDD conectorBBDD;
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
		

		void Button1Click(object sender, EventArgs e)
		{
				conectorBBDD = new ConexionBBDD();
			if(label1.Text.Equals("Conectado")){
				conectorBBDD.CloseConnection();
				label1.Text = "Desconectado";
			} else {
				conectorBBDD.OpenConnection();
				label1.Text = "Conectado";
			}
		}
	}

}