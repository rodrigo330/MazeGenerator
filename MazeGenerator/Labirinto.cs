using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGenerator
{
    class Labirinto
    {
        Cell[] grid;
        Cell current;
        Stack<Cell> pilha;
        Cell aux;
        int rows;
        int columns;
        int speed;
        PictureBox MazeBox;
        Bitmap b;
        Graphics g;
        Point inicio;
        Point fim;

        public void GenerateMaze(int rows,int columns, Bitmap b,Graphics g, PictureBox MazeBox,int speed, Point inicio,Point fim)
        {
            this.MazeBox = MazeBox;
            this.b = b;
            this.g = g;
            this.speed = speed;
            this.columns = columns;
            this.rows = rows;
            this.inicio = inicio;
            this.fim = fim;
            pilha = new Stack<Cell>();
            grid = new Cell[columns * rows];
            FillGrid();//fill the grid with cells
            StartingPoint();
            DrawMaze();
            RecursiveBacktracking();

        }
        public Cell EmVolta()
        {
            Random rnd = new Random();
            int aux;
            int count=0;
            Cell[] visinhos = new Cell[4];
            if (current.Y-1 >= 0)
                if(!grid[columns*(current.Y-1)+current.X].Visitado)
                    visinhos[count++] = grid[columns * (current.Y - 1) + current.X];
            if (current.X + 1 < columns)
                if(!grid[columns * current.Y + current.X+1].Visitado)
                    visinhos[count++] = grid[columns * current.Y + current.X + 1];
            if (current.Y + 1 < rows)
                if(!grid[columns * (current.Y + 1) + current.X].Visitado)
                    visinhos[count++] = grid[columns * (current.Y + 1) + current.X];
            if (current.X - 1 >= 0)
                if(!grid[columns * current.Y + current.X - 1].Visitado)
                    visinhos[count++] = grid[columns * current.Y + current.X - 1];
            if(count != 0)
            {
                aux = rnd.Next(0, count);

                if (current.Y - 1 >= 0 && current.Y > visinhos[aux].Y)
                {
                    current.Walls[0] = false;
                    grid[columns * (visinhos[aux].Y) + visinhos[aux].X].Walls[2] = false;
                }
                if (current.X + 1 < columns && current.X < visinhos[aux].X)
                {
                    current.Walls[1] = false;
                    grid[columns * (visinhos[aux].Y) + visinhos[aux].X].Walls[3] = false;
                }
                if (current.Y + 1 < rows && current.Y < visinhos[aux].Y)
                {
                    current.Walls[2] = false;
                    grid[columns * (visinhos[aux].Y) + visinhos[aux].X].Walls[0] = false;
                }
                if (current.X >= 0 && current.X > visinhos[aux].X)
                {
                    current.Walls[3] = false;
                    grid[columns * (visinhos[aux].Y) + visinhos[aux].X].Walls[1] = false;
                }

                grid[columns * visinhos[aux].Y + visinhos[aux].X].Visitado = true;
                return grid[columns * visinhos[aux].Y + visinhos[aux].X];
            }
                
            return current;
        }
        public void FillGrid()
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    grid[i * columns + j] = new Cell(j, i);
                }
        }
        public void StartingPoint()
        {
            pilha.Push(grid[columns * inicio.Y + inicio.X]);//ponto de inicio
            grid[columns * inicio.Y + inicio.X].Visitado = true;
        }
        public void DrawMaze()
        {
            g.FillRectangle(Brushes.White, 0, 0, 800, 400);
            if (pilha.Count != 0)
                g.FillRectangle(Brushes.Aquamarine, pilha.Peek().X * 800 / columns, pilha.Peek().Y * 400 / rows, 800 / columns, 400 / rows);
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i].Show(800 / columns, 400 / rows, g);
            }
            g.FillRectangle(Brushes.Green, inicio.X * (800 / columns) + (800 / columns) / 8, inicio.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);
            g.FillRectangle(Brushes.Red, fim.X * (800 / columns) + (800 / columns) / 8, fim.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);
            Thread.Sleep(speed);
            MazeBox.Refresh();
        }
        public void RecursiveBacktracking()
        {
            if (pilha.Count != 0)
            {
                current = pilha.Peek();
                aux = EmVolta();
                if (aux.X == current.X && aux.Y == current.Y)
                    pilha.Pop();
                else
                {
                    current = aux;
                    pilha.Push(aux);
                }
                DrawMaze();
                RecursiveBacktracking();
            }
            else
                SolveMaze();
        }
        public void SolveMaze()
        {
            grid[columns * inicio.Y + inicio.X].Number = 1;
            Queue<Cell> fila = new Queue<Cell>();
            fila.Enqueue(grid[columns * inicio.Y + inicio.X]);
            while (current.X != fim.X || current.Y != fim.Y)
            {
                current = fila.Dequeue();
                if(current.Y-1 >= 0 && !current.Walls[0] && grid[(columns * (current.Y - 1)) + current.X].Number == 0)
                {
                    grid[(columns * (current.Y - 1)) + current.X].Number = current.Number + 1;
                    fila.Enqueue(grid[(columns * (current.Y - 1)) + current.X]);
                }
                if (current.X + 1 < columns && !current.Walls[1] && grid[(columns * current.Y) + current.X + 1].Number == 0)
                {
                    grid[columns * current.Y + current.X + 1].Number = current.Number + 1;
                    fila.Enqueue(grid[columns * current.Y + current.X + 1]);
                }
                if (current.Y + 1 < rows && !current.Walls[2] && grid[(columns * (current.Y + 1)) + current.X].Number == 0)
                {
                    grid[(columns * (current.Y + 1)) + current.X].Number = current.Number + 1;
                    fila.Enqueue(grid[(columns * (current.Y + 1)) + current.X]);
                }
                if (current.X - 1 >= 0 && !current.Walls[3] && grid[(columns * current.Y) + current.X - 1].Number == 0)
                {
                    grid[columns * current.Y + current.X - 1].Number = current.Number + 1;
                    fila.Enqueue(grid[columns * current.Y + current.X - 1]);
                }
            }
            current = grid[columns * fim.Y + fim.X];
            while(current.X != inicio.X || current.Y != inicio.Y)
            {
                g.FillRectangle(Brushes.Aquamarine, current.X * (800 / columns) + (800 / columns) / 8, current.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);


                if (current.Y - 1 >= 0 && grid[(columns * (current.Y - 1)) + current.X].Number == current.Number -1)
                {
                    current = grid[(columns * (current.Y - 1)) + current.X];
                }
                else if (current.X + 1 <= columns - 1 && grid[columns * current.Y + current.X + 1].Number == current.Number - 1)
                {
                    current = grid[columns * current.Y + current.X + 1];
                }
                else if (current.Y + 1 <= rows - 1 && grid[(columns * (current.Y + 1)) + current.X].Number == current.Number - 1)
                {
                    current = grid[(columns * (current.Y + 1)) + current.X];
                }
                else
                {
                    current = grid[columns * current.Y + current.X - 1];
                }

            }
            g.FillRectangle(Brushes.Red, fim.X * (800 / columns) + (800 / columns) / 8, fim.Y * (400 / rows) + (800 / columns) / 8, 800 / columns - (800 / columns) / 4, 400 / rows - (800 / columns) / 4);
            MazeBox.Refresh();
        }

    }
}
