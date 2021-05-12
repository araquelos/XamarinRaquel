using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinVIBE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Primeira Página - Menu Lateral
            MainPage = new XamarinVIBE.MenuLateral();
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
