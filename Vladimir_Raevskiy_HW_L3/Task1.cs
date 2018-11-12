/*
 * 
 * 
VLADIMIR RAEVSKIY
GEEKBRAINS LESSON3

TASK1 - СТРУТКУРА И КЛАСС, ПРИНЦИП РАБОТЫ
TASK2 - 

*
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vladimir_Raevskiy_HW_L3
{

    struct Complex  //TASK1 - А) СТРУТКУРА, ПРИНЦИП РАБОТЫ
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Subtract(Complex x)  // А) МЕТОД ВЫЧИТАНИЯ В СТРУКТУРЕ
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class ComplexNum  //TASK1 - Б) КЛАСС, ПРИНЦИП РАБОТЫ
    {
        private double im;
        double re;

        public ComplexNum()
        {
            im = 0;
            re = 0;
        }
        public ComplexNum(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public ComplexNum Plus(ComplexNum x)
        {
            ComplexNum y = new ComplexNum
            {
                im = x.im + im,
                re = x.re + re
            };
            return y;
        }
        public ComplexNum Subtract(ComplexNum x) // Б) МЕТОД КЛАССА - ВЫЧИТАНИЕ
        {
            ComplexNum z = new ComplexNum  
            {
                im = im - x.im,
                re = re - x.re
            };
            return z;
        }
        public ComplexNum Multi(ComplexNum x)  // Б) МЕТОД КЛАССА - ПРОИЗВЕДЕНИЕ
        {
            ComplexNum y = new ComplexNum
            {
                im = re * x.im + im * x.re,
                re = re * x.re - im * x.im
            };

            return y;
        }



        public double Im
        {
            get { return Im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }


    class Task1
    {
        static void Pause(string message = "Press any key to continue..") { Console.WriteLine(message); Console.ReadKey(); }
        static void Print(string text) { Console.WriteLine(text); }
        static void Main(string[] args)
        {
            //СТРУКТУРА
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Print($"PRINT STRUCTURE RESULT, A");

            Complex result = complex1.Plus(complex2);
            Print("STRUCTURE SUM: ");
            Print(result.ToString());

            Print("STRUCTURE MULTIPLICATION: ");
            result = complex1.Multi(complex2);
            Print(result.ToString());

            Print("STRUCTURE SUBSTRACT: ");
            result = complex1.Subtract(complex2);
            Print(result.ToString());

            Print("\n\n");


            //КЛАСС
            ComplexNum complexNum1 = new ComplexNum(2, 2);
            ComplexNum complexNum2 = new ComplexNum(4, 4);

            complexNum1.Im = 5;  //ИЗМЕНЕНИЕ ПРИВАТНОГО ПОЛЯ КЛАССА
            complexNum2.Im = 6;

            Print("PRINT CLASS RESULT: ");


            ComplexNum resultClass = complexNum1.Plus(complexNum2);
            Print("CLASS SUM: ");
            Print(resultClass.ToString());

            resultClass = complexNum1.Subtract(complexNum2);
            Print("CLASS SUBTRACT: ");
            Print(resultClass.ToString());   //ПЕРЕГРУЗКА 

            resultClass = complexNum1.Multi(complexNum2);
            Print("CLASS MULTIPLICATION: ");
            Print(resultClass.ToString());   //ПЕРЕГРУЗКА 

            Pause();
        }
    }
}