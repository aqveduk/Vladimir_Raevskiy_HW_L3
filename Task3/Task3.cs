using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public static int unit = 1;

        public Fraction()
        {
            numerator = denominator =  1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator > 0) { this.denominator = denominator; }
            else throw new DivideByZeroException("Denominator cannot be 0!");
        }
        private Fraction SetToNormView(Fraction C)
        {
            if(C.denominator < C.numerator) 
            {
                unit = C.numerator / C.denominator;
                //C.numerator = C.numerator - C.denominator;
            }
            return C;
        }

        public Fraction Add(Fraction A, Fraction B)
        {
            Fraction C = new Fraction();
            if(A.denominator == B.denominator)
                {
                    C.numerator = A.numerator + B.numerator;
                    C.denominator = A.denominator;
                }
            else 
                {
                    C.numerator = (A.numerator*B.denominator) + (B.numerator*A.denominator);
                    C.denominator = A.denominator * B.denominator;
                }
            return C;
        }
        public override string ToString()
        {
            return (unit > 1) ? (unit + "(" + numerator.ToString() + "/" + denominator.ToString() + ")") : (numerator.ToString() + "/" + denominator.ToString());
        }
    }

    class Program
    {
        static void Pause(string message = "Press any key to continue") { Console.WriteLine(message); Console.ReadKey();}
        static void Main(string[] args)
        {
            Console.Write("Welcome to the fraction task. Please enter the numerator: ");
            int numer1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the denominator: ");
            int denom1 = int.Parse(Console.ReadLine());
            Fraction number1 = new Fraction(numer1, denom1);
            Console.WriteLine("First fraction is: {0}", number1.ToString());

            Console.WriteLine("Please enter the numerator for the second fraction: ");
            int numer2 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the denominator for second fraction: ");
            int denom2 = int.Parse(Console.ReadLine());
            Fraction number2 = new Fraction(numer2, denom2);
            Console.WriteLine("Second fraction is: {0}", number2.ToString());

            Fraction result = new Fraction();
            result = result.Add(number1, number2);
            Console.WriteLine("\nThe result of sum: {0}", result.ToString());
            
            Pause();

        }
    }
}
