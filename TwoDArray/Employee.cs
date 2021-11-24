using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
    internal class Employee : Person
    {
      public  string department;

      public  Employee(string fullName, int age, string phone ,string department) : base(fullName, age, phone)
        {
          this.department = department;
        }


        public override void PrintDetails()
        {
            Console.WriteLine($" full name:{this.fullName}");
            Console.WriteLine($" age:{this.age}");
            Console.WriteLine($" Phone:{this.phone}");
            Console.WriteLine($" department:{this.department}" );
        }
    }
    
}
