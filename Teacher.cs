using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace Peoject4
{
    public  class Teacher:Student
    {
        public string subject;
        public override void gets()
        {
            Console.WriteLine("*** Teacher details***\n");
            Console.WriteLine("Enter the Teacher name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the section");
            section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the subject");
            subject = Console.ReadLine();
        }
        public override void prints()
        {
            Console.WriteLine(":)Print the Teacher  details :) \n");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
            Console.WriteLine(subject);
        }
    }
}

