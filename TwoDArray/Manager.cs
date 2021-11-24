using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    public class Manager : Person
    {
        public int numOfEmployees;
        public int numOfDepartments;


        public Manager(string fullName, int age, string phone, int numOfDepartments, int numOfEmployees) : base(fullName, age, phone)
        {

            this.numOfEmployees = numOfEmployees;
            this.numOfDepartments = numOfDepartments;
        }

        public void EmployeeSalary()
        {

            int[,] department = new int[this.numOfDepartments, this.numOfEmployees];

            Random Random = new Random();
            for (int i = 0; i < department.GetLength(0); i++)
            {
                for (int j = 0; j < department.GetLength(1); j++)
                {
                    department[i, j] = Random.Next(5000, 10000);

                    Console.Write($"[{department[i, j]}]");
                }
                Console.WriteLine();
            };


        }
    }
}
