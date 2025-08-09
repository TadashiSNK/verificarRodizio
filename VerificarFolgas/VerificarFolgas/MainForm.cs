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
			finalTEXT.Text += "Escala de rodizios" + "\n";
			
			foreach (string dia in diasSemana)
			{
				finalTEXT.Text += "\n" + dia + "\n";
				
				
				for(int i=0;i<infoText.Lines.Length;i++)
				{
					string[] placa_nome = infoText.Lines[i].Split('\t');
					string placa = placa_nome[0];
					string nome = placa_nome[1];
					consultaRodizio(placa, nome, dia);
				}
			}
		}
		
		void consultaRodizio(string placa, string nome, string dia)
		{
			if ((placa[6] == '1' && dia == "segunda") || (placa[6] == '2' && dia == "segunda"))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '3' && dia == "terca") || (placa[6] == '4' && dia == "terca"))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '5' && dia == "quarta") || (placa[6] == '6' && dia == "quarta"))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '7' && dia == "quinta") || (placa[6] == '8' && dia == "quinta"))
			{
				finalTEXT.Text += nome + "\n";
			}
			else if ((placa[6] == '9' && dia == "sexta") || (placa[6] == '0' && dia == "sexta"))
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
