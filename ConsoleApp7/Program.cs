using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Calc
    {

        double a = 0;
        public void SetA(double a)
        {
            this.a = a;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public double Degree(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double pow2(double a)
        {
            return Math.Pow(a, 2);
        }

        public double log(double a)
        {
            return Math.Log(a);
        }
        public double log10(double a)
        {
            return Math.Log10(a);
        }
    }

    class Calc2 : Calc
    {
        double a = 0;
        double b = 0;
        double c = 0;
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetB(double b)
        {
            this.b = b;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        public void kvadr(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.Write("Дискриминант d < 0<!-- hu -->. Решение квадратного уравнения невозможно.");
            }
            else
            {
                double x1, x2;
                if (d == 0)
                {
                    x1 = x2 = -(b / 2 * a);
                }
                else
                {

                    float sqrtD = (float)System.Math.Sqrt(d);

                    x1 = (-b + sqrtD) / (2 * a);
                    x2 = (-b - sqrtD) / (2 * a);
                }

                Console.Write("d = " + d.ToString() + " x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            }

        }

        class Program
        {
            static void Main(string[] args)
            {

                Calc C = new Calc();
                Calc2 C2 = new Calc2();
                C.SetA(5);
                Console.WriteLine("Сложение А с числом 10 = " + C.Sum(10,5) + "\n");
                Console.WriteLine("Вычитание из А числа 10 = " + C.Subtraction(10,5) + "\n");
                Console.WriteLine("Умножение А на 7 = " + C.Multiplication(7,5) + "\n");
                Console.WriteLine("Деление А на 2 = " + C.Division(2,5) + "\n");
                Console.WriteLine("А в степени 3 = " + C.Degree(3,5) + "\n");
                Console.WriteLine("Корень из А = " + C.Sqrt(4) + "\n");
                Console.WriteLine("x^2+3x-4 = 0\n решение: ");
                C2.SetA(1);
                C2.SetB(3);
                C2.SetC(-4);
                C2.kvadr(1,3,-4);
                Console.ReadLine();
            }
        }
    }
}
