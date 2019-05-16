using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Churras_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Pagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(),true);
        }
    }
}
