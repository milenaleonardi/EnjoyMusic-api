using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EnjoyMusic_API.Models
{
    internal class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> MusicasFavoritas { get; set; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            MusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            MusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
            foreach (var musica in MusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = MusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favortias-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json); // nome do arquivo, conteudo do arquivo
            Console.WriteLine($"O arquivo json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
