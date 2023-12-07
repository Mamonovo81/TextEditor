/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07.12.2023
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WinTextEditor
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
		void ButtonCloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ButtonOpenClick(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filename = openFileDialog.FileName;
				//MessageBox.Show(filename);
				string txt = File.ReadAllText(filename);
				textOutput.Text = txt;
			}
		}
	}

}