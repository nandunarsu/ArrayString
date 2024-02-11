using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class Compare
    {
        public void Comparemethod()
        {
            Console.WriteLine("Enter the first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the first string");
            string str2 = Console.ReadLine();

            int value = str1.CompareTo(str2);

            switch (value)
            {
                case 0:
                    Console.WriteLine("Both strings are same");
                    break;
                case 1:
                    Console.WriteLine("Second string is null");
                    break;
                case -1:
                    Console.WriteLine("Two strings are different");
                    break;
            }

           string con1 = str1 + str2;
           string con = string.Concat(str1,str2);
            Console.WriteLine("using concat method "+con);
            Console.WriteLine("using add method " + con1);


        }
    }
}
