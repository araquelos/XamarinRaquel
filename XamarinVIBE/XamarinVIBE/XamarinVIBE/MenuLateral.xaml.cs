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
            MenuColecao.ItemsSource = App.ColecaoItensMenu;
        }

        
    }
}