using EnjoyMusic_API.Models;

namespace EnjoyMusic_API.Filtros
{
    internal class LinqFilter
    {
        // Exibir todos os gêneros musicais
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();
            foreach (var genero in TodosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        // Exibir artistas por genero musical
        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas
                .Where(m => m.Genero!.Contains(genero))
                .Select(a => a.Artista)
                .Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por genero musical: {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        // Exibir musicas por artista
        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicaPorArtista = musicas
                .Where(m => m.Artista!.Equals(artista))
                .Select(m => m.Nome)
                .ToList();
            Console.WriteLine($"Exibindo músicas por artista: {artista}");
            foreach (var musica in musicaPorArtista)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        // Exibir as musicas por ano
        public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
        {
            var musicasPorAno = musicas
                .Where(m => m.Ano!.Equals(ano))
                .Select(m => m.Nome)
                .Distinct().ToList();
            Console.WriteLine($"Músicas do ano {ano}:");
            foreach (var musica in musicasPorAno)
            {
                Console.WriteLine($"- {musica}");
            }
        }

        public static void FiltrarMusicasEmCSharp(List<Musica> musicas)
        {
            var musicasEmCSharp = musicas
                .Where(m => m.Tonalidade.Equals("C#"))
                .Select(m => m.Nome)
                .ToList();
            Console.WriteLine("Músicas em C# (Dó Sustenido)");
            foreach(var musica in musicasEmCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
