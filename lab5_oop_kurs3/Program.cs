using System;

namespace lab5_oop_kurs3
{
    class Program
    {
        public delegate void Delegate();
        public delegate void Delegate2(int seats, ref int boughtTickets);


        class Cinema
        {
            public Delegate2 sell_tickets;
            public Delegate showMovie;
            public Delegate printReviews;
            private string name;
            private string adress;
            private string name_premiere_film;
            private int ticket_price;
            private int number_of_seats;
            private int bought_tickets = 0;

            public Cinema(string _name, string _adress, string _name_premiere_film, int _ticket_price, int _number_of_seats)
            {
                name = _name;
                adress = _adress;
                name_premiere_film = _name_premiere_film;
                ticket_price = _ticket_price;
                number_of_seats = _number_of_seats;
            }

            public void SellTickets()
            {
                Console.WriteLine("///Прошло событие: продажа билетов");
                sell_tickets(number_of_seats, ref bought_tickets);
                if(bought_tickets == number_of_seats)
                {
                    Console.WriteLine("Распроданы все билеты!");
                }
            }

            public void ShowMovie()
            {
                Console.WriteLine("///Прошло событие: показ фильма");
                if (bought_tickets == 0)
                {
                    Console.WriteLine("Никто не купил билеты! Зачем показывать фильм?");
                }
                else
                {
                    showMovie();
                }
            }

            public void PrintReviews()
            {
                Console.WriteLine("///Прошло событие: мнение после фильма");
                Console.WriteLine("Кинотеатр: " + name);
                Console.WriteLine("Адрес кинотеатра: " + adress);
                Console.WriteLine("Фильм: " + name_premiere_film);
                Console.WriteLine("Стоимость билетов: " + ticket_price);
                Console.WriteLine("Куплено билетов: " + bought_tickets);
                Console.WriteLine("Отзывы:");
                printReviews();
            }

        }

        class Viewer
        {
            public static Random rand = new Random();
            private string name;
            private int ratingFilm = int.MinValue;
            bool watched = false;
            bool bought_ticket = false;

            public Viewer(string _name)
            {
                name = _name;
            }

            public void BuyTicket(int seats, ref int boughtTickets)
            {
                if(seats > boughtTickets)
                {
                    bought_ticket = true;
                    boughtTickets++;

                }
            }


            public void WatchFilm()
            {
                if (bought_ticket)
                {
                    ratingFilm = rand.Next(101);
                    watched = true;
                    bought_ticket = false;
                }
                else
                {
                    Console.WriteLine(name + ": Я еще даже не купил(а) билет на фильм!");
                }
            }



            public void ChangeMind()
            {
                if (watched)
                {
                    ratingFilm = rand.Next(101);
                }
                else
                {
                    Console.WriteLine(name + ": У меня пока что нет мнения об этом фильме. Я еще не смотрел(а) фильм!");
                }
            }

            public void SayReview()
            {
                if(watched)
                {
                    Console.Write(name + ": ");
                    if(0 <= ratingFilm && ratingFilm <= 10)
                    {
                        Console.WriteLine("Ужасно!");
                    }
                    else if (10 < ratingFilm && ratingFilm <= 20)
                    {
                        Console.WriteLine("Не стоит на это идти");
                    }
                    else if (20 < ratingFilm && ratingFilm <= 30)
                    {
                        Console.WriteLine("Ожидал большего");
                    }
                    else if (30 < ratingFilm && ratingFilm <= 40)
                    {
                        Console.WriteLine("Ну такое себе");
                    }
                    else if (40 < ratingFilm && ratingFilm <= 50)
                    {
                        Console.WriteLine("Сойдет");
                    }
                    else if (50 < ratingFilm && ratingFilm <= 60)
                    {
                        Console.WriteLine("Можно сходить один раз");
                    }
                    else if (70 < ratingFilm && ratingFilm <= 80)
                    {
                        Console.WriteLine("Достойное кинцо");
                    }
                    else if (80 < ratingFilm && ratingFilm <= 90)
                    {
                        Console.WriteLine("Однозначно рекомендую");
                    }
                    else if (90 < ratingFilm && ratingFilm <= 100)
                    {
                        Console.WriteLine("Это потрясающе, рекомендую всем");
                    }
                }
                else
                {
                    Console.WriteLine(name + ": Не могу ничего сказать, еще не смотрел(а) фильм.");
                }
            }
        }

        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Комета", "Кострома ул.Керосинова д 16", "Человек паук 2", 690, 100);

            Viewer[] viewers =
            {
                new Viewer("Вася"),
                new Viewer("Петя"),
                new Viewer("Маша"),
                new Viewer("Света"),
                new Viewer("Вика"),
                new Viewer("Вероника"),
                new Viewer("Гурген")
            };

            foreach(Viewer viewer in viewers)
            {
                cinema.sell_tickets += viewer.BuyTicket;
                cinema.showMovie += viewer.WatchFilm;
                cinema.printReviews += viewer.SayReview;
            }

            cinema.SellTickets();
            cinema.ShowMovie();
            cinema.PrintReviews();


            Console.ReadKey();
        }
    }
}
