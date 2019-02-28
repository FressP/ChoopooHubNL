using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace App1
{
    public partial class MainPage : ContentPage
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Workers.mdb;";
        public MainPage()
        {

            InitializeComponent();
        }
        public void Sing_in_func(object sender, EventArgs e) {
            
        int x = 0;
            string loginS = "masloriy";
            string login = Entry1.Text;
            int max = 100;
            while (login != loginS) {
                x++;
                if (x == max)
                    break;
            }

            
        }
    }
}
