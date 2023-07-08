/*
 * Created by SharpDevelop.
 * User: EliteBook
 * Date: 17/11/2019
 * Time: 18:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace openbrowsernavigate
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem análisesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acessarEquipamentoIoTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaAoBancoDeDadosIoTToolStripMenuItem;
		
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
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.análisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acessarEquipamentoIoTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eq1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaAoBancoDeDadosIoTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.arquivoToolStripMenuItem,
									this.toolStripMenuItem1,
									this.análisesToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1900, 60);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastrarUsuárioToolStripMenuItem,
									this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(156, 52);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// cadastrarUsuárioToolStripMenuItem
			// 
			this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
			this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(376, 52);
			this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuário";
			this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.CadastrarUsuárioToolStripMenuItemClick);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(376, 52);
			this.sairToolStripMenuItem.Text = "Sair";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eToolStripMenuItem,
									this.bancoDeDadosToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 52);
			this.toolStripMenuItem1.Text = "Opções";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// eToolStripMenuItem
			// 
			this.eToolStripMenuItem.Name = "eToolStripMenuItem";
			this.eToolStripMenuItem.Size = new System.Drawing.Size(485, 52);
			this.eToolStripMenuItem.Text = "Cadastrar Equipamentos";
			this.eToolStripMenuItem.Click += new System.EventHandler(this.EToolStripMenuItemClick);
			// 
			// bancoDeDadosToolStripMenuItem
			// 
			this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
			this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(485, 52);
			this.bancoDeDadosToolStripMenuItem.Text = "Novo banco de dados";
			// 
			// análisesToolStripMenuItem
			// 
			this.análisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.acessarEquipamentoIoTToolStripMenuItem,
									this.consultaAoBancoDeDadosIoTToolStripMenuItem});
			this.análisesToolStripMenuItem.Name = "análisesToolStripMenuItem";
			this.análisesToolStripMenuItem.Size = new System.Drawing.Size(160, 52);
			this.análisesToolStripMenuItem.Text = "Análises";
			// 
			// acessarEquipamentoIoTToolStripMenuItem
			// 
			this.acessarEquipamentoIoTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.eq1ToolStripMenuItem});
			this.acessarEquipamentoIoTToolStripMenuItem.Name = "acessarEquipamentoIoTToolStripMenuItem";
			this.acessarEquipamentoIoTToolStripMenuItem.Size = new System.Drawing.Size(609, 52);
			this.acessarEquipamentoIoTToolStripMenuItem.Text = "Acessar Equipamento IoT";
			// 
			// eq1ToolStripMenuItem
			// 
			this.eq1ToolStripMenuItem.Name = "eq1ToolStripMenuItem";
			this.eq1ToolStripMenuItem.Size = new System.Drawing.Size(158, 52);
			this.eq1ToolStripMenuItem.Text = "Eq1";
			// 
			// consultaAoBancoDeDadosIoTToolStripMenuItem
			// 
			this.consultaAoBancoDeDadosIoTToolStripMenuItem.Name = "consultaAoBancoDeDadosIoTToolStripMenuItem";
			this.consultaAoBancoDeDadosIoTToolStripMenuItem.Size = new System.Drawing.Size(609, 52);
			this.consultaAoBancoDeDadosIoTToolStripMenuItem.Text = "Consulta ao banco de dados IoT";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 52);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1900, 638);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "openbrowsernavigate";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem eq1ToolStripMenuItem;
	}
}
