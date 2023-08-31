using System;
using System.IO;

namespace GameOfLife
{
    public class FileManager
    {
        public bool[,] LoadBoard(string filename)
        {
            string content = File.ReadAllText(@"C:\Users\Rodrigo\Documents\GitHub\GameOfLifeTeam9\assets\board.txt");
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                    else
                    {
                        board[x, y] = false;
                    }
                }
            }
            return board;
        }
    }
}
