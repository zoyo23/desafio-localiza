using System.Collections.Generic;
using System.Linq;

namespace DesafioLocaliza.Extensions
{
    public static class VerificaNumeroSePrimoExtensions
    {
        public static bool EhPrimo(this int numero)
        {
            var listaDivisores = CalculaDivisoresExtensions.RetornaDivisores(numero);
            var numerosValidacaoPrimo = new List<int> { 1, numero };

            if (listaDivisores.Count() != 2 || numerosValidacaoPrimo.Except(listaDivisores).Any())
            {
                return false;
            }

            return true;
        }
    }
}
