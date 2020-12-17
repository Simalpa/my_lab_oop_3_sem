using System;

namespace Lab_5_oop
{
    public delegate void MyDelegat(int countCom1, int countCom2, string nameCom1, string nameCom2);
    class FootballMatch
    {
        public event MyDelegat printReview;
        public string NameCom1;
        public string NameCom2;
        public int CountCom1 = -1;
        public int CountCom2 = -1;
        public string Data;
        public float CostTicket;
        public string Winner;

        public FootballMatch(string nameCom1, string nameCom2, string data, float costTicket)
        {
            NameCom1 = nameCom1;
            NameCom2 = nameCom2;
            Data = data;
            CostTicket = costTicket;

        }
        public void PlayMatсh()
        {
            Random rand = new Random();
            
            CountCom1 = rand.Next(10);
            do
            {
                CountCom2 = rand.Next(10);
            }
            while (CountCom2 == CountCom1);


            if (CountCom1 > CountCom2)
            {
                Winner = NameCom1;
            }
            else
            {
                Winner = NameCom2;
            }

            Console.WriteLine("Название первой команды: " + NameCom1);
            Console.WriteLine("Название второй команды: " + NameCom2);
            Console.WriteLine("Победила команда " + Winner + ", со счетом: " + CountCom1 + "-" + CountCom2);
            Console.WriteLine("Цена билета = " + CostTicket + " Рублей");
            Console.WriteLine("Дата проведения матча - " + Data);
        }

        public void PrintReviews()
        {
            if (CountCom1 >= 0)
            {
                Console.WriteLine("Отзывы:");
                printReview.Invoke(CountCom1, CountCom2, NameCom1, NameCom2);
            }
            else
                Console.WriteLine("Результатов нет. Игра еще не прошла!");
        }
        


    }

    class Viewer
    {
        static Random rand = new Random();
        string Name;
        int myComand;
        string[] plus_emotion = { "Вау!", "Офигенно!", "Неповторимо!", "Было, классно!", "Мне очень понравилось!", "Вот это да!"};
        string[] minus_emotion = { "Фу!", "Что за игра?!", "Ну кто так играет!", "Какого х...!", "У них что ног нет?!", "Мда, разочарован!" };
        public Viewer(string name)
        {
            Name = name;
            myComand = rand.Next(1, 3);
        }

        public void PrintReview(int countCom1, int countCom2, string nameCom1, string nameCom2)
        {
            Console.Write(Name + "(болеет за ");
            if(myComand == 1)
            {
                Console.Write(nameCom1 + "): ");
            }
            else if(myComand == 2)
            {
                Console.Write(nameCom2 + "): ");
            }

            if (myComand == 1 && countCom1 > countCom2)
            {
                Console.Write(plus_emotion[rand.Next(plus_emotion.Length)] + " ");
            }
            else if (myComand == 1 && countCom1 < countCom2)
            {
                Console.Write(minus_emotion[rand.Next(minus_emotion.Length)] + " ");
            }
            else if (myComand == 2 && countCom1 < countCom2)
            {
                Console.Write(plus_emotion[rand.Next(plus_emotion.Length)] + " ");
            }
            else if (myComand == 2 && countCom1 > countCom2)
            {
                Console.Write(minus_emotion[rand.Next(minus_emotion.Length)] + " ");
            }

            Console.WriteLine();

        }

        public void ChangeMind()
        {
            Random rand = new Random();
            myComand = rand.Next(1, 3);
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            FootballMatch mutch = new FootballMatch("Зенит", "Динамо", "25.02.2021", 4000);
            Viewer viewer1 = new Viewer("Виктор");
            Viewer viewer2 = new Viewer("Данил");
            Viewer viewer3 = new Viewer("Милана");
            Viewer viewer4 = new Viewer("Дмитрий");

            mutch.printReview += viewer1.PrintReview;
            mutch.printReview += viewer2.PrintReview;
            mutch.printReview += viewer3.PrintReview;
            mutch.printReview += viewer4.PrintReview;

            mutch.PlayMatсh();
            mutch.PrintReviews();

            Console.ReadKey();
        }
    }
}