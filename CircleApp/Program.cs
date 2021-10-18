

//The task is to analyze all possible scenarios of relationship of two given circles. There is no assumption

//or limitation for range of values for x, y and radius (any integer value can be used).

using System;
namespace CircleApp
{

    class Program
    {
        // Fill numbers from the user
        public static int InputNumber(string value)
        {
            int number;
            while (true)
            {
                Console.Write("Please enter value of " + value + ": ");
                if (int.TryParse(Console.ReadLine(), out number)) break;
                {
                    Console.WriteLine("Wrong input, Please Try again!!!");
                }
            }

            return number;
        }

        //Main Method
        static void Main(string[] args)
        {
            Circle c1 = new Circle(InputNumber("x1"), InputNumber("y1"), InputNumber("radix1"));
            Circle c2 = new Circle(InputNumber("x2"), InputNumber("y2"), InputNumber("radix2"));


            switch ((int)Circle.CalculateRelation(c1, c2))
            {
                case 0:
                    Console.WriteLine("Circle touch" + " to each other.");
                    break;
                case 1:
                    Console.WriteLine("Circle intersect" + " to each other.");
                    break;
                default:
                    Console.WriteLine("Circle not touch" + " to each other.");
                    break;
            }

        }
    }
}
