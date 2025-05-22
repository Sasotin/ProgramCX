namespace ProgramCx
{
    partial class TelaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
            PbxImgProdutoVendas = new PictureBox();
            NudQuantidadeProdutoVenda = new NumericUpDown();
            CbxFormasPagamento = new ComboBox();
            label4 = new Label();
            LbNomeProdutoVendas = new Label();
            PainelVendas = new Panel();
            LbEstoqueVenda = new Label();
            NudTotalPagamento = new NumericUpDown();
            NudEstoqueVenda = new NumericUpDown();
            NudTroco = new NumericUpDown();
            LbFormasPagamento = new Label();
            LbQuantidadeProdutoVenda = new Label();
            LbTotalPagamento = new Label();
            BtnCancelarVenda = new Button();
            BtnFinalizarVenda = new Button();
            NudValorRecebido = new NumericUpDown();
            LbTroco = new Label();
            LbValorRecebido = new Label();
            ((System.ComponentModel.ISupportInitialize)PbxImgProdutoVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidadeProdutoVenda).BeginInit();
            PainelVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudTotalPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudEstoqueVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudTroco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudValorRecebido).BeginInit();
            SuspendLayout();
            // 
            // PbxImgProdutoVendas
            // 
            PbxImgProdutoVendas.Anchor = AnchorStyles.None;
            PbxImgProdutoVendas.BackColor = Color.Transparent;
            PbxImgProdutoVendas.BorderStyle = BorderStyle.Fixed3D;
            PbxImgProdutoVendas.Location = new Point(331, 13);
            PbxImgProdutoVendas.Name = "PbxImgProdutoVendas";
            PbxImgProdutoVendas.Size = new Size(280, 280);
            PbxImgProdutoVendas.SizeMode = PictureBoxSizeMode.Zoom;
            PbxImgProdutoVendas.TabIndex = 0;
            PbxImgProdutoVendas.TabStop = false;
            // 
            // NudQuantidadeProdutoVenda
            // 
            NudQuantidadeProdutoVenda.Anchor = AnchorStyles.None;
            NudQuantidadeProdutoVenda.Location = new Point(331, 314);
            NudQuantidadeProdutoVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudQuantidadeProdutoVenda.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudQuantidadeProdutoVenda.Name = "NudQuantidadeProdutoVenda";
            NudQuantidadeProdutoVenda.Size = new Size(142, 23);
            NudQuantidadeProdutoVenda.TabIndex = 1;
            NudQuantidadeProdutoVenda.UseWaitCursor = true;
            NudQuantidadeProdutoVenda.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NudQuantidadeProdutoVenda.ValueChanged += NudQuantidadeProdutoVenda_ValueChanged;
            // 
            // CbxFormasPagamento
            // 
            CbxFormasPagamento.Anchor = AnchorStyles.None;
            CbxFormasPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxFormasPagamento.FlatStyle = FlatStyle.Popup;
            CbxFormasPagamento.FormattingEnabled = true;
            CbxFormasPagamento.Location = new Point(331, 369);
            CbxFormasPagamento.Name = "CbxFormasPagamento";
            CbxFormasPagamento.Size = new Size(280, 23);
            CbxFormasPagamento.TabIndex = 2;
            CbxFormasPagamento.SelectedIndexChanged += CbxFormasPagamento_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 12);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 14;
            // 
            // LbNomeProdutoVendas
            // 
            LbNomeProdutoVendas.Anchor = AnchorStyles.None;
            LbNomeProdutoVendas.AutoSize = true;
            LbNomeProdutoVendas.BackColor = Color.Transparent;
            LbNomeProdutoVendas.Enabled = false;
            LbNomeProdutoVendas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNomeProdutoVendas.ForeColor = SystemColors.ControlLightLight;
            LbNomeProdutoVendas.Location = new Point(330, 13);
            LbNomeProdutoVendas.Name = "LbNomeProdutoVendas";
            LbNomeProdutoVendas.Size = new Size(98, 20);
            LbNomeProdutoVendas.TabIndex = 0;
            LbNomeProdutoVendas.Text = "NOME.PROD";
            // 
            // PainelVendas
            // 
            PainelVendas.BackColor = Color.Transparent;
            PainelVendas.BackgroundImageLayout = ImageLayout.Stretch;
            PainelVendas.Controls.Add(LbEstoqueVenda);
            PainelVendas.Controls.Add(NudTotalPagamento);
            PainelVendas.Controls.Add(NudEstoqueVenda);
            PainelVendas.Controls.Add(NudTroco);
            PainelVendas.Controls.Add(LbFormasPagamento);
            PainelVendas.Controls.Add(LbQuantidadeProdutoVenda);
            PainelVendas.Controls.Add(LbTotalPagamento);
            PainelVendas.Controls.Add(BtnCancelarVenda);
            PainelVendas.Controls.Add(BtnFinalizarVenda);
            PainelVendas.Controls.Add(NudValorRecebido);
            PainelVendas.Controls.Add(LbNomeProdutoVendas);
            PainelVendas.Controls.Add(LbTroco);
            PainelVendas.Controls.Add(LbValorRecebido);
            PainelVendas.Controls.Add(PbxImgProdutoVendas);
            PainelVendas.Dock = DockStyle.Fill;
            PainelVendas.Location = new Point(0, 0);
            PainelVendas.Name = "PainelVendas";
            PainelVendas.Size = new Size(944, 501);
            PainelVendas.TabIndex = 0;
            // 
            // LbEstoqueVenda
            // 
            LbEstoqueVenda.Anchor = AnchorStyles.None;
            LbEstoqueVenda.AutoSize = true;
            LbEstoqueVenda.BackColor = Color.Transparent;
            LbEstoqueVenda.ForeColor = SystemColors.ControlLightLight;
            LbEstoqueVenda.Location = new Point(479, 296);
            LbEstoqueVenda.Name = "LbEstoqueVenda";
            LbEstoqueVenda.Size = new Size(60, 15);
            LbEstoqueVenda.TabIndex = 15;
            LbEstoqueVenda.Text = "ESTOQUE:";
            // 
            // NudTotalPagamento
            // 
            NudTotalPagamento.Anchor = AnchorStyles.None;
            NudTotalPagamento.DecimalPlaces = 2;
            NudTotalPagamento.Enabled = false;
            NudTotalPagamento.Location = new Point(637, 239);
            NudTotalPagamento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudTotalPagamento.Name = "NudTotalPagamento";
            NudTotalPagamento.ReadOnly = true;
            NudTotalPagamento.Size = new Size(124, 23);
            NudTotalPagamento.TabIndex = 5;
            // 
            // NudEstoqueVenda
            // 
            NudEstoqueVenda.Anchor = AnchorStyles.None;
            NudEstoqueVenda.Enabled = false;
            NudEstoqueVenda.Location = new Point(479, 314);
            NudEstoqueVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudEstoqueVenda.Name = "NudEstoqueVenda";
            NudEstoqueVenda.ReadOnly = true;
            NudEstoqueVenda.Size = new Size(132, 23);
            NudEstoqueVenda.TabIndex = 16;
            NudEstoqueVenda.UseWaitCursor = true;
            NudEstoqueVenda.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NudTroco
            // 
            NudTroco.Anchor = AnchorStyles.None;
            NudTroco.DecimalPlaces = 2;
            NudTroco.Enabled = false;
            NudTroco.Location = new Point(637, 147);
            NudTroco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudTroco.Name = "NudTroco";
            NudTroco.ReadOnly = true;
            NudTroco.Size = new Size(124, 23);
            NudTroco.TabIndex = 4;
            // 
            // LbFormasPagamento
            // 
            LbFormasPagamento.Anchor = AnchorStyles.None;
            LbFormasPagamento.AutoSize = true;
            LbFormasPagamento.BackColor = Color.Transparent;
            LbFormasPagamento.ForeColor = SystemColors.ControlLightLight;
            LbFormasPagamento.Location = new Point(331, 351);
            LbFormasPagamento.Name = "LbFormasPagamento";
            LbFormasPagamento.Size = new Size(142, 15);
            LbFormasPagamento.TabIndex = 24;
            LbFormasPagamento.Text = "FORMA DE PAGAMENTO:";
            // 
            // LbQuantidadeProdutoVenda
            // 
            LbQuantidadeProdutoVenda.Anchor = AnchorStyles.None;
            LbQuantidadeProdutoVenda.AutoSize = true;
            LbQuantidadeProdutoVenda.BackColor = Color.Transparent;
            LbQuantidadeProdutoVenda.ForeColor = SystemColors.ControlLightLight;
            LbQuantidadeProdutoVenda.Location = new Point(331, 296);
            LbQuantidadeProdutoVenda.Name = "LbQuantidadeProdutoVenda";
            LbQuantidadeProdutoVenda.Size = new Size(84, 15);
            LbQuantidadeProdutoVenda.TabIndex = 0;
            LbQuantidadeProdutoVenda.Text = "QUANTIDADE:";
            // 
            // LbTotalPagamento
            // 
            LbTotalPagamento.Anchor = AnchorStyles.None;
            LbTotalPagamento.AutoSize = true;
            LbTotalPagamento.BackColor = Color.Transparent;
            LbTotalPagamento.ForeColor = SystemColors.ControlLightLight;
            LbTotalPagamento.Location = new Point(640, 221);
            LbTotalPagamento.Name = "LbTotalPagamento";
            LbTotalPagamento.Size = new Size(119, 15);
            LbTotalPagamento.TabIndex = 20;
            LbTotalPagamento.Text = "TOTAL A PAGAR (R$):\r\n";
            // 
            // BtnCancelarVenda
            // 
            BtnCancelarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelarVenda.BackColor = Color.FromArgb(70, 70, 70);
            BtnCancelarVenda.FlatStyle = FlatStyle.Popup;
            BtnCancelarVenda.Font = new Font("Segoe UI", 12F);
            BtnCancelarVenda.ForeColor = Color.White;
            BtnCancelarVenda.Location = new Point(769, 395);
            BtnCancelarVenda.Name = "BtnCancelarVenda";
            BtnCancelarVenda.Size = new Size(163, 44);
            BtnCancelarVenda.TabIndex = 6;
            BtnCancelarVenda.Text = "Cancelar Venda";
            BtnCancelarVenda.UseVisualStyleBackColor = false;
            BtnCancelarVenda.Click += BtnCancelarVenda_Click;
            // 
            // BtnFinalizarVenda
            // 
            BtnFinalizarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnFinalizarVenda.BackColor = Color.FromArgb(50, 50, 50);
            BtnFinalizarVenda.FlatStyle = FlatStyle.Popup;
            BtnFinalizarVenda.Font = new Font("Segoe UI", 12F);
            BtnFinalizarVenda.ForeColor = Color.White;
            BtnFinalizarVenda.Location = new Point(769, 445);
            BtnFinalizarVenda.Name = "BtnFinalizarVenda";
            BtnFinalizarVenda.Size = new Size(163, 44);
            BtnFinalizarVenda.TabIndex = 7;
            BtnFinalizarVenda.Text = "Finalizar Venda";
            BtnFinalizarVenda.UseVisualStyleBackColor = false;
            BtnFinalizarVenda.Click += BtnFinalizarVenda_Click;
            // 
            // NudValorRecebido
            // 
            NudValorRecebido.Anchor = AnchorStyles.None;
            NudValorRecebido.DecimalPlaces = 2;
            NudValorRecebido.Location = new Point(637, 55);
            NudValorRecebido.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudValorRecebido.Name = "NudValorRecebido";
            NudValorRecebido.Size = new Size(124, 23);
            NudValorRecebido.TabIndex = 3;
            NudValorRecebido.ValueChanged += NudValorRecebido_ValueChanged;
            // 
            // LbTroco
            // 
            LbTroco.Anchor = AnchorStyles.None;
            LbTroco.AutoSize = true;
            LbTroco.BackColor = Color.Transparent;
            LbTroco.ForeColor = SystemColors.ControlLightLight;
            LbTroco.Location = new Point(640, 129);
            LbTroco.Name = "LbTroco";
            LbTroco.Size = new Size(74, 15);
            LbTroco.TabIndex = 18;
            LbTroco.Text = "TROCO (R$):\r\n";
            // 
            // LbValorRecebido
            // 
            LbValorRecebido.Anchor = AnchorStyles.None;
            LbValorRecebido.AutoSize = true;
            LbValorRecebido.BackColor = Color.Transparent;
            LbValorRecebido.ForeColor = SystemColors.ControlLightLight;
            LbValorRecebido.Location = new Point(640, 37);
            LbValorRecebido.Name = "LbValorRecebido";
            LbValorRecebido.Size = new Size(127, 15);
            LbValorRecebido.TabIndex = 17;
            LbValorRecebido.Text = "VALOR RECEBIDO (R$):\r\n";
            // 
            // TelaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(944, 501);
            Controls.Add(label4);
            Controls.Add(CbxFormasPagamento);
            Controls.Add(NudQuantidadeProdutoVenda);
            Controls.Add(PainelVendas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(960, 540);
            Name = "TelaVenda";
            Text = "Vendas";
            FormClosing += TelaVenda_FormClosing;
            Load += TelaVenda_Load;
            ((System.ComponentModel.ISupportInitialize)PbxImgProdutoVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudQuantidadeProdutoVenda).EndInit();
            PainelVendas.ResumeLayout(false);
            PainelVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudTotalPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudEstoqueVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudTroco).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudValorRecebido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbxImgProdutoVendas;
        private NumericUpDown NudQuantidadeProdutoVenda;
        private ComboBox CbxFormasPagamento;
        private Label label4;
        private Label LbNomeProdutoVendas;
        private Panel PainelVendas;
        private Label LbTroco;
        private Label LbValorRecebido;
        private NumericUpDown NudValorRecebido;
        private Button BtnFinalizarVenda;
        private Button BtnCancelarVenda;
        private Label LbTotalPagamento;
        private Label LbFormasPagamento;
        private Label LbQuantidadeProdutoVenda;
        private NumericUpDown NudTotalPagamento;
        private NumericUpDown NudTroco;
        private Label LbEstoqueVenda;
        private NumericUpDown NudEstoqueVenda;
    }
}