namespace ProgramCx
{
    partial class Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            BtnDeletarLogVendas = new Button();
            BtnDeletarProdutos = new Button();
            BtnSairConfiguracoes = new Button();
            SuspendLayout();
            // 
            // BtnDeletarLogVendas
            // 
            BtnDeletarLogVendas.Anchor = AnchorStyles.None;
            BtnDeletarLogVendas.BackColor = Color.FromArgb(50, 50, 50);
            BtnDeletarLogVendas.FlatAppearance.BorderColor = Color.Black;
            BtnDeletarLogVendas.FlatStyle = FlatStyle.Popup;
            BtnDeletarLogVendas.Font = new Font("Segoe UI", 12F);
            BtnDeletarLogVendas.ForeColor = Color.White;
            BtnDeletarLogVendas.Location = new Point(82, 108);
            BtnDeletarLogVendas.Name = "BtnDeletarLogVendas";
            BtnDeletarLogVendas.Size = new Size(221, 44);
            BtnDeletarLogVendas.TabIndex = 0;
            BtnDeletarLogVendas.Text = "DELETAR LOG DE VENDAS";
            BtnDeletarLogVendas.UseVisualStyleBackColor = false;
            BtnDeletarLogVendas.Click += BtnResetarLogVendas_Click;
            // 
            // BtnDeletarProdutos
            // 
            BtnDeletarProdutos.Anchor = AnchorStyles.None;
            BtnDeletarProdutos.BackColor = Color.FromArgb(50, 50, 50);
            BtnDeletarProdutos.FlatAppearance.BorderColor = Color.Black;
            BtnDeletarProdutos.FlatStyle = FlatStyle.Popup;
            BtnDeletarProdutos.Font = new Font("Segoe UI", 12F);
            BtnDeletarProdutos.ForeColor = Color.White;
            BtnDeletarProdutos.Location = new Point(82, 158);
            BtnDeletarProdutos.Name = "BtnDeletarProdutos";
            BtnDeletarProdutos.Size = new Size(221, 44);
            BtnDeletarProdutos.TabIndex = 1;
            BtnDeletarProdutos.Text = "DELETAR PRODUTOS ";
            BtnDeletarProdutos.UseVisualStyleBackColor = false;
            BtnDeletarProdutos.Click += BtnResetarProdutos_Click;
            // 
            // BtnSairConfiguracoes
            // 
            BtnSairConfiguracoes.Anchor = AnchorStyles.None;
            BtnSairConfiguracoes.BackColor = Color.FromArgb(50, 50, 50);
            BtnSairConfiguracoes.FlatAppearance.BorderColor = Color.Black;
            BtnSairConfiguracoes.FlatStyle = FlatStyle.Popup;
            BtnSairConfiguracoes.Font = new Font("Segoe UI", 12F);
            BtnSairConfiguracoes.ForeColor = Color.White;
            BtnSairConfiguracoes.Location = new Point(82, 208);
            BtnSairConfiguracoes.Name = "BtnSairConfiguracoes";
            BtnSairConfiguracoes.Size = new Size(221, 44);
            BtnSairConfiguracoes.TabIndex = 2;
            BtnSairConfiguracoes.Text = "SAIR";
            BtnSairConfiguracoes.UseVisualStyleBackColor = false;
            BtnSairConfiguracoes.Click += BtnSairConfiguracoes_Click;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 361);
            Controls.Add(BtnSairConfiguracoes);
            Controls.Add(BtnDeletarProdutos);
            Controls.Add(BtnDeletarLogVendas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 400);
            Name = "Configuracoes";
            Text = "Configurações";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnDeletarLogVendas;
        private Button BtnDeletarProdutos;
        private Button BtnSairConfiguracoes;
    }
}