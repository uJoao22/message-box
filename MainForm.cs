using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PjCxMessage
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bom dia");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Olá galera, saudações", "Saudação");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Deseja sair do programa?","Verificação",MessageBoxButtons.YesNo) == DialogResult.Yes)
				Close();
			else
				MessageBox.Show("Oba, então o programa continuará em execução!");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Quarto exemplo de MessageBox", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Tem certeza que deseja sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			Close();
		}
	}
}
