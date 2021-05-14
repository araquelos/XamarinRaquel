using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinVIBE.Modelos
{
    public class ColecaoDePaginas : List<Pagina>
    {
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }

    }
}
