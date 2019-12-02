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

namespace MazeGenerator
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Graphics g;
        int columns = 10;
        int rows = 5;
        Labirinto l = new Labirinto();
        int speed = 1;
        bool ini_bool = false;
        bool fim_bool = false;
        MouseEventArgs me;
        Point inicio;
        Point fim;

        public Form1()
        {
            InitializeComponent();
            b = new Bitmap(MazeBox.Width, MazeBox.Height);
            g = Graphics.FromImage(b);
            MazeBox.Image = b;
            inicio.X = 0; inicio.Y = 0;
            fim.X = columns - 1; fim.Y = rows - 1;
            drawStartingMaze();
        }

        private void GenerateMazeBtn_Click(object sender, EventArgs e)
        {
            l.GenerateMaze(rows, columns, b, g, MazeBox, speed, inicio, fim);
        }

        private void HeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            rows = (int)HeightUpDown.Value;
            fim.Y = rows - 1;
            drawStartingMaze();
        }

        private void LenghtUpDown_ValueChanged(object sender, EventArgs e)
        {
            columns = (int)LenghtUpDown.Value;
            fim.X = columns - 1;
            drawStartingMaze();
        }

        private void MazeBox_Click(object sender, EventArgs e)
        {
            me = (MouseEventArgs)e;

            if(ini_bool)
            {
                inicio = me.Location;
                inicio.X /= 800 / columns;
                inicio.Y /= 400 / rows;
                drawStartingMaze();
            }
            else if(fim_bool)
            {
                fim = me.Location;
                fim.X /= 800 / columns;
                fim.Y /= 400 / rows;
                drawStartingMaze();
            }
            ini_bool = fim_bool = false;
            Inicio_Btn.Enabled = true;
            fim_Btn.Enabled = true;
            GenerateMazeBtn.Enabled = true;
        }

        private void HeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SpeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            speed = (int)SpeedUpDown.Value;
        }

        private void Inicio_Btn_Click(object sender, EventArgs e)
        {
            Inicio_Btn.Enabled = false;
            fim_Btn.Enabled = false;
            GenerateMazeBtn.Enabled = false;

            ini_bool = true;
        }

        private void fim_Btn_Click(object sender, EventArgs e)
        {
            Inicio_Btn.Enabled = false;
            fim_Btn.Enabled = false;
            GenerateMazeBtn.Enabled = false;

            fim_bool = true;
        }

        public void drawStartingMaze()
        {
            g.FillRectangle(Brushes.White, 0, 0, 800, 400);

            Cell aux = new Cell(0,0);

            for(int x = 0; x < columns; x++)
                for (int y = 0; y < rows; y++)
                {
                    aux.X = x;
                    aux.Y = y;

                    aux.Show(800 / columns, 400 / rows, g);
                }
            g.FillRectangle(Brushes.Green, inicio.X * (800 / columns) + (800 / columns) / 8, inicio.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);
            g.FillRectangle(Brushes.Red, fim.X * (800 / columns) + (800 / columns) / 8, fim.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);
            MazeBox.Refresh();
        }
    }
}
