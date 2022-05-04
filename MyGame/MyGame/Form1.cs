using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
	public partial class Form1 : Form
	{
		
		Timer timer1 = new Timer();
		Image background = Image.FromFile(@"C:\Users\Schulung\Desktop\MyGame\MyGame\background.png");
		Image mensch = Image.FromFile("mensch.png");
		int x;
		int y = 40;


		public Form1()
		{
			Text = "Bewegter Mensch";
			Size = new Size(1200, 900);
			MaximizeBox = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;

			CenterToScreen();

			Paint += new PaintEventHandler(OnPaint);
			timer1.Interval = 5;
			timer1.Tick += new EventHandler(Ticker);
			timer1.Start();

			//Double-Buffer aktivieren um Flickern zu verhindern
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			this.KeyDown += Form1_KeyDown;
			this.Load += Form1_Load;
			this.MouseClick += Form1_MouseClick;
		}

		void Ticker(object sender, EventArgs e)
		{
			if (x < Width)
				x += 1;
			else
				x = -100;
			if(y > Height)
            {
				y -= Height;
            }

            Invalidate();
        }
		void OnPaint(Object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			
			DrawStuff(g);
		}
		void DrawStuff(Graphics g)
		{
			g.DrawImage(background, 200, 200);
			g.DrawImage(mensch, x, y);
		}
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
				case Keys.Up:
					y -= 5;
					break;
				case Keys.Down:
					y += 5;
					break;
				case Keys.Left:
					x -= 10;
					break;
				case Keys.Right:
					x += 5;
					break;
				case Keys.Space:
					background = Image.FromFile(@"C:\Users\Schulung\Desktop\MyGame\MyGame\pgx.png");
					break;
				case Keys.X:
					background = Image.FromFile("background.png");
					break;
				case Keys.P:
					timer1.Stop();
					break;
				case Keys.E:
					timer1.Start();
					break;
				case Keys.R:
					mensch.RotateFlip(RotateFlipType.Rotate90FlipY);
					break;
				default:
					break;
			}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
		
		}
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
			x = e.X;
			y = e.Y;
		}
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
