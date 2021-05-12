using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVIBE.Paginas;

namespace XamarinVIBE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : FlyoutPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void AbrirPagina01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina01());
            IsPresented = false;
        }

        private void AbrirPagina02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina02());
            IsPresented = false;
        }

        private void AbrirPagina03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina03());
            IsPresented = false;
        }

        private void AbrirPagina04(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina04());
            IsPresented = false;
        }

        private void AbrirPagina05(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina05());
            IsPresented = false;
        }

        private void AbrirPagina06(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina06());
            IsPresented = false;
        }
    }
}