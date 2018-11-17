/*
 * 
 * 
VLADIMIR RAEVSKIY
GEEKBRAINS LESSON3

TASK2 - TRYPARSE

*
*/

using System;


namespace Task2
{
    class Task2
    {
        static void Calc(string number)
        {
            int digit;
            int sum = 0;
            bool flag = true;
            while (flag == Int32.TryParse(number, out digit))  //ИСПОЛЬЗУЮ TRYPARSE
            {
                if (digit % 2 >= 1)
                {
                    sum += digit;
                    number = Console.ReadLine();
                }
                else if (digit == 0)
                { flag = false; Console.WriteLine("Exit!"); }
                else
                {
                    Console.WriteLine("You have entered: {0} - even number. Current sum is: {1} Please try again", number, sum); //ВЫВОД СООБЩЕНИЯ, ЕСЛИ ВВЕДЕНО НЕВЕРНОЕ ЗНАЧЕНИЕ
                    number = Console.ReadLine();
                }
            }

            Console.WriteLine("The sum of odd numbers is: {0}", sum);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to odd numbers counter. For exit use 0. Enter the first number: ");
            string number = Console.ReadLine();
            Calc(number);
            Console.ReadKey();
        }
    }
}
