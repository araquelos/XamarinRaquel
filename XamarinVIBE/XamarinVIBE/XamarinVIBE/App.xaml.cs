using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVIBE.Modelos;

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

        public static List<ColecaoDePaginas> ColecaoItensMenu
        {
            get
            {
                var institucional = new ColecaoDePaginas()
                {
                    new Pagina() {Nome = "Nossa Vibe", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Trabalhe com a gente", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true}
                };
                institucional.Titulo = "Institucional";

                var institucional2 = new ColecaoDePaginas()
                {
                    new Pagina() {Nome = "Nossa Vibe", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Trabalhe com a gente", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true}
                };
                institucional2.SubTitulo = "Teste";

                return new List<ColecaoDePaginas>()
                {
                    institucional,
                    institucional2,
                    //leiautes,
                    //controles,
                    //listas,
                    //estilos,
                    //animacao,
                    //gestos,
                    //classesuteis,
                    //xf47,
                    //xf48xf50,
                    //shell
                };
            }
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
