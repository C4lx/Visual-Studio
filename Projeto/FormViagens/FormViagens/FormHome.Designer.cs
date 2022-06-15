namespace FormViagens
{
    partial class frmHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIconeBeta = new System.Windows.Forms.Label();
            this.lbHotel = new System.Windows.Forms.LinkLabel();
            this.lbLocal = new System.Windows.Forms.LinkLabel();
            this.lbPacotes = new System.Windows.Forms.LinkLabel();
            this.bntBusca = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meusPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1133, 150);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIconeBeta
            // 
            this.lblIconeBeta.BackColor = System.Drawing.Color.Orange;
            this.lblIconeBeta.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconeBeta.Location = new System.Drawing.Point(12, 0);
            this.lblIconeBeta.Name = "lblIconeBeta";
            this.lblIconeBeta.Size = new System.Drawing.Size(290, 62);
            this.lblIconeBeta.TabIndex = 1;
            this.lblIconeBeta.Text = "Traveling ";
            this.lblIconeBeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHotel
            // 
            this.lbHotel.AutoSize = true;
            this.lbHotel.BackColor = System.Drawing.Color.Orange;
            this.lbHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHotel.LinkColor = System.Drawing.Color.Black;
            this.lbHotel.Location = new System.Drawing.Point(405, 69);
            this.lbHotel.Name = "lbHotel";
            this.lbHotel.Size = new System.Drawing.Size(82, 29);
            this.lbHotel.TabIndex = 1;
            this.lbHotel.TabStop = true;
            this.lbHotel.Text = "Hoteís";
            this.lbHotel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbHotel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbHotel_LinkClicked);
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.BackColor = System.Drawing.Color.Orange;
            this.lbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocal.LinkColor = System.Drawing.Color.Black;
            this.lbLocal.Location = new System.Drawing.Point(566, 69);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(83, 29);
            this.lbLocal.TabIndex = 2;
            this.lbLocal.TabStop = true;
            this.lbLocal.Text = "Locais";
            this.lbLocal.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbLocal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLocal_LinkClicked);
            // 
            // lbPacotes
            // 
            this.lbPacotes.AutoSize = true;
            this.lbPacotes.BackColor = System.Drawing.Color.Orange;
            this.lbPacotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPacotes.LinkColor = System.Drawing.Color.Black;
            this.lbPacotes.Location = new System.Drawing.Point(735, 69);
            this.lbPacotes.Name = "lbPacotes";
            this.lbPacotes.Size = new System.Drawing.Size(100, 29);
            this.lbPacotes.TabIndex = 3;
            this.lbPacotes.TabStop = true;
            this.lbPacotes.Text = "Pacotes";
            this.lbPacotes.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbPacotes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbPacotes_LinkClicked);
            // 
            // bntBusca
            // 
            this.bntBusca.BackColor = System.Drawing.Color.Snow;
            this.bntBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntBusca.Location = new System.Drawing.Point(319, 523);
            this.bntBusca.Name = "bntBusca";
            this.bntBusca.Size = new System.Drawing.Size(516, 38);
            this.bntBusca.TabIndex = 8;
            this.bntBusca.Text = "&Buscar";
            this.bntBusca.UseVisualStyleBackColor = false;
            this.bntBusca.Click += new System.EventHandler(this.bntBusca_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusPedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(966, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(149, 33);
            this.menuStrip1.TabIndex = 4;
            // 
            // meusPedidosToolStripMenuItem
            // 
            this.meusPedidosToolStripMenuItem.Name = "meusPedidosToolStripMenuItem";
            this.meusPedidosToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.meusPedidosToolStripMenuItem.Text = "Meus Pedidos";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 48);
            this.label2.TabIndex = 21;
            this.label2.Text = " in";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 61);
            this.label3.TabIndex = 22;
            this.label3.Text = "Africa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1133, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bntBusca);
            this.Controls.Add(this.lbPacotes);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.lbHotel);
            this.Controls.Add(this.lblIconeBeta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traveling in Africa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIconeBeta;
        private System.Windows.Forms.LinkLabel lbHotel;
        private System.Windows.Forms.LinkLabel lbLocal;
        private System.Windows.Forms.LinkLabel lbPacotes;
        private System.Windows.Forms.Button bntBusca;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meusPedidosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

