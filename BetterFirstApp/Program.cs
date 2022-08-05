using System;
using BetterFirstApp;
using OopsBL;

namespace BetterFirstApp
{
    class Program
    {
        public static void Main()
        {
            Rectangle rh = new Rhombus() { Angle = 30 };
            rh.length = 10;
            rh.breadth = 10;
            //rh.Angle = 30;
            rh.calcArea();
            Rectangle sq = new Square();
            sq.length = 10;
            sq.breadth = 10;
            sq.calcArea();
        }

        private static void SwitchCase()
        {
            object shape = null;
            do
            {
                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "rectangle":
                        shape = new Rectangle(10, 5);
                        //(shape as Rectangle).calcArea();
                        ((Rectangle)shape).calcArea();
                        Console.WriteLine($"Rectangle drawn with area ={((Rectangle)shape).calcArea()}");
                        break;

                    case "square":
                        shape = new Square(5);
                        Console.WriteLine($"Square drawn with area ={((Square)shape).calcArea()}");
                        break;

                    default:
                        throw new Exception("Invalid Shape");
                        break;
                }
            } while (Console.ReadLine().ToLower() != "n");
        }

        private static void NewObjects()
        {
            Rectangle r1 = new Rectangle();
            r1.length = 10;
            r1.breadth = 5;
            Console.WriteLine($"Area of r1 = {r1.calcArea()}");

            Rectangle r2 = new Rectangle();
            //r2.length = 25;
            //r2.breadth = 78;
            Console.WriteLine($"Area of r2 = {r2.calcArea()}");

            Square s1 = new Square(23);
            //s1.Side = 23;
            Console.WriteLine($"Area of s1 = {s1.calcArea()}");
        }

        private static void FunWithMethod()
        {
            Console.WriteLine($"{Utility.Add(100, 100)}");
            Console.WriteLine($"{Utility.Sub(100, 50)}");
            Console.WriteLine($"{Utility.Increment(100)}");

            var names = "Parikshit,Rohit,Anupma,Harshit".Split(',');
            Utility.GetWordCount(names);

            Utility.CreateSentence("Select * from emp", "where name = 'Parikshit'");
        }
    }
}