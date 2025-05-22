namespace ProgramCx
{
    partial class CadastroProdutos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            BtnDeletarProduto = new Button();
            BtnEditarProduto = new Button();
            BtnSalvarProduto = new Button();
            BtnSairAbaCadastro = new Button();
            PainelAbaCadastro = new Panel();
            LbNomeProduto = new Label();
            PbImagemProduto = new PictureBox();
            BtnDeletarImgProduto = new Button();
            LbPrecoProduto = new Label();
            LbQuantidadeProduto = new Label();
            BtnSelecionarImgProduto = new Button();
            NudPrecoProduto = new NumericUpDown();
            NudQuantidadeProduto = new NumericUpDown();
            DgvProdutos = new DataGridView();
            TxtNomeProduto = new TextBox();
            PainelAbaCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagemProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPrecoProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidadeProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // BtnDeletarProduto
            // 
            BtnDeletarProduto.Anchor = AnchorStyles.None;
            BtnDeletarProduto.BackColor = Color.FromArgb(50, 50, 50);
            BtnDeletarProduto.FlatAppearance.BorderColor = Color.Black;
            BtnDeletarProduto.FlatStyle = FlatStyle.Popup;
            BtnDeletarProduto.Font = new Font("Segoe UI", 12F);
            BtnDeletarProduto.ForeColor = Color.White;
            BtnDeletarProduto.Location = new Point(439, 380);
            BtnDeletarProduto.Name = "BtnDeletarProduto";
            BtnDeletarProduto.Size = new Size(205, 44);
            BtnDeletarProduto.TabIndex = 6;
            BtnDeletarProduto.Text = "Deletar";
            BtnDeletarProduto.UseVisualStyleBackColor = false;
            BtnDeletarProduto.Click += BtnDeletarProduto_Click;
            // 
            // BtnEditarProduto
            // 
            BtnEditarProduto.Anchor = AnchorStyles.None;
            BtnEditarProduto.BackColor = Color.FromArgb(70, 70, 70);
            BtnEditarProduto.FlatAppearance.BorderColor = Color.Black;
            BtnEditarProduto.FlatStyle = FlatStyle.Popup;
            BtnEditarProduto.Font = new Font("Segoe UI", 12F);
            BtnEditarProduto.ForeColor = Color.White;
            BtnEditarProduto.Location = new Point(439, 330);
            BtnEditarProduto.Name = "BtnEditarProduto";
            BtnEditarProduto.Size = new Size(205, 44);
            BtnEditarProduto.TabIndex = 5;
            BtnEditarProduto.Text = "Editar ";
            BtnEditarProduto.UseVisualStyleBackColor = false;
            BtnEditarProduto.Click += BtnEditarProduto_Click;
            // 
            // BtnSalvarProduto
            // 
            BtnSalvarProduto.Anchor = AnchorStyles.None;
            BtnSalvarProduto.BackColor = Color.FromArgb(70, 70, 70);
            BtnSalvarProduto.FlatStyle = FlatStyle.Popup;
            BtnSalvarProduto.Font = new Font("Segoe UI", 12F);
            BtnSalvarProduto.ForeColor = Color.White;
            BtnSalvarProduto.Location = new Point(655, 330);
            BtnSalvarProduto.Name = "BtnSalvarProduto";
            BtnSalvarProduto.Size = new Size(205, 44);
            BtnSalvarProduto.TabIndex = 7;
            BtnSalvarProduto.Text = "Salvar\r\n";
            BtnSalvarProduto.UseVisualStyleBackColor = false;
            BtnSalvarProduto.Click += BtnSalvarProduto_Click;
            // 
            // BtnSairAbaCadastro
            // 
            BtnSairAbaCadastro.Anchor = AnchorStyles.None;
            BtnSairAbaCadastro.BackColor = Color.FromArgb(50, 50, 50);
            BtnSairAbaCadastro.FlatStyle = FlatStyle.Popup;
            BtnSairAbaCadastro.Font = new Font("Segoe UI", 12F);
            BtnSairAbaCadastro.ForeColor = Color.White;
            BtnSairAbaCadastro.Location = new Point(655, 380);
            BtnSairAbaCadastro.Name = "BtnSairAbaCadastro";
            BtnSairAbaCadastro.Size = new Size(205, 44);
            BtnSairAbaCadastro.TabIndex = 8;
            BtnSairAbaCadastro.Text = "Sair";
            BtnSairAbaCadastro.UseVisualStyleBackColor = false;
            BtnSairAbaCadastro.Click += BtnSairAbaCadastro_Click;
            // 
            // PainelAbaCadastro
            // 
            PainelAbaCadastro.BackColor = Color.FromArgb(60, 60, 60);
            PainelAbaCadastro.BackgroundImageLayout = ImageLayout.Zoom;
            PainelAbaCadastro.Controls.Add(LbNomeProduto);
            PainelAbaCadastro.Controls.Add(PbImagemProduto);
            PainelAbaCadastro.Controls.Add(BtnDeletarImgProduto);
            PainelAbaCadastro.Controls.Add(LbPrecoProduto);
            PainelAbaCadastro.Controls.Add(LbQuantidadeProduto);
            PainelAbaCadastro.Controls.Add(BtnSelecionarImgProduto);
            PainelAbaCadastro.Controls.Add(NudPrecoProduto);
            PainelAbaCadastro.Controls.Add(NudQuantidadeProduto);
            PainelAbaCadastro.Controls.Add(DgvProdutos);
            PainelAbaCadastro.Controls.Add(TxtNomeProduto);
            PainelAbaCadastro.Controls.Add(BtnEditarProduto);
            PainelAbaCadastro.Controls.Add(BtnSairAbaCadastro);
            PainelAbaCadastro.Controls.Add(BtnDeletarProduto);
            PainelAbaCadastro.Controls.Add(BtnSalvarProduto);
            PainelAbaCadastro.Dock = DockStyle.Fill;
            PainelAbaCadastro.Location = new Point(0, 0);
            PainelAbaCadastro.Name = "PainelAbaCadastro";
            PainelAbaCadastro.Size = new Size(944, 501);
            PainelAbaCadastro.TabIndex = 0;
            // 
            // LbNomeProduto
            // 
            LbNomeProduto.Anchor = AnchorStyles.None;
            LbNomeProduto.AutoSize = true;
            LbNomeProduto.BackColor = Color.Transparent;
            LbNomeProduto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            LbNomeProduto.ForeColor = SystemColors.ControlLightLight;
            LbNomeProduto.Location = new Point(84, 39);
            LbNomeProduto.Name = "LbNomeProduto";
            LbNomeProduto.Size = new Size(136, 17);
            LbNomeProduto.TabIndex = 27;
            LbNomeProduto.Text = "NOME DO PRODUTO";
            // 
            // PbImagemProduto
            // 
            PbImagemProduto.Anchor = AnchorStyles.None;
            PbImagemProduto.BackColor = Color.Transparent;
            PbImagemProduto.BackgroundImageLayout = ImageLayout.Stretch;
            PbImagemProduto.BorderStyle = BorderStyle.Fixed3D;
            PbImagemProduto.Location = new Point(84, 162);
            PbImagemProduto.Name = "PbImagemProduto";
            PbImagemProduto.Size = new Size(153, 153);
            PbImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            PbImagemProduto.TabIndex = 26;
            PbImagemProduto.TabStop = false;
            // 
            // BtnDeletarImgProduto
            // 
            BtnDeletarImgProduto.Anchor = AnchorStyles.None;
            BtnDeletarImgProduto.BackColor = Color.FromArgb(50, 50, 50);
            BtnDeletarImgProduto.FlatAppearance.BorderColor = Color.Black;
            BtnDeletarImgProduto.FlatStyle = FlatStyle.Popup;
            BtnDeletarImgProduto.Font = new Font("Segoe UI", 12F);
            BtnDeletarImgProduto.ForeColor = Color.White;
            BtnDeletarImgProduto.Location = new Point(250, 268);
            BtnDeletarImgProduto.Name = "BtnDeletarImgProduto";
            BtnDeletarImgProduto.Size = new Size(153, 47);
            BtnDeletarImgProduto.TabIndex = 4;
            BtnDeletarImgProduto.Text = "Excluir Imagem";
            BtnDeletarImgProduto.UseVisualStyleBackColor = false;
            BtnDeletarImgProduto.Click += BtnDeletarImgProduto_Click;
            // 
            // LbPrecoProduto
            // 
            LbPrecoProduto.Anchor = AnchorStyles.None;
            LbPrecoProduto.AutoSize = true;
            LbPrecoProduto.BackColor = Color.Transparent;
            LbPrecoProduto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            LbPrecoProduto.ForeColor = SystemColors.ControlLightLight;
            LbPrecoProduto.Location = new Point(250, 85);
            LbPrecoProduto.Name = "LbPrecoProduto";
            LbPrecoProduto.Size = new Size(68, 17);
            LbPrecoProduto.TabIndex = 23;
            LbPrecoProduto.Text = "PREÇO R$";
            // 
            // LbQuantidadeProduto
            // 
            LbQuantidadeProduto.Anchor = AnchorStyles.None;
            LbQuantidadeProduto.AutoSize = true;
            LbQuantidadeProduto.BackColor = Color.Transparent;
            LbQuantidadeProduto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            LbQuantidadeProduto.ForeColor = SystemColors.ControlLightLight;
            LbQuantidadeProduto.Location = new Point(84, 85);
            LbQuantidadeProduto.Name = "LbQuantidadeProduto";
            LbQuantidadeProduto.Size = new Size(97, 17);
            LbQuantidadeProduto.TabIndex = 21;
            LbQuantidadeProduto.Text = "QUANTIDADE ";
            // 
            // BtnSelecionarImgProduto
            // 
            BtnSelecionarImgProduto.Anchor = AnchorStyles.None;
            BtnSelecionarImgProduto.BackColor = Color.FromArgb(70, 70, 70);
            BtnSelecionarImgProduto.FlatAppearance.BorderColor = Color.Black;
            BtnSelecionarImgProduto.FlatStyle = FlatStyle.Popup;
            BtnSelecionarImgProduto.Font = new Font("Segoe UI", 12F);
            BtnSelecionarImgProduto.ForeColor = Color.White;
            BtnSelecionarImgProduto.Location = new Point(250, 215);
            BtnSelecionarImgProduto.Name = "BtnSelecionarImgProduto";
            BtnSelecionarImgProduto.Size = new Size(153, 47);
            BtnSelecionarImgProduto.TabIndex = 3;
            BtnSelecionarImgProduto.Text = "Selecionar Imagem";
            BtnSelecionarImgProduto.UseVisualStyleBackColor = false;
            BtnSelecionarImgProduto.Click += BtnSelecionarImgProduto_Click;
            // 
            // NudPrecoProduto
            // 
            NudPrecoProduto.Anchor = AnchorStyles.None;
            NudPrecoProduto.BorderStyle = BorderStyle.FixedSingle;
            NudPrecoProduto.DecimalPlaces = 2;
            NudPrecoProduto.Location = new Point(250, 103);
            NudPrecoProduto.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NudPrecoProduto.Name = "NudPrecoProduto";
            NudPrecoProduto.Size = new Size(153, 23);
            NudPrecoProduto.TabIndex = 2;
            // 
            // NudQuantidadeProduto
            // 
            NudQuantidadeProduto.Anchor = AnchorStyles.None;
            NudQuantidadeProduto.BorderStyle = BorderStyle.FixedSingle;
            NudQuantidadeProduto.Location = new Point(84, 103);
            NudQuantidadeProduto.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NudQuantidadeProduto.Name = "NudQuantidadeProduto";
            NudQuantidadeProduto.Size = new Size(153, 23);
            NudQuantidadeProduto.TabIndex = 1;
            // 
            // DgvProdutos
            // 
            DgvProdutos.AllowUserToAddRows = false;
            DgvProdutos.AllowUserToDeleteRows = false;
            DgvProdutos.AllowUserToResizeColumns = false;
            DgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            DgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvProdutos.Anchor = AnchorStyles.None;
            DgvProdutos.BackgroundColor = Color.FromArgb(70, 70, 70);
            DgvProdutos.BorderStyle = BorderStyle.Fixed3D;
            DgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            DgvProdutos.GridColor = Color.Black;
            DgvProdutos.Location = new Point(439, 57);
            DgvProdutos.MultiSelect = false;
            DgvProdutos.Name = "DgvProdutos";
            DgvProdutos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DgvProdutos.ScrollBars = ScrollBars.Vertical;
            DgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProdutos.Size = new Size(421, 258);
            DgvProdutos.TabIndex = 9;
            // 
            // TxtNomeProduto
            // 
            TxtNomeProduto.Anchor = AnchorStyles.None;
            TxtNomeProduto.Location = new Point(84, 57);
            TxtNomeProduto.Name = "TxtNomeProduto";
            TxtNomeProduto.Size = new Size(319, 23);
            TxtNomeProduto.TabIndex = 0;
            // 
            // CadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(944, 501);
            Controls.Add(PainelAbaCadastro);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "CadastroProdutos";
            Text = "Cadastro de Produtos";
            Load += CadastroProdutos_Load;
            PainelAbaCadastro.ResumeLayout(false);
            PainelAbaCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbImagemProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPrecoProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidadeProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvProd;
        private Button BtnSalvarProduto;
        private Button BtnSairAbaCadastro;
        private Button BtnDeletarProduto;
        private Button BtnEditarProduto;
        private DataGridViewTextBoxColumn ColumName;
        private DataGridViewTextBoxColumn ColumQuant;
        private DataGridViewTextBoxColumn ColumPrice;
        private Panel PainelAbaCadastro;
        private PictureBox PbImagemProduto;
        private Button BtnDeletarImgProduto;
        private Label LbPrecoProduto;
        private Label LbQuantidadeProduto;
        private Button BtnSelecionarImgProduto;
        private NumericUpDown NudPrecoProduto;
        private NumericUpDown NudQuantidadeProduto;
        private DataGridView DgvProdutos;
        private TextBox TxtNomeProduto;
        private Label LbNomeProduto;
    }
}