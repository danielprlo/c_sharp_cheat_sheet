using System;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    //Enums must go in the same namespace
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            enums();
        }

        static void enums()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine("Printing method enum {0}", method);
            
            var methodVal = (int)method;
            Console.WriteLine("Printig method int {0}", methodVal);

            var methodId = 3;
            ShippingMethod methodValFromInt = (ShippingMethod)methodId;
            Console.WriteLine("Printing method from int {0} -> {1}", methodId, methodValFromInt);

            var methodName = "Express";
            var shippingMehtod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


        }

        static void arrays()
        {
            //Size of arrays must be specified 
            int[] numbers = new int[3];
            
            //Non-explicit declaration
            var numbers2 = new int[3];

            //Declare filled array
            var names = new String[3] { "Jack", "John", "Mary" };
            var filledNumbers = new[] { 1, 2, 3, 4, 5, 6 };

            // Check lenght
            Console.WriteLine("Array lenght {0}", filledNumbers.Length);

            // Index of element
            Console.WriteLine("Index of value 4: {0}",Array.IndexOf(filledNumbers, 4));

            // Clear array values
            Array.Clear(filledNumbers, 0, 2);
            Console.WriteLine("Cleared array from 0 to 2: {0}", filledNumbers);

            // Copy array
            Array.Copy(numbers, filledNumbers, 3);

            // Sort
            Array.Sort(filledNumbers);

            // Reversedd
            Array.Reverse(filledNumbers);

        }
        static void classes()
        {
            Person p = new Person();
            p.FirstName = "Dani";
            p.LastName = "Perez";
            p.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(1, 2);
            Console.WriteLine("Result of adding {0} ad {1} = {2}", 1, 2, result);
        }
        static void typeConversions()
        {
            // cast conversion for compatible types
            int i = 1;
            float b = (float)i;

            Console.WriteLine("Casting int i {0} to float b {1}", i, b);
            
            // parsing
            string str = "true";
            bool bo = Convert.ToBoolean(str);
            Console.WriteLine("Casting string {0} to bool  {1}", str, bo);
        }
        static void variablesConstants()
        {
            //Explicit declaration
            byte byteVal     = 2;
            int intVal       = 10;
            float floatVal   = 20.2f;
            char charVal     = 'a';
            string stringVal = "Dani";
            bool boolVal     = false;

            //Non-explicit declaration
            var byteVar      = 2;
            var intVar       = 10;
            var floatVar     = 20.2f;
            var charVar      = 'a';
            var stringVar    = "Dani";
            var boolVar      = false;

            //Constante declaration
            const float PI = 3.14f;
        }
    }
}
