using DesafioLocaliza.API.ViewModels;
using DesafioLocaliza.API.ViewModels.Response;
using DesafioLocaliza.Core;

namespace DesafioLocaliza.API.Services
{
    public class CalculoDivisoresService
    {
        public CalculoDivisoresResponseViewModel CalculaDivisoresNumeroInformado(CalculoDivisoresRequestViewModel calculoDivisoresRequestViewModel)
        {
            var calculoDivisores = new DecomposicaoDivisores(calculoDivisoresRequestViewModel.ValorParaDecomposicao);

            return new CalculoDivisoresResponseViewModel
            {
                ValorInformadoParaDecomposicao = calculoDivisoresRequestViewModel.ValorParaDecomposicao,
                Divisores = calculoDivisores.ListaDivisores,
                DivisoresPrimos = calculoDivisores.ListaDivisoresPrimos
            };
        }
    }
}
