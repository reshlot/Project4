using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Peoject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Simple OOP based system for storing information about teachers, students, and subjects \n");
            Student s = new Student();
            s.gets();
            s.prints();
            s = new Teacher();
            s.gets();
            s.prints();
            s = new Subject();
            s.gets();
            s.prints();
            Console.WriteLine(":) :) Thank You :) :)");

            Console.ReadKey();
        }
    }
}
    

