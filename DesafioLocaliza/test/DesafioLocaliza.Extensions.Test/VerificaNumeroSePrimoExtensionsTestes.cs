using System.Collections.Generic;
using Xunit;

namespace DesafioLocaliza.Extensions.Test
{
    public class VerificaNumeroSePrimoExtensionsTestes
    {
        [Theory(DisplayName = "Valida Retorno de Lista de Divisores")]
        [MemberData(nameof(ParametrosListaTestesDivisores))]
        public void DeveRetornarListaDeDivisores(int numeroParaValidacao, bool numeroEhPrimo)
        {
            #region Arrange

            #endregion

            #region Action
            var RetornoVerificacao = VerificaNumeroSePrimoExtensions.EhPrimo(numeroParaValidacao);
            #endregion

            #region Assert
            Assert.True(RetornoVerificacao == numeroEhPrimo);
            #endregion
        }

        public static IEnumerable<object[]> ParametrosListaTestesDivisores
        {
            get
            {
                yield return new object[] { 1, false };
                yield return new object[] { 2, true };
                yield return new object[] { 3, true };
                yield return new object[] { 4, false };
                yield return new object[] { 41, true };
                yield return new object[] { 43, true };
                yield return new object[] { 139, true };
            }
        }
    }
}
