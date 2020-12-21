using System;
using ConsoleApp1.Math;
using System.Collections.Generic;

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
            dateTimes();
        }

        static void timeSpan()
        {
            // Declaring
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            // Properties
            var minutes = timeSpan.Minutes;

            // Add
            timeSpan.Add(TimeSpan.FromMinutes(8));

            // to string
            timeSpan.ToString();
            TimeSpan.Parse("01:02:03");
        }

        static void dateTimes()
        {
            var dateTime = new DateTime(2020, 2, 22);
            Console.WriteLine("Datetime from specific time {0}", dateTime);
            
            var now = DateTime.Now;
            Console.WriteLine("Datetime.Now {0}", now);
            
            //Today just returns the date, without hh:mm:ss
            var today = DateTime.Today;
            Console.WriteLine("Datetime.Today {0}", today);

            //Access values
            var hour = now.Hour;
            var min = now.Minute;
            var sec = now.Second;

            //Addd time to datetime
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tomorrow long date {0}", tomorrow.ToLongDateString());
            Console.WriteLine("Tomorrow long time {0}", tomorrow.ToLongTimeString());
            Console.WriteLine("Yesterday short date {0}", yesterday.ToShortDateString());
            Console.WriteLine("Yesterday short time {0}", yesterday.ToShortTimeString());
            Console.WriteLine("Tomorrow toString {0}", tomorrow.ToString());
            Console.WriteLine("Tomorrow with format {0}", tomorrow.ToString("yyyy-MM-dd"));
        }

        static void lists()
        {
            // Declaration
            var numbers = new List<int>();
            
            // Filled declaration
            var filledNumebrs = new List<int> { 1, 2, 3, 4, 5 };
            
            // Add elements
            filledNumebrs.Add(1);
            filledNumebrs.AddRange(new int[3] { 7, 8, 9 });

            // Index of
            filledNumebrs.IndexOf(1); //first occurance of 1

            // Last index of
            filledNumebrs.LastIndexOf(1); //last occurance of 1

            // Count
            var totalElements = filledNumebrs.Count;

            // Remove elemtn
            filledNumebrs.Remove(1); //Will remove the first occurance of 1
            filledNumebrs.RemoveAt(2); //Remove element by position

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

            //Declare matrix
            var matrix = new int[3,5];

            //Declare dynamic size matrix
            var dynMatrix = new int[3][];
            dynMatrix[0] = new int[5];
            dynMatrix[0] = new int[2];
            dynMatrix[0] = new int[8];

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
