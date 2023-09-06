using System;

namespace _1Uzduotis_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("_____________________________________________________________");

                Console.WriteLine("Iveskite pirma skaiciu: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Iveskite antra skaiciu: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Iveskite simboli: ( + , - , * , / , Pow , Sqrt , q - quit) ");
                string symbol = Console.ReadLine();
               

                switch (symbol)
                {
                    case "+":
                        Console.WriteLine("Rezultatas: " + Add(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Rezultatas: " + Minus(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Rezultatas: " + Mult(num1, num2));
                        break;
                    case "/":
                        Console.WriteLine("Rezultatas: " + Div(num1, num2));
                        break;
                    case "Pow":
                        Console.WriteLine("Rezultatas: " + Pow(num1, num2));
                        break;
                    case "Sqrt":
                        Console.WriteLine("Rezultatas: " + Sqrt(num1, num2));
                        break;
                    case "q":
                        return;
                    default:
                        Console.WriteLine("Klaida");
                        break;
                }
            }
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Minus(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Pow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        public static double Sqrt(double num1, double num2)
        {
            return Math.Sqrt(num1);
         
        }
    }
}









