using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsoluteLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //same for stacklayout and gridlayout just change the mainpage to run exercise 2/Absolutelayout2
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
