using System.Collections.Generic;

namespace DesafioLocaliza.Extensions
{
    public static class CalculaDivisoresExtensions
    {
        public static IEnumerable<int> RetornaDivisores(this int numeroParaDecomposicao)
        {
            List<int> numeroDivisores = new List<int>();

            for (int contador = 1; contador <= numeroParaDecomposicao; contador++)
            {
                if (numeroParaDecomposicao % contador == 0)
                {
                    numeroDivisores.Add(contador);
                }
            }

            return numeroDivisores;
        }
    }
}
