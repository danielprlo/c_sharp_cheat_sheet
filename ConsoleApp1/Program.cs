using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void variablesConstants()
        {
            //Explicit declaration
            byte byteVal = 2;
            int intVal = 10;
            float floatVal = 20.2f;
            char charVal = 'a';
            string stringVal = "Dani";
            bool boolVal = false;

            //Non-explicit declaration
            var byteVar = 2;
            var intVar = 10;
            var floatVar = 20.2f;
            var charVar = 'a';
            var stringVar = "Dani";
            var boolVar = false;
        }
    }
}
