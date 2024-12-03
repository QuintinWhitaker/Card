using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           // creates brush and selects text font and size
            Graphics g = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // draws shapes and text using coordinates
            g.Clear(Color.Black) ;
            g.DrawEllipse(redpen, 100, 100, 100, 100);
            g.DrawEllipse(redpen, 125, 125, 50, 50);
            g.FillEllipse(redBrush, 125, 125, 50, 50);
            g.DrawString("Target", drawFont, drawBrush, 115, 200);
            g.DrawString("Congratulations Mr.Theodoreopulus!", drawFont, drawBrush, 250, 200);
            g.DrawString("From: Quintin", drawFont, drawBrush, 350, 90);
            g.DrawEllipse(redpen, 660, 100, 100, 100);
            g.DrawEllipse(redpen, 685, 125, 50, 50);
            g.FillEllipse(redBrush, 685, 125, 50, 50);
            g.DrawString("Target", drawFont, drawBrush, 677, 200);
            


        }

        private void Form1_Click(object sender, EventArgs e)
        {
           // creates the pens and brushes and selects colors of choice
            Graphics g = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            Pen bluepen = new Pen(Color.Blue, 10);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // plays sound
            SoundPlayer player = new SoundPlayer(Properties.Resources.suspense);
            player.Play();

            for (int x = 1; x <= 28; x++)
            {
                // moves the drawings to meet in the middle
                g.Clear(Color.Black);
                g.DrawEllipse(bluepen, 100 + x * 10, 100, 100, 100);
                g.DrawEllipse(redpen, 125 + x * 10, 125, 50, 50);
                g.FillEllipse(redBrush, 125 + x * 10, 125, 50, 50);
                g.DrawString("Target", drawFont, drawBrush, 115, 200);
                g.DrawString("Congratulations Mr.Theodoreopulus!", drawFont, drawBrush, 250, 200);
                g.DrawString("From: Quintin", drawFont, drawBrush, 350, 90);
                g.DrawEllipse(bluepen, 660 - x * 10, 100, 100, 100);
                g.DrawEllipse(redpen, 685 - x * 10, 125, 50, 50);
                g.FillEllipse(redBrush, 685 - x * 10, 125, 50, 50);
                g.DrawString("Target", drawFont, drawBrush, 677, 200);
                Thread.Sleep(200);
                Refresh();
            }

            // plays sound
            player = new SoundPlayer(Properties.Resources.punch);
            player.Play();









        }    
    }   

}
