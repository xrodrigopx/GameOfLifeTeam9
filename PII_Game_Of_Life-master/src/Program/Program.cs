using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            Board board = new Board(fileManager.LoadBoard(@"C:\Users\rperdomo\Desktop\PII_Game_Of_Life-master\assets\board.txt"));

            board.Print();
        }
    }
}
