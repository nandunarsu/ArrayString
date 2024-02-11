using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProject
{
    class ReplaceTrim
    {
        public void ReplaceandTrim()
        {
            //Console.WriteLine("Enter the first string");
            string str1 = " Hello World";
            //Console.WriteLine("Enter the first string");
            //string str2 = Console.ReadLine();

            string str3 = str1.Replace("Hello", "Hi");

            Console.WriteLine("the replaced string is " + str3);
            string str4 = str1.TrimStart();
            Console.WriteLine("Trim" + str4);
            int start = 0, count = 5;
            string str5 = str1.Remove(start, count);
            Console.WriteLine("remove : " +str5);
            string[] str6 = str1.Split();
            foreach (string str in str6)
            {
                Console.WriteLine("Strings split : " + str);
            }
            string str7 = str1.Substring(start, count);
            Console.WriteLine(" Substring : " + str7);
            int str8 = str1.IndexOf("World");
            Console.WriteLine("Index of : " +str8);
            char[] str9 = str1.ToCharArray();
            foreach (char c in str9)
            {
                Console.WriteLine(c);
            }
            string str10 = str1.ToLower();
            Console.WriteLine("Lowe case : " + str10);


        }
    }
}
