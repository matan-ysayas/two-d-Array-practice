using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArray
{
   public class Person
    {
      public  string fullName;
       public int age;
       public string phone; 
        


      public  Person(string fullName,int age,string phone)
        {
            this.fullName = fullName;   
            this.age = age;
            this.phone = phone;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($" full name:{this.fullName}");
            Console.WriteLine($" age:{this.age}");
            Console.WriteLine($" Phone:{this.phone}");



        }
    }

    
}
