using EnjoyMusic_API.Models;

namespace EnjoyMusic_API.Filters
{
    internal class LinqOrder
    {
        // Ordenar os artistas por nome
        public static void ExibirListaOrdenadosPorNome(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(m => m.Artista).Select(m => m.Artista).Distinct().ToList();
            Console.WriteLine("Lista de artistas ordenados: ");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
