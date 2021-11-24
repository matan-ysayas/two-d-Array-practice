
namespace TwoDArray
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            int[,] numsArray = new int[3, 6];

            //for (int i = 0; i < numsArray.GetLength(0); i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int j = 0; j < numsArray.GetLength(1); j++)
            //{
            //    Console.WriteLine(j);
            //}

            //for (int i = 0; i < numsArray.GetLength(0); i++)
            //{
            //    Console.Write($"i:{i} ");
            //    for (int j = 0; j < numsArray.GetLength(1); j++)
            //    {
            //        Console.Write($"j:{j}|");
            //    }
            //    Console.WriteLine();
            //}



            //GetNum(numsArray);

            //AddNum(numsArray);

            //MultieNum(numsArray);

            //RandomNum(numsArray);


            //PrintArray(numsArray);

            //*13**

            //Teacher[,] MyTeachers = new Teacher[,]
            //{

            //    {new Teacher(5),new Teacher(25) },
            //    {new Teacher(50),new Teacher(18) }
            //};

            // for(int i = 0; i < MyTeachers.GetLength(0); i++)
            //{
            //    for(int j = 0;j<MyTeachers.GetLength(1); j++)
            //    {
            //        if (MyTeachers[i,j].age > 25)
            //        {
            //            Console.WriteLine(MyTeachers[i,j].age);
            //        }
            //    }
            //}

            //**14**

            // int[,] MyArray = new int[6, 4];
            // MyArray[5, 3] = 8;

            //for (int i = 0; i < MyArray.GetLength(0); i++)
            // {
            //     for(int j = 0; j < MyArray.GetLength(1);j++)
            //     {
            //         Console.WriteLine(MyArray[i,j]);
            //     }
            // };



            // Random NumRandom = new Random();
            // for (int i = 0; i < MyArray.GetLength(0); i++)
            // {
            //     for (int j = 0; j < MyArray.GetLength(1); j++)
            //     {
            //         MyArray[i, j] = NumRandom.Next(100);

            //     }

            // };


            // for(int i = 0;i < MyArray.GetLength(0); i++)
            // {
            //     Console.Write($"line:{i}-");
            //     for(int j=0;j< MyArray.GetLength(1); j++) {
            //         Console.Write($"|{MyArray[i,j]}|,");

            //     }
            //     Console.WriteLine();
            // }


            //**15**
            //int[,] Building = new int[4, 3];


            //Random Random = new Random();
            //for (int i = 0; i < Building.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Building.GetLength(1); j++)
            //    {
            //        Building[i, j] = Random.Next(10);

            //    }

            //};


            //for (int i = 0; i < Building.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Building.GetLength(1); j++)
            //    {
            //        Console.WriteLine(Building[i, j]);

            //    }

            //}

            //for (int i = 0; i < Building.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Building.GetLength(1); j++)
            //    {
            //        if (Building[i, j] % 2 == 0)
            //        {
            //            Console.WriteLine(Building[i, j]);
            //        }
            //        else { Console.WriteLine("odd"); }


            //    }

            //}

            //**16**


            //Building myBuild = new Building(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            //myBuild.Build();



            //**17**

            //Chocolate myChocolateBox = new Chocolate(5, 10);

            //myChocolateBox.ChocolateBox();

            //myChocolateBox.ChocolateBoxOver55();


            //**18**

            //Person myPerson = new Person("MATAN YSAYAS", 25, "085164545");

            //myPerson.PrintDetails();

            //Employee myEmployee = new Employee("MAT", 55, "588778757", "softwer");

            //myEmployee.PrintDetails();

            //Employee userEmployee = new Employee(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());

            //userEmployee.PrintDetails();
            //

            Manager myManager = new Manager(Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            myManager.EmployeeSalary();



        }


        //**5**
        static void GetNum(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                Console.Write($"i:{i} ");
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write($"j:{j}|");
                }
                Console.WriteLine();
            }
        }

        //**6**
        static void AddNum(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {

                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = j;

                }

            }
        }

        //**7**
        static void MultieNum(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = i * j;

                }

            }
        }

        //**8**

        static void RandomNum(int[,] someArray)
        {
            Random random = new Random();
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    someArray[i, j] = random.Next(100);

                }

            }
        }

        //**9**

        static void PrintArray(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                Console.Write($"i:{i}=> ");
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write($"j:{j}|");
                }
                Console.WriteLine();
            }
        }

        //**10**
        static void PrintPostiveNum(int[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    if (someArray[i, j] % 2 == 0)
                    {
                        Console.WriteLine(someArray[i, j]);
                    }
                }
            }
        }
        //**11**

        static void PrintOnlyLongName(string[,] someArray)
        {
            for (int i = 0; i < someArray.GetLength(0); i++)
            {
                for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    if (someArray[i, j].Length > 4)
                    {
                        Console.WriteLine(someArray[i, j]);
                    }
                }
            }
        }


  
    
    
    
    
    }

}










