
namespace Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.points_lbl = new System.Windows.Forms.Label();
            this.scare_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGameover = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.lblGameover);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.scare_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(720, 449);
            this.playground.TabIndex = 0;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_lbl.Location = new System.Drawing.Point(102, 26);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(20, 24);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            this.points_lbl.Click += new System.EventHandler(this.points_lbl_Click);
            // 
            // scare_lbl
            // 
            this.scare_lbl.AutoSize = true;
            this.scare_lbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scare_lbl.Location = new System.Drawing.Point(22, 21);
            this.scare_lbl.Name = "scare_lbl";
            this.scare_lbl.Size = new System.Drawing.Size(74, 33);
            this.scare_lbl.TabIndex = 2;
            this.scare_lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ball.Location = new System.Drawing.Point(28, 77);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(254, 417);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGameover
            // 
            this.lblGameover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameover.AutoSize = true;
            this.lblGameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameover.Location = new System.Drawing.Point(298, 143);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(183, 148);
            this.lblGameover.TabIndex = 4;
            this.lblGameover.Text = "Game over\r\n\r\nF1 - Restart\r\nEsc - Exit";
            this.lblGameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 449);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label scare_lbl;
        private System.Windows.Forms.Label lblGameover;
    }
}

