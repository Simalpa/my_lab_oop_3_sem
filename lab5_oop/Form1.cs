using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_oop
{
    public class Viewer
    {
        private string name;
        private string middle_name;
        private string name_film;
        private int age;
        private float ticket_cost;

        public Watcher(string _name, string _middle_name, string _name_film, int _age, float _ticket_cost)
        {
            name = _name;
            middle_name = _middle_name;
            name_film = _name_film;
            age = _age;
            ticket_cost = _ticket_cost;
        }

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }

        }

        public string Middle_name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    middle_name = value;
                }
            }
            get
            {
                return middle_name;
            }

        }

        public string Middle_name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    middle_name = value;
                }
            }
            get
            {
                return middle_name;
            }

        }







    }

    public class Cinema
    {
        private List<Watcher> watchers = new List<Watcher>();
        private string adress;
        private DateTime time_open;
        private DateTime time_close;
        private int max_count_people;

        public Cinema(string _adress, DateTime _time_open, DateTime _time_close, int _max_count_people)
        {
            adress = _adress;
            time_open = _time_open;
            time_close = _time_close;
            max_count_people = _max_count_people;
            
        }

        public void addWatcher(string name, string middle_name, string name_film, int age, float ticket_cost)
        {
            watchers.Add(new Watcher(name, middle_name, name_film, age, ticket_cost));
        }

        public void deleteWatcher(int number)
        {
            watchers.RemoveAt(number);
        }

        public string Adress
        {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    adress = value;
                }
            }
            get
            {
                return adress;
            }

        }

        public DateTime Time_open
        {
            set
            {
                if (value > DateTime.Now)
                {
                    time_open = value;
                }
            }
            get
            {
                return time_open;
            }

        }

        public DateTime Time_close
        {
            set
            {
                if (value > DateTime.Now)
                {
                    time_close = value;
                }
            }
            get
            {
                return time_close;
            }

        }

        public int Max_count_people
        {
            set
            {
                if (value > 0)
                {
                    max_count_people = value;
                }
            }
            get
            {
                return max_count_people;
            }

        }



    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
