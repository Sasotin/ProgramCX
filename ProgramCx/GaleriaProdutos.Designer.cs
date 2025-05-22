namespace ProgramCx
{
    partial class GaleriaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaleriaProdutos));
            BtnSairGaleria = new Button();
            FlpGaleriaProdutos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // BtnSairGaleria
            // 
            BtnSairGaleria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSairGaleria.BackColor = Color.FromArgb(70, 70, 70);
            BtnSairGaleria.FlatStyle = FlatStyle.Popup;
            BtnSairGaleria.Font = new Font("Segoe UI", 12F);
            BtnSairGaleria.ForeColor = Color.White;
            BtnSairGaleria.Location = new Point(760, 445);
            BtnSairGaleria.Name = "BtnSairGaleria";
            BtnSairGaleria.Size = new Size(163, 44);
            BtnSairGaleria.TabIndex = 13;
            BtnSairGaleria.Text = "Sair";
            BtnSairGaleria.UseVisualStyleBackColor = false;
            BtnSairGaleria.Click += BtnSairGaleria_Click;
            // 
            // FlpGaleriaProdutos
            // 
            FlpGaleriaProdutos.AutoScroll = true;
            FlpGaleriaProdutos.BackColor = Color.Transparent;
            FlpGaleriaProdutos.Dock = DockStyle.Fill;
            FlpGaleriaProdutos.Location = new Point(0, 0);
            FlpGaleriaProdutos.MaximumSize = new Size(5000, 1080);
            FlpGaleriaProdutos.Name = "FlpGaleriaProdutos";
            FlpGaleriaProdutos.Size = new Size(944, 501);
            FlpGaleriaProdutos.TabIndex = 14;
            // 
            // GaleriaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(944, 501);
            Controls.Add(BtnSairGaleria);
            Controls.Add(FlpGaleriaProdutos);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(960, 540);
            Name = "GaleriaProdutos";
            Text = "Galeria de Produtos";
            WindowState = FormWindowState.Maximized;
            FormClosing += GaleriaProdutos_FormClosing;
            Load += GaleriaProdutos_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button BtnSairGaleria;
        private FlowLayoutPanel FlpGaleriaProdutos;
    }
}