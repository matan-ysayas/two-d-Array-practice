using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    public class Chocolate
    {
        public int row;
        public int line;


        public Chocolate(int row, int line)
        {
            this.row = row;
            this.line = line;
        }


        public void ChocolateBox()
        {
            int[,] ChocolateBoxArray = new int[this.row, this.line];
            Random Random = new Random();
            for (int i = 0; i < ChocolateBoxArray.GetLength(0); i++)
            {
                for (int j = 0; j < ChocolateBoxArray.GetLength(1); j++)
                {
                    ChocolateBoxArray[i, j] = Random.Next(100);
                    Console.Write($"[{ChocolateBoxArray[i, j]}]");

                }
                Console.WriteLine();
            }
        }



        public void ChocolateBoxOver55()
        {
            int[,] ChocolateBoxArray = new int[this.row, this.line];
            Random Random = new Random();
            for (int i = 0; i < ChocolateBoxArray.GetLength(0); i++)
            {
                for (int j = 0; j < ChocolateBoxArray.GetLength(1); j++)
                {
                    ChocolateBoxArray[i, j] = Random.Next(100);
                    if (ChocolateBoxArray[i, j] > 55)
                    {
                        Console.Write($"[{ChocolateBoxArray[i, j]}]");
                    }
                    else
                    {
                        Console.Write("milk");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
