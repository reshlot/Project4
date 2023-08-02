using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Peoject4
{
    public  class Subject:Student
    {
        public string subject_code;
        public override void gets()
        {
            Console.WriteLine("*** subject details***\n");
            Console.WriteLine("Enter the subject name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the subject code");
            subject_code = Console.ReadLine();

        }
        public override void prints()
        {
            Console.WriteLine(":) Print the Subject details:)  \n");
            Console.WriteLine(name);
            Console.WriteLine(subject_code);

        }
    }
}

