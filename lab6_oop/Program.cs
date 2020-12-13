using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_oop
{
    class Program
    {
        class Equation
        {
            public virtual List<float> roots_equation(float a, float b, float c) { return new List<float>(); }
        }

        class LinearEquation : Equation
        {
            public override List<float> roots_equation(float a, float b, float c = 0)
            {
                return new List<float>{ b / a };
            }
        }

        class QuadraticEquation : Equation
        {
            public override List<float> roots_equation(float a, float b, float c)
            {
                float D = b * b - 4 * a * c;

                if (D > 0)
                {
                    float result1 = Convert.ToSingle((-b + Math.Sqrt(D)) / (2 * a));
                    float result2 = Convert.ToSingle((-b - Math.Sqrt(D)) / (2 * a));
                    return new List<float> {result1, result2};

                }
                else if (D == 0)
                {
                    float result = Convert.ToSingle(-b / (2 * a));
                    return new List<float> { result };
                }
                else
                    return new List<float>();
            }
        }

        static void Main(string[] args)
        {
            Equation line = new LinearEquation();
            float a, b, c;
            Console.Write("Введите значение a для линейного уравнения: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение b для линейного уравнения: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Решение линейного уравнения {a}x = {b}: ");
            List<float> result = line.roots_equation(a, b, 0);

            for (int i = 0; i < result.Count; i++)
                Console.WriteLine($"Корень {i+1} равен {result[i]}");


            Equation quadratic = new QuadraticEquation();
            Console.Write("Введите значение a для квадратного уравнения: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение b для квадратного уравнения: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение с для квадратного уравнения: ");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Решение квадратного уравнения {a}x^2 + {b}x + {c} = 0 : ");
            result = quadratic.roots_equation(a, b, c);
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine($"Корень {i+1} равен {result[i]}");

            if(result.Count == 0) { Console.WriteLine("Нет корней уравнения"); }


            Console.ReadKey();

        }
    }
}
