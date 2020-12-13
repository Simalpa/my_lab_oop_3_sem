using System;

namespace Lab2_Kurs3
{
    class Shirt
    {
        private String title;
        private String color;
        private String size;
        private String material;
        private int year;

        static private int randValue;

        static Shirt()
        {
            randValue = new Random().Next();
        }

        public Shirt()
        {
            title = "Пример названия";
            color = "Цвет (например черный)";
            size = "Например L";
            material = "Например хлопок";
            year = 0;
        }

        public Shirt(String _title, String _color, String _size, String _material, int _year)
        {
            title = _title;
            color = _color;
            size = _size;
            material = _material;
            year = _year;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Shirt Object1 = new Shirt();
            Shirt Object2 = new Shirt("Nike", "красная", "L", "хлопок", 2019);
            Shirt Object3 = new Shirt();
        }
    }
}
