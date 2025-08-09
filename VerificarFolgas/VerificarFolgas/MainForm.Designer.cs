/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 08/08/2025
 * Hora: 20:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace VerificarFolgas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox infoText;
		private System.Windows.Forms.RichTextBox resultText;
		private System.Windows.Forms.Button verificarBTN;
		private System.Windows.Forms.RichTextBox finalTEXT;
		
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
			this.infoText = new System.Windows.Forms.RichTextBox();
			this.resultText = new System.Windows.Forms.RichTextBox();
			this.verificarBTN = new System.Windows.Forms.Button();
			this.finalTEXT = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// infoText
			// 
			this.infoText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infoText.Location = new System.Drawing.Point(23, 35);
			this.infoText.Name = "infoText";
			this.infoText.Size = new System.Drawing.Size(356, 497);
			this.infoText.TabIndex = 0;
			this.infoText.Text = "";
			// 
			// resultText
			// 
			this.resultText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultText.Location = new System.Drawing.Point(685, 35);
			this.resultText.Name = "resultText";
			this.resultText.Size = new System.Drawing.Size(356, 497);
			this.resultText.TabIndex = 1;
			this.resultText.Text = "";
			this.resultText.Visible = false;
			// 
			// verificarBTN
			// 
			this.verificarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.verificarBTN.Location = new System.Drawing.Point(417, 205);
			this.verificarBTN.Name = "verificarBTN";
			this.verificarBTN.Size = new System.Drawing.Size(237, 163);
			this.verificarBTN.TabIndex = 2;
			this.verificarBTN.Text = "VERIFICAR";
			this.verificarBTN.UseVisualStyleBackColor = true;
			this.verificarBTN.Click += new System.EventHandler(this.VerificarBTNClick);
			// 
			// finalTEXT
			// 
			this.finalTEXT.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.finalTEXT.Location = new System.Drawing.Point(685, 35);
			this.finalTEXT.Name = "finalTEXT";
			this.finalTEXT.Size = new System.Drawing.Size(356, 497);
			this.finalTEXT.TabIndex = 3;
			this.finalTEXT.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 573);
			this.Controls.Add(this.finalTEXT);
			this.Controls.Add(this.verificarBTN);
			this.Controls.Add(this.resultText);
			this.Controls.Add(this.infoText);
			this.Name = "MainForm";
			this.Text = "VerificarFolgas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
