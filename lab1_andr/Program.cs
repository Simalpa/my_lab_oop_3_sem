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
            int length;
            int width;
            int height;
            static public int count = 0;

            public Sofa()
            {
                count++;
            }

            public void InitFields(string f, int p, int l, int w, int h)
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

            }
        }


        static void Main(string[] args)
        {
            Sofa sofa1 = new Sofa();
            Sofa sofa2 = new Sofa();
            Sofa sofa3 = new Sofa();

            sofa1.InitFields("Альба", )

        }
    }
}
