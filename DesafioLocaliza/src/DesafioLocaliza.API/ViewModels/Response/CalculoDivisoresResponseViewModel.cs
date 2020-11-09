using System.Collections.Generic;

namespace DesafioLocaliza.API.ViewModels.Response
{
    public class CalculoDivisoresResponseViewModel
    {
        public int ValorInformadoParaDecomposicao { get; set; }
        public List<int> Divisores { get; set; }
        public List<int> DivisoresPrimos { get; set; }
    }
}
