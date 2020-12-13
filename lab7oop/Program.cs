using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7oop
{
    class Program
    {
        public interface IOutput
        {
            void PrintFunction();
        }

        public interface ICalculate
        {
            float Calculate();
        }

        class LineFunction : IOutput, ICalculate
        {
            private float a, b, x;
            public LineFunction(float _a, float _b, float _x)
            {
                a = _a;
                b = _b;
                x = _x;
            }
            public void PrintFunction()
            {
                Console.WriteLine("f(x) = ax + b");
            }

            public float Calculate()
            {
                return  a * x + b ;
            }
        }

        class QuadrationFunction : IOutput, ICalculate
        {
            private float a, b, c, x;
            public QuadrationFunction(float _a, float _b, float _c, float _x)
            {
                a = _a;
                b = _b;
                c = _c;
                x = _x;
            }

            public void PrintFunction()
            {
                Console.WriteLine("f(x) = ax^2 + bx + c");
            }

            public float Calculate()
            {
                return  a * x * x + b * x + c;
            }

            
        }

        static void Main(string[] args)
        {
            float a, b, c, x;
            Console.Write("Введите значение a для линейной функции: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение b для линейной функции: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение x для линейной функции: ");
            x = Convert.ToSingle(Console.ReadLine());
            LineFunction line = new LineFunction(a, b, x);
            float f_x = line.Calculate();
            Console.WriteLine($"f(x) = {a}*{x} + {b} = {f_x}");

            Console.Write("Введите значение a для квадратичной функции: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение b для квадратичной функции: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение x для квадратичной функции: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение x для квадратичной функции: ");
            x = Convert.ToSingle(Console.ReadLine());
            QuadrationFunction quadration = new QuadrationFunction(a, b, c, x);
            f_x = quadration.Calculate();
            Console.WriteLine($"f(x) = {a}*{x}*{x} + {b}*{x} + {c} = {f_x}");


            Console.ReadKey();
        }
    }
}
