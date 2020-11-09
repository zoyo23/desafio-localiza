using DesafioLocaliza.Core;
using DesafioLocaliza.Core.Exceptions;

namespace DesafioLocaliza.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Momento mão na massa - Localiza");
            System.Console.WriteLine("* Dado um número de entrada, o programa deve calcular todos os divisores que compõem o número.");
            System.Console.WriteLine("* Dado um número de entrada, o programa deve calcular todos os divisores primos que compõem o número.");

            while (true)
            {

                System.Console.WriteLine("Por Favor, informe um número para decomposição: ");

                var numeroParaDecomposicao = System.Console.ReadLine();

                try
                {
                    var decomposicao = new DecomposicaoDivisores(numeroParaDecomposicao);

                    System.Console.WriteLine(@$"
Número informado:       {decomposicao.FatorDecomposicao}
Divisores:              {string.Join(", ", decomposicao.ListaDivisores)}
Divisores Primos:       {string.Join(", ", decomposicao.ListaDivisoresPrimos)}
");
                }
                catch (DecomposicaoException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine($"Problemas no calculo, por favor tente novamemte.");
                }
            }
        }
    }
}
