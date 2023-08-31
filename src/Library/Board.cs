using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace GameOfLife
{
    public class Board
    {
        private bool[,] _board;
        private int _width;
        private int _height;

        public Board(bool[,] board)
        {
            _board = board;
            _width = board.GetLength(0);
            _height = board.GetLength(1);
        }

        public bool GetCell(int x, int y)
        {
            return _board[x, y];
        }

        public void SetCell(int x, int y, bool value)
        {
            _board[x, y] = value;
        }

        public bool[,] CalculateNextGeneration()
        {
            bool[,] cloneboard = new bool[_width, _height];
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < _width && j >= 0 && j < _height && _board[i, j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if (_board[x, y])
                    {
                        aliveNeighbors--;
                    }
                    if (_board[x, y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x, y] = false;
                    }
                    else if (_board[x, y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x, y] = false;
                    }
                    else if (!_board[x, y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x, y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x, y] = _board[x, y];
                    }
                }
            }
            return cloneboard;
        }

        public void Print()
        {
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    if (_board[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }
    }
}
