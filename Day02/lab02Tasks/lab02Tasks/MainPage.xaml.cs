using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab02Tasks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void goToMenu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TappedPage1());
        }
    }
}
