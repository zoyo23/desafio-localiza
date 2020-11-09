using DesafioLocaliza.Core.Exceptions;
using DesafioLocaliza.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace DesafioLocaliza.Core
{
    public class DecomposicaoDivisores
    {
        #region Atributos
        public int FatorDecomposicao { get; private set; }
        public List<int> ListaDivisores { get; private set; }
        public List<int> ListaDivisoresPrimos { get; private set; }
        #endregion

        #region Construtores
        public DecomposicaoDivisores(string fatorDecomposicao)
        {
            if (int.TryParse(fatorDecomposicao, out int resultado))
            {
                this.FatorDecomposicao = resultado;
                PopularDivisores();
            }
            else
            {
                throw new DecomposicaoException("Por favor, informe um número válido.");
            }

        }

        public DecomposicaoDivisores(int fatorDecomposicao)
        {
            this.FatorDecomposicao = fatorDecomposicao;
            PopularDivisores();
        }
        #endregion

        #region Métodos
        private void PopularDivisores()
        {
            if (FatorDecomposicao < 0)
            {
                throw new DecomposicaoException("Por favor, informe um número posítivo válido.");
            }

            this.ListaDivisores = CalculaDivisoresExtensions.RetornaDivisores(FatorDecomposicao)?.ToList();
            this.ListaDivisoresPrimos = ListaDivisores?.Where(t => VerificaNumeroSePrimoExtensions.EhPrimo(t))?.ToList();
        }
        #endregion
    }
}
