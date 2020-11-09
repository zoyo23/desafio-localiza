using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DesafioLocaliza.Core.Test
{
    public class DecomposicaoDivisoresTestes
    {
        [Theory(DisplayName = "Valida Retorno de Lista de Divisores")]
        [MemberData(nameof(ParametrosListaTestesDivisores))]
        public void DeveRetornarListaDeDivisores(int numeroParaDecomposicao, List<int> retornoEsperado)
        {
            #region Arrange
            var NumeroDecomposto = new DecomposicaoDivisores(numeroParaDecomposicao);
            #endregion

            #region Action
            #endregion

            #region Assert
            Assert.False(retornoEsperado.Except(NumeroDecomposto.ListaDivisores.ToList()).Any());
            #endregion
        }

        public static IEnumerable<object[]> ParametrosListaTestesDivisores
        {
            get
            {
                yield return new object[] { 1, new List<int> { 1 } };
                yield return new object[] { 2, new List<int> { 1, 2 } };
                yield return new object[] { 3, new List<int> { 1, 3 } };
                yield return new object[] { 40, new List<int> { 1, 2, 4, 5, 8, 10, 20, 40 } };
            }
        }
    }
}
