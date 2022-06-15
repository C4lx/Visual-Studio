using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;   //mover a bola
        public int speed_top = 4;
        public int points = 0;        //conta os pontos


        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();                                  //ocultar cursor

            this.FormBorderStyle = FormBorderStyle.None;    //remove a borda
            this.TopMost = true;                            //trazer a forma pra frente(?)
            this.Bounds = Screen.PrimaryScreen.Bounds;      //deixar a tela cheia

            racket.Top = playground.Bottom - (playground.Bottom / 10);    //define a posição da racket

            lblGameover.Left = (playground.Width / 2) - (lblGameover.Width / 2);
            lblGameover.Top = (playground.Height / 2) - (lblGameover.Height / 2);
            lblGameover.Visible = false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);        //define o centro da racket para a posição do cursor
            
            ball.Left += speed_left;       //move a bola
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;      //muda a direção
                points += 1;
                points_lbl.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                lblGameover.Visible = true;
            }


        } 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { 
                this.Close();   //pressione Esc para Sair
            }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                points_lbl.Text = "0";
                timer1.Enabled = true;
                lblGameover.Visible = false;
                playground.BackColor = Color.White;
            }
        }

        private void points_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
