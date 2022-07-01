using System;
using System.Collections.Generic;



namespace Test_Writing
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> names = new List<string>();

            names.Add("Jenny");
            names.Add("John");
            names.Add("Jane");

            string firstName = names[0];
            Console.WriteLine(firstName);

        }

    }

}