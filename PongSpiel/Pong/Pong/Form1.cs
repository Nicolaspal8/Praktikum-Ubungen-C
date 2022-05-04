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

        int width;
        int height;
        private int y;
        private int x;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void move(object sender, KeyEventArgs e)
        {
            y = this.Size.Height;
            switch(e.KeyData)
            {
                
                case Keys.W:
                    if (player1.Top > 0)
                    {
                        player1.Top -= 5;
                    }
                    break;
                case Keys.S:
                    if (player1.Top < y)
                    {
                        player1.Top += 5;
                    }
                    break;
                case Keys.Up:
                    player2.Top -= 5;
                    break;
                case Keys.Down:
                    player2.Top += 5;
                    break;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (x < width)
            {
                Ball.Left += 8;
            }
            if( x > width)
            {
                Ball.Left -= 8;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            y = Ball.Top;
            x = Ball.Left;
            height = this.Size.Height;
            width = this.Size.Width;
        }
    }
}
