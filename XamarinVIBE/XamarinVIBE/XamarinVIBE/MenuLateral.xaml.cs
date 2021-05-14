using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVIBE.Modelos;
using XamarinVIBE.ViewModels;

namespace XamarinVIBE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : FlyoutPage
    {
        public MenuLateral()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        private void AbrirPagina(object sender, System.EventArgs e)
        {
            TappedEventArgs eventArgs = (TappedEventArgs)e;
            Pagina parametro = (Pagina)eventArgs.Parameter;

            Page pagina = null;
            if (parametro.TemNavegacao)
            {
                pagina = new NavigationPage((Page)Activator.CreateInstance(parametro.ArquivoPagina));
            }
            else
            {
                pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
            }

            Detail = pagina;
            IsPresented = false;
        }
    }
}