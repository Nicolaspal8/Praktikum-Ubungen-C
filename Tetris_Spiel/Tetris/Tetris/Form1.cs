using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private int PX;
        private readonly int[,] F = new int[15, 10];
        private int PZ, PS;
        private int Stufe;
        private readonly List<Panel> PL = new();
        private readonly Color[] FarbenFeld = { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Cyan, Color.Magenta, Color.Black, Color.White };
        private const int Leer = -1;
        private const int Rand = -2;
        private readonly Random r = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int Z = 1; Z < 14; Z++)
            {
                F[Z, 0] = Rand;
                for (int S = 1; S < 9; S++)
                {
                    F[Z, S] = Leer;
                    F[Z, 9] = Rand;
                }
                for (int S = 0; S < 10; S++)
                {
                    Stufe = 1;
                    NaechstesPanel();
                }
            }
        }

        private void NaechstesPanel()
        {
            int Farbe;
            Panel p = new();
            Panel p2 = new();
            Panel p3 = new();
            for (int i = 1; i < 4; i++)
            {
            PL.Add(p);
            p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            p.Location = new Point(CmdUnten.Left + 25, 84);
            p.Size = new Size(20, 20);
            Farbe = r.Next(0, 8);
            p.BackColor = FarbenFeld[Farbe];
            Controls.Add(p);

            }
            PX = PL.Count - 1;
            PZ = 1;
            PS = 5;
        }

        private void TimTetris_Tick(object sender, EventArgs e)
        {
            if ((F[PZ + 1, PS]) != Leer)
            {
                if (PZ == 1)
                {
                    TimTetris.Enabled = false;
                    MessageBox.Show("Das war's");
                    return;
                }
                F[PZ, PS] = PX;
                AllePruefen();
                NaechstesPanel();
            }
            else
            {
                PL[PX].Location = new Point(PL[PX].Location.X, PL[PX].Location.Y + 20);
                PZ += 1;
            }
        }

        private void AllePruefen()
        {
            bool Neben = false, Ueber = false;

            for (int Z = 13; Z > 0; Z--)
            {
                for (int S = 1; S < 7; S++)
                {
                    Neben = NebenPruefen(Z, S);
                    if (Neben) break;
                }
                if (Neben) break;
            }

            for (int Z = 13; Z > 2; Z--)
            {
                for (int S = 1; S < 9; S++)
                {
                    Ueber = UeberPruefen(Z, S);
                    if (Ueber) break;
                }
                if (Ueber) break;
            }

            if (Neben || Ueber)
            {
                Stufe += 1;
                TimTetris.Interval = 5000 / (Stufe + 9);
                AllePruefen();
            }
        }

        private bool NebenPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if (F[Z, S] != Leer && F[Z, S + 1] != Leer && F[Z, S + 2] != Leer)
            {
                if (PL[F[Z, S]].BackColor == PL[F[Z, S + 1]].BackColor && PL[F[Z, S]].BackColor == PL[F[Z, S + 2]].BackColor)
                {
                    for (int SX = S; SX < S + 3; SX++)
                    {
                        Controls.Remove(PL[F[Z, SX]]);
                        F[Z, SX] = Leer;
                        int ZX = Z - 1;
                        while (F[ZX, SX] != Leer)
                        {
                            PL[F[ZX, SX]].Location = new Point(PL[F[ZX, SX]].Location.X, PL[F[ZX, SX]].Location.Y + 20);
                            F[ZX + 1, SX] = F[ZX, SX];
                            F[ZX, SX] = Leer;
                            ZX -= 1;
                        }
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }

        private bool UeberPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if (F[Z, S] != Leer && F[Z - 1, S] != Leer && F[Z - 2, S] != Leer)
            {
                if (PL[F[Z, S]].BackColor == PL[F[Z - 1, S]].BackColor && PL[F[Z, S]].BackColor == PL[F[Z - 2, S]].BackColor)
                {
                    for (int ZX = Z; ZX > Z - 3; ZX--)
                    {
                        Controls.Remove(PL[F[ZX, S]]);
                        F[ZX, S] = Leer;
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }

        private void CmdLinks_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS - 1] == Leer)
            {
                PL[PX].Location = new Point(PL[PX].Location.X - 20, PL[PX].Location.Y);
                PS -= 1;
            }
        }

        private void CmdRechts_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS + 1] == Leer)
            {
                PL[PX].Location = new Point(PL[PX].Location.X + 20, PL[PX].Location.Y);
                PS += 1;
            }
        }

        private void CmdUnten_Click(object sender, EventArgs e)
        {
            while (F[PZ + 1, PS] == Leer)
            {
                PL[PX].Location = new Point(PL[PX].Location.X, PL[PX].Location.Y + 20);
                PZ += 1;
            }
            F[PZ, PS] = PX;
            AllePruefen();
            NaechstesPanel();
        }

        private void CmdPause_Click(object sender, EventArgs e)
        {
            TimTetris.Enabled = !TimTetris.Enabled;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    CmdLinks_Click(sender, e);
                    break;
            }
        }
    }
}
