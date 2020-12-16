using System;

namespace Lab_5_oop
{
    public delegate void MyDelegat();
    class FootballMatch
    {
        public event MyDelegat onPrint;
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
            CountCom1 = rand.Next(11);
            CountCom2 = rand.Next(11);

            Console.WriteLine("Название первой команды: " + NameCom1);
            Console.WriteLine("Название второй команды: " + NameCom2);
            Console.WriteLine("Победила команда " + Winner + ", со счетом: " + CountCom1 + "-" + CountCom2);
            Console.WriteLine();
            Console.WriteLine("Цена билета = " + CostTicket + " Рублей");
            Console.WriteLine("Дата проведения матча - " + Data);
        }

        public void PrintReviews()
        {

        }
        


    }

    class Message
    {
        int waiting_invoice;
        int myComand;
        public Message()
        {
            Random rand = new Random();
            waiting_invoice = rand.Next(11);
        }

        public void PrintReview(int countCom1, int countCom2, string nameCom1, string nameCom2)
        {
            if (myComand == 1 && countCom1 > countCom2)
            {

            }
            else if (myComand == 1 && countCom1 < countCom2)
            {

            }
            else if (myComand == 2 && countCom1 < countCom2)
            {

            }
            else if (myComand == 2 && countCom1 < countCom2)
            {

            }



        }

        public void ChangeMind()
        {

        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            EndFootballMatch mutch = new EndFootballMatch("Зенит", "Динамо", "3-2", "25.03.2015", 2500f, "Зенит");
            EndFootballMatch mutch2 = new EndFootballMatch("Зенит", "Динамо", "3-2", "25.03.2015", 2500f, "Динамо");
            Message mes = new Message();
            //Handler handler1 = new Handler("Зенит", "Динамо", "3-2", "25.03.2015", 2500f, "Зенит");     
            //MyDelegat myDelegat = new MyDelegat(handler1.PrintFields);
            //myDelegat.Invoke();
            mutch.onPrint += mes.onPrint;
            mutch2.onPrint += mes.onPrint;

            mutch.PrintFields();
            mutch2.PrintFields();

            Console.ReadKey();
        }
    }
}