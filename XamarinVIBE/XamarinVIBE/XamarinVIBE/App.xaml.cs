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

        public static List<ColecaoPaginas> ColecaoItensMenu
        {
            get
            {
                var institucional = new ColecaoPaginas()
                {
                    new Pagina() {Nome = "Nossa Vibe", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Trabalhe com a gente", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true}
                };
                institucional.Titulo = "Institucional";

                var transformacaoDigital = new ColecaoPaginas()
                {
                    new Pagina() {Nome = "Consultoria para startups", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Aplicativos (apps)", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Software como serviço (SaaS)", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true}
                };
                transformacaoDigital.Titulo = "Transformação Digital";

                var solucoesCorporativas = new ColecaoPaginas()
                {
                    new Pagina() {Nome = "Desenvolvimento de sistemas desktop", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Desenvolvimento de sistemas web", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Desenvolvimento de aplicativos móveis", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Integração de sistemas", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Automatização de processos", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Soluções em Cloud", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "DevOps", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Conteinerização", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Infraestrutura e monitoramento", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "Data Analytics (BI)", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false}
                };
                solucoesCorporativas.Titulo = "soluções Corporativas";

                var casesSucesso = new ColecaoPaginas()
                {
                    new Pagina() {Nome = "Integração com meio de pagamento", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = false},
                    new Pagina() {Nome = "Internet Banking", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                    new Pagina() {Nome = "O Novo Receptiva", ArquivoPagina = typeof(Paginas.Institucional.NossaVibe), TemNavegacao = true},
                };
                casesSucesso.Titulo = "Cases de Sucesso";

                return new List<ColecaoPaginas>()
                {
                    institucional,
                    transformacaoDigital,
                    solucoesCorporativas,
                    casesSucesso                
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
