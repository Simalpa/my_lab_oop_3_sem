using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_andr
{
    class Program
    {
        class Sofa
        {
            string firm;
            int price;
            float length;
            float width;
            float height;
            static public int count = 0;

            public Sofa()
            {
                count++;
            }

            public void InitFields(string f, int p, float l, float w, float h)
            {
                firm = f;
                price = p;
                length = l;
                width = w;
                height = h;
            }

            public void PrintFields()
            {
                Console.WriteLine($"Фирма - {firm}");
                Console.WriteLine($"Цена - {price}");
                Console.WriteLine($"Длина - {length}");
                Console.WriteLine($"Ширина - {width}");
                Console.WriteLine($"Высота - {height}");
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Sofa sofa1 = new Sofa();
            Sofa sofa2 = new Sofa();
            Sofa sofa3 = new Sofa();

            sofa1.InitFields("Альба", 45000, 3, 1.5f, 1);
            sofa2.InitFields("Боска", 98000, 4, 1.3f, 1.5f);
            sofa3.InitFields("Нивала", 69000, 3.5f, 1, 1.15f);

            sofa1.PrintFields();
            sofa2.PrintFields();
            sofa3.PrintFields();

            Console.WriteLine("Общее количество объектов: {0}", Sofa.count);

            Console.ReadKey();

        }
    }
}
