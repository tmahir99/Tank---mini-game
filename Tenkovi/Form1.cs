using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tenkovi
{
    public partial class Form1 : Form
    {
        public Tile[,] Grid = new Tile[10,10];
        public Tank Tank = new Tank(new Point(0, 0));

        public Keys key;

        int coins = 0;

        bool BuildMode = false;
        bool IsGrass = false;

        int CoinCreateInterval = 20;
        int CoinCreateTimer;

        public Form1()
        {
            InitializeComponent();

            InitGrid();

            CoinCreateTimer = CoinCreateInterval;

            GameTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = e.Graphics)
            {
                foreach (Tile t in Grid)
                    t.Draw(g);

                Tank.Draw(g);
            }
        }

        private void MoveTank()
        {
            if(!BuildMode)
            {
                switch (key)
                {
                    case Keys.W:
                        Tank.MoveUp();
                        break;

                    case Keys.S:
                        Tank.MoveDown();
                        break;

                    case Keys.D:
                        Tank.MoveRight();
                        break;

                    case Keys.A:
                        Tank.MoveLeft();
                        break;
                }

                HitBorder();
                HitWall();
                HitCoin();
                CoinCreate();
                label1.Text = "Poeni: " + coins.ToString();
                if(coins == 5)
                {
                    GameTimer.Stop();
                    MessageBox.Show("Pobedili ste");
                    this.Close();
                }
            }
        }

        private void HitBorder()
        {
            //X
            if (Tank.Position.X >= 10)
                Tank.Position = new Point(9, Tank.Position.Y);
            else if (Tank.Position.X <= -1)
                Tank.Position = new Point(0, Tank.Position.Y);

            //Y
            else if (Tank.Position.Y <= -1)
                Tank.Position = new Point(Tank.Position.X, 0);

            else if (Tank.Position.Y >= 10)
                Tank.Position = new Point(Tank.Position.X, 9);
        }

        private void InitGrid()
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Grid[i, j] = new Tile(new Point(i, j));
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MoveTank();

            Refresh();
        }

        private void HitCoin()
        {
            foreach(Tile t in Grid)
            {
                if(Tank.Position == t.Position && t.Type == Type.Coin)
                {
                    coins++;
                    Grid[t.Position.X, t.Position.Y].Type = Type.Grass;
                }
            }
        }

        private void HitWall()
        {
            foreach(Tile t in Grid)
            {
                if (Tank.Position == t.Position && t.Type == Type.Wall)
                {
                    switch(key)
                    {
                        case Keys.W:
                            Tank.Position = new Point(Tank.Position.X, Tank.Position.Y + 1);
                            break;

                        case Keys.S:
                            Tank.Position = new Point(Tank.Position.X, Tank.Position.Y - 1);
                            break;

                        case Keys.A:
                            Tank.Position = new Point(Tank.Position.X + 1, Tank.Position.Y);
                            break;

                        case Keys.D:
                            Tank.Position = new Point(Tank.Position.X - 1, Tank.Position.Y);
                            break;

                    }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (BuildMode && e.X / 50 <= 9 && e.Y / 50 <= 9)
            {
                if(!IsGrass)
                    Grid[e.X / 50, e.Y / 50].Type = Type.Wall;
                else
                    Grid[e.X / 50, e.Y / 50].Type = Type.Grass;
            }
        }

        private void CoinCreate()
        {
            if(CoinCreateTimer == CoinCreateInterval)
            {
                Random rand = new Random();

                int x = rand.Next(0, 10);

                int y = rand.Next(0, 10);

                if (Grid[x, y].Type != Type.Wall)
                {
                    Grid[x, y].Type = Type.Coin;

                    CoinCreateTimer = 0;
                }
            }
            else
            {
                CoinCreateTimer++;
            }
            
        }

        private void gradiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildMode = true;
        }

        private void igrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildMode = false;

        }

        private void travaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsGrass = true;
        }

        private void zidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsGrass = false;
        }
    }
}
