using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoject4
{
    
    public  class Student
    {
        public string name;
        public int classes;
        public char section;

        public virtual void gets()
        {
            Console.WriteLine("*** Student details***\n");
            Console.WriteLine("Enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the section");
            section = Convert.ToChar(Console.ReadLine());
        }
        public virtual void prints()
        {
            Console.WriteLine(" :) Print the Student details :) \n");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
        }
    }
}
