using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Program
    {
        class Shirt
        {
            private String title;
            private String color;
            private String size;
            private String material;
            private int year;

            static private uint count;

            public Shirt()
            {
                count++;
            }

            public void PrintField()
            {
                Console.WriteLine($"Название: {title}\nЦвет: {color}\nРазмер: {size}\nМатериал: {material}\nГод изготовления: {year}\n");
            }
            public void InitField(String t, String c, String s, String m, int y)
            {
                title = t;
                color = c;
                size = s;
                material = m;
                year = y;
            }

            static public uint Count
            {
                get
                {
                    return count;
                }
            }
            ~Shirt()
            {
                count--;
            }

        }

        static void Main(string[] args)
        {
        }
    }
}
