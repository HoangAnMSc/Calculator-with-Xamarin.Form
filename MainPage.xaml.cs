using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH1
{
    public partial class MainPage : ContentPage
    {
        string So1 = "", So2, PT;
        
        private void cmdphepchia_Clicked(object sender, EventArgs e)
        {
            
            if (((Button)sender).Text != "=")
            {
                PT = ((Button)sender).Text;
                if(PT=="AC")
                {
                    txtRes.Text = "";
                    So1 = "";
                    So2 = "";
                    PT = "";
                }
                else
                {
                    txtRes.Text = "";
                }
            }
            else // push "="
            {
                double Kq = 0;
                switch (PT)
                {
                    case "+":
                        Kq = int.Parse(So1) + int.Parse(So2);
                        break;
                    case "-":
                        Kq = int.Parse(So1) - int.Parse(So2);
                        break;
                    case "×":
                        Kq = int.Parse(So1) * int.Parse(So2);
                        break;
                    case "÷":
                        double gt2 = double.Parse(So2);
                        if (gt2 != 0)
                        {
                            Kq = double.Parse(So1) / gt2;
                        }
                        else
                        {
                            Kq = 0;
                        }
                        break;
                   
                }
                if (So1 == "" || So2 == "")
                    return;
                txtRes.Text = Kq.ToString();
                PT = "";
                So1 = "";
                So2 = "";
            }
        }

        private void cmdso7_Clicked(object sender, EventArgs e)
        {
            if (PT == "")
            {
                So1 = So1 + ((Button)sender).Text;
                txtRes.Text = So1;
            }
            else
            {
                So2 = So2 + ((Button)sender).Text;
                txtRes.Text = So2;
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }

    }
}
