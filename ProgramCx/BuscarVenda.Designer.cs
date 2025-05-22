namespace ProgramCx
{
    partial class BuscarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarVenda));
            DgvBuscarVendas = new DataGridView();
            DtpInicio = new DateTimePicker();
            LbBuscarVenda = new Label();
            TxtBuscarVenda = new TextBox();
            DtpFim = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            BtnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvBuscarVendas).BeginInit();
            SuspendLayout();
            // 
            // DgvBuscarVendas
            // 
            DgvBuscarVendas.Anchor = AnchorStyles.None;
            DgvBuscarVendas.BackgroundColor = Color.FromArgb(70, 70, 70);
            DgvBuscarVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBuscarVendas.Location = new Point(98, 123);
            DgvBuscarVendas.Name = "DgvBuscarVendas";
            DgvBuscarVendas.Size = new Size(749, 314);
            DgvBuscarVendas.TabIndex = 6;
            // 
            // DtpInicio
            // 
            DtpInicio.Anchor = AnchorStyles.None;
            DtpInicio.Format = DateTimePickerFormat.Short;
            DtpInicio.Location = new Point(321, 94);
            DtpInicio.Name = "DtpInicio";
            DtpInicio.Size = new Size(125, 23);
            DtpInicio.TabIndex = 1;
            // 
            // LbBuscarVenda
            // 
            LbBuscarVenda.Anchor = AnchorStyles.None;
            LbBuscarVenda.AutoSize = true;
            LbBuscarVenda.BackColor = Color.Transparent;
            LbBuscarVenda.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LbBuscarVenda.ForeColor = Color.White;
            LbBuscarVenda.Location = new Point(98, 71);
            LbBuscarVenda.Name = "LbBuscarVenda";
            LbBuscarVenda.Size = new Size(72, 20);
            LbBuscarVenda.TabIndex = 0;
            LbBuscarVenda.Text = "BUSCAR...";
            // 
            // TxtBuscarVenda
            // 
            TxtBuscarVenda.Anchor = AnchorStyles.None;
            TxtBuscarVenda.Location = new Point(98, 94);
            TxtBuscarVenda.Name = "TxtBuscarVenda";
            TxtBuscarVenda.Size = new Size(217, 23);
            TxtBuscarVenda.TabIndex = 0;
            // 
            // DtpFim
            // 
            DtpFim.Anchor = AnchorStyles.None;
            DtpFim.Format = DateTimePickerFormat.Short;
            DtpFim.Location = new Point(490, 94);
            DtpFim.Name = "DtpFim";
            DtpFim.Size = new Size(125, 23);
            DtpFim.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(452, 94);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "ATÉ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(737, 94);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 5;
            button1.Text = "LIMPAR FILTROS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnLimparFiltros_Click;
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Anchor = AnchorStyles.None;
            BtnFiltrar.BackColor = Color.White;
            BtnFiltrar.FlatStyle = FlatStyle.Popup;
            BtnFiltrar.Location = new Point(621, 94);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(110, 23);
            BtnFiltrar.TabIndex = 4;
            BtnFiltrar.Text = "FILTRAR";
            BtnFiltrar.UseVisualStyleBackColor = false;
            // 
            // BuscarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(944, 501);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(BtnFiltrar);
            Controls.Add(DtpFim);
            Controls.Add(LbBuscarVenda);
            Controls.Add(DtpInicio);
            Controls.Add(DgvBuscarVendas);
            Controls.Add(TxtBuscarVenda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(960, 540);
            Name = "BuscarVenda";
            Text = "Buscar Venda";
            Load += HistoricoVendas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvBuscarVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvBuscarVendas;
        private DateTimePicker DtpInicio;
        private Label LbBuscarVenda;
        private TextBox TxtBuscarVenda;
        private DateTimePicker DtpFim;
        private Label label1;
        private Button button1;
        private Button BtnFiltrar;
    }
}