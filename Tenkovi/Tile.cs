using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tenkovi
{
    public enum Type
    {
        Grass,
        Wall,
        Coin
    }
    public class Tile
    {
        public Point Position { get; set; }
        public Type Type { get; set; }

        private int Size = 50;

        public Tile(Point Position)
        {
            this.Position = Position;
            this.Type = Type.Grass;
        }

        public void Draw(Graphics g)
        {
            switch(this.Type)
            {
                case Type.Grass:
                g.FillRectangle(Brushes.DarkGreen, this.Position.X * this.Size, this.Position.Y * this.Size, this.Size, this.Size);
                break;

                case Type.Wall:
                g.FillRectangle(Brushes.Gray, this.Position.X * this.Size, this.Position.Y * this.Size, this.Size, this.Size);
                break;

                case Type.Coin:
                g.FillRectangle(Brushes.DarkGreen, this.Position.X * this.Size, this.Position.Y * this.Size, this.Size, this.Size);
                g.FillEllipse(Brushes.Yellow, this.Position.X * this.Size, this.Position.Y * this.Size, this.Size, this.Size);
                break;
            }
        }
    }
}
