using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1

            Car car1 = new Car("Mercedes", "S Class", 200, 5, 12000);
            car1.Drive(53);


            Console.WriteLine("");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("");

            //TASK 2

            string a = "";
            string b = "";
            Task1InputMethod(ref a, ref b);

            if (Task1IsInteger(a, b))
            {
                int aa = int.Parse(a);
                int bb = int.Parse(b);
                int sum = Task1Sum(aa, bb);
                Console.WriteLine("Daxil olunan ededlerin cemi: " + sum);
            }
            else
            {
                Console.WriteLine("error");
            }


            Console.WriteLine("");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("");

            //TASK 3

            int[] numbers = new int[] { 1, 2, 4, 3, 5, 767, 8, 9 };
            Task2(ref numbers, 14);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }


        #region task2 metod
        static void Task1InputMethod(ref string a, ref string b)
        {
            Console.WriteLine("1 ci ededi daxil edin : ");
            a = Console.ReadLine();
            Console.WriteLine("2 ci ededi daxil edin : ");
            b = Console.ReadLine();

            while (true)
            {
                if (Task1IsInteger(a, b))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Duzgun eded daxil edin");
                    Console.WriteLine("1 ci ededi daxil edin : ");
                    a = Console.ReadLine();
                    Console.WriteLine("2 ci ededi daxil edin : ");
                    b = Console.ReadLine();
                }
            }
        }

        static bool Task1IsInteger(string input, string input1)
        {
            int result, result1;
            if (int.TryParse(input, out result) && int.TryParse(input1, out result1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Task1Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        #endregion



        #region task 3 metod
        static void Task2(ref int[] numbers, int value)
        {
            int[] newArray = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            newArray[^1] = value;

            numbers = newArray;
        }
        #endregion

    }

}