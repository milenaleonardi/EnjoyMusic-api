using EnjoyMusic_API.Models;
using System.Text.Json;
using EnjoyMusic_API.Filtros;
using EnjoyMusic_API.Filters;

// criando um cliente para fazer requisições web
using (HttpClient client = new HttpClient()) //utilizar a biblioteca apenas nesse modulo
{
    try
    {
        string resposta = await client.GetStringAsync(""); // pegar dados json em formato string, metodo assincrono, esperar a tarefa ser concluida e depois pegar a resposta da tarefa
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Converter json em um objeto que é manipulavel no C#
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); 
        //LinqOrder.ExibirListaOrdenadosPorNome(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2000");

        //var musicasPreferidasPlaylist = new MusicasPreferidas("Playlist");
        //musicasPreferidasPlaylist.AdicionarMusicasFavoritas(musicas[0]);
        //musicasPreferidasPlaylist.AdicionarMusicasFavoritas(musicas[100]);
        //musicasPreferidasPlaylist.AdicionarMusicasFavoritas(musicas[1000]);
        //musicasPreferidasPlaylist.ExibirMusicasFavoritas();

        //musicasPreferidasPlaylist.GerarArquivoJson();

    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}