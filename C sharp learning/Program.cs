using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {

            string str = " ";
            string str1 = "Hello";
            string test = "HellO WorLD";
            string test1 = "Hello, Ayrat, Liora, Love";
            Console.Write("Functions for Lines:\n\n" + str1);
            Console.WriteLine("Verificed is Null: " + String.IsNullOrWhiteSpace(str));
            Console.WriteLine("Output Line: " + str1);
            Console.WriteLine("Lenght is Line: " + str1.Length);
            Console.WriteLine("Compare with Lines: " + String.Compare(str, str1)); //вернет -1, т.к str < str1
            Console.WriteLine("Line Lower:  " + test.ToLower());
            Console.WriteLine("Line Upper:  " + test.ToUpper());
            Console.WriteLine("Have text or no:  " + str1.Contains("He")+ " | " + "Swap: " + str1.Contains("He1"));
            Console.WriteLine("Insert symbol: " + str1.Insert(1, "e"));
            Console.WriteLine("Remove Line: " + test.Remove(0,6));
            Console.WriteLine("Replace Line: " + str1.Replace("ll", "xyu"));

            Console.WriteLine("____________________\n");

            char[] sym = test.ToCharArray();
            for(int i = 0; i < sym.Length; i++)
            Console.Write(sym[i]);

            Console.WriteLine("\n\n____________________");

            string[] clubs = test1.Split(',');
            for(int i = 0;i < clubs.Length;i++)
                Console.Write(clubs[i] + "," );

            Console.ReadKey();
        }
    }
}
