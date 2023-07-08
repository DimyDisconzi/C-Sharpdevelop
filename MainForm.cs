/*
 * Created by SharpDevelop.
 * User: EliteBook
 * Date: 17/11/2019
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace openbrowsernavigate
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
		void MainFormLoad(object sender, EventArgs e)
		{
			
			//System.Diagnostics.Process.Start("www.ufsc.br");
			System.Diagnostics.Process.Start("http://www.blablabla.epizy.com/");
			/*WebBrowser.Navigate("http://www.telemetryhost.epizy.com/login/login.php");
			 */
	
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
	
		}
		void EToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void CadastrarUsuárioToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (frmNewClient frmNC1 = new frmNewClient()) {
				frmNC1.ShowDialog();
			}
		}
	}
}
