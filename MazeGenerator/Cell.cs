using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    class Cell
    {
        private int x;
        private int y;
        private bool[] walls = { true, true, true, true };
        private bool visitado = false;
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public Cell (int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool[] Walls
        {
            get { return walls; }
            set { walls = value; }
        }

        public bool Visitado
        {
            get { return visitado; }
            set { visitado = value; }
        }

        public void Show(float width,float height, Graphics g)
        {
            float x = (this.x) * width;
            float y = (this.y) * height;

            

            if (walls[0])
                g.DrawLine(new Pen(Color.Black), x, y, x + width, y);
            if (walls[1])
                g.DrawLine(new Pen(Color.Black), x + width, y, x + width, y + height);
            if (walls[2])
                g.DrawLine(new Pen(Color.Black), x, y + height, x + width, y + height);
            if (walls[3])
                g.DrawLine(new Pen(Color.Black), x, y, x, y + height);
        }

    }
}
