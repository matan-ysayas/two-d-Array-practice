using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    internal class Building
    {
        public int floor;
        public int apartment;
        
      public Building(int floor,int apartment)
        {
            this.floor = floor; 
            this.apartment = apartment;
        }
        
        public void Build()
        {
           
            int[,] Building = new int[this.floor,this.apartment ];

            Random Random = new Random();
            for (int i = 0; i < Building.GetLength(0); i++)
            {
                for (int j = 0; j < Building.GetLength(1); j++)
                {
                    Building[i, j] = Random.Next(10);

                    Console.Write($"[{Building[i,j]}]");
                }
                Console.WriteLine();
            };


        }


    }
}
