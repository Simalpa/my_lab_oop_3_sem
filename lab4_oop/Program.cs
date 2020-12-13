using System;

namespace lab_4_3sem
{
    class Program
    {
        class Flat
        {
            protected int floor;
            protected int number;
            protected int count_windows;

            public Flat(int _floor, int _number, int _count_windows) {
                floor = _floor;
                number = _number;
                count_windows = _count_windows;
            }

            public void PrintInfo()
            {
                Console.WriteLine("Этаж:{0}\nНомер:{1}\nКоличество окон:{2}\n", floor, number, count_windows);
            }
        }

        class OneRoomFlat : Flat
        {
            int areaRoom;

            public OneRoomFlat(int _floor, int _number, int _count_windows, int _areaRoom)  : 
                base(_floor, _number, _count_windows)
            {
                areaRoom = _areaRoom;
            }

            public void PrintInfo()
            {
                Console.WriteLine("Этаж:{0}\nНомер:{1}\nКоличество окон:{2}\nПлощадь комнаты 1:{3}\n", floor, number, count_windows, areaRoom);
            }

        }

        class TwoRoomFlat : Flat
        {
            int areaFirstRoom, areaSecondRoom;
            public TwoRoomFlat(int _floor, int _number, int _count_windows, int _areaFirstRoom, int _areaSecondRoom) :
                base(_floor, _number, _count_windows)
            {
                areaFirstRoom = _areaFirstRoom;
                areaSecondRoom = _areaSecondRoom;
            }

            public void PrintInfo()
            {
                Console.WriteLine("Этаж:{0}\nНомер:{1}\nКоличество окон:{2}\nПлощадь комнаты 1:{3}\nПлощадь комнаты 2:{4}\n", floor, number, count_windows, areaFirstRoom, areaSecondRoom);
            }
        }



        static void Main(string[] args)
        {
            Flat simpleFlat = new Flat(10, 67, 4);
            OneRoomFlat one_room_flat = new OneRoomFlat(11, 355, 3, 67);
            TwoRoomFlat two_room_flat = new TwoRoomFlat(11, 355, 3, 67, 45);

            simpleFlat.PrintInfo();
            one_room_flat.PrintInfo();
            two_room_flat.PrintInfo();

            Console.ReadKey();
        }
    }
}