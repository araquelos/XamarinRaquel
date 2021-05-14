using System;
using System.Collections.Generic;
using System.Text;
using XamarinVIBE.Modelos;

namespace XamarinVIBE.ViewModels
{
    public class MenuViewModel
    {
        public List<ColecaoPaginas> MenuItens { get; set; }
        public MenuViewModel()
        {
            MenuItens = App.ColecaoItensMenu;
        }
    }
}
