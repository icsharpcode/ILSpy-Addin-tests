using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Newtonsoft.Json.JsonConvert.SerializeObject(new List<string>());
            var class1 = new Class1();
            Console.WriteLine("Hello World!");
        }
    }
}
