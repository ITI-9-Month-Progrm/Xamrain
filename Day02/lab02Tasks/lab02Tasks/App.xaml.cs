using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab02Tasks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                //BarBackgroundColor = Color.Purple,
                //BarTextColor = Color.White
            };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
