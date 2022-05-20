//EXERCISE 1
//Get inputs from user and convert it into:
//1.Integer
//a.Use int.parse
//b.Use Convert.ToInt
//c.Use int.TryParse
//2. Float - Try different methods to do it
//3. Boolean - Try different methods to do it



using System;

namespace Assignment1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Convert the numbers into integer format using int.parse and convert it to integer");
            
            Console.WriteLine("Enter any number : ");
            bool check;
            int x;
            string num3 = Console.ReadLine();
            check = int.TryParse(num3, out x);
            Console.WriteLine(check);
            Console.Write("Converted the number to integer format using int.tryparse");

            float y = num1;
            Console.WriteLine("The float value of integer is :", + y);
            Console.Write("Converted in float");

            float z = (float)num1;
            Console.WriteLine(z);
            Console.WriteLine("Conversion of Bool form");

            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            name = "true";
            bool value = Convert.ToBoolean(name);
            Console.WriteLine(value);

            Console.WriteLine("Enter your last name : ");
            string lastname = Console.ReadLine();
            name = "true";
            Boolean cost;
            if(Boolean.TryParse(lastname,out cost))
            {
                Console.WriteLine(cost);
            }
        }
    }
}
