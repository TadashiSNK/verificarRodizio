/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 08/08/2025
 * Hora: 20:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VerificarFolgas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		

		string[] diasSemana = {"segunda", "terca", "quarta", "quinta", "sexta"};
		
		void VerificarBTNClick(object sender, EventArgs e)
		{
			int ctrl = 0;
			finalTEXT.Text += "Escala de rodizios" + "\n";
			
			foreach (string dia in diasSemana)
			{
				finalTEXT.Text += "\n" + dia + "\n";
				
				
				for(int i=0;i<infoText.Lines.Length;i++)
				{
					string[] placa_nome = infoText.Lines[i].Split('\t');
					string placa = placa_nome[0];
					string nome = placa_nome[1];
					consultaRodizio(placa, nome, ctrl);
				}
				ctrl++;
			}
		}
		
		void consultaRodizio(string placa, string nome, int dia)
		{
			if ((placa[6] == '1' && dia == 0) || (placa[6] == '2' && dia == 0))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '3' && dia == 1) || (placa[6] == '4' && dia == 1))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '5' && dia == 2) || (placa[6] == '6' && dia == 2))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '7' && dia == 3) || (placa[6] == '8' && dia == 3))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '9' && dia == 4) || (placa[6] == '0' && dia == 4))
			{
				finalTEXT.Text += nome + "\n";
			}
		}
		
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			infoText.LoadFile("PlacaCarros.txt", RichTextBoxStreamType.PlainText);
		}
		
		
	}
}
