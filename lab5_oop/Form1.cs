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
    public class Watcher
    {
        private string name;
        private string middle_name;
        private string name_film;
        private int age;
        private float ticket_cost;
    }

    public class Cinema
    {
        private List<Watcher> watchers = new List<Watcher>();
        private string adress;
        private DateTime timeOpen;
        private DateTime timeClose

    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
