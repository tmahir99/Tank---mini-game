using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenkovi
{
    public class Tank
    {
        public Point Position { get; set; }

        private int Size = 50;

        public Tank(Point Position)
        {
            this.Position = Position;
        }

        public void Draw(Graphics g) => g.FillRectangle(Brushes.DarkRed, this.Position.X * this.Size, this.Position.Y * this.Size, this.Size, this.Size);

        public void MoveUp() => this.Position = new Point(this.Position.X, this.Position.Y - 1);

        public void MoveDown() => this.Position = new Point(this.Position.X, this.Position.Y + 1);

        public void MoveRight() => this.Position = new Point(this.Position.X + 1, this.Position.Y);

        public void MoveLeft() => this.Position = new Point(this.Position.X - 1, this.Position.Y);
    }
}
