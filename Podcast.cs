class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    private string Nome {get;}
    private string Host {get;}
    private List<Episodio> ListaDeEpisodios = new();
    public int TotalDeEpisodios => ListaDeEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        ListaDeEpisodios.Add(episodio);
    }

    public void ExibirDetalhes ()
    {
        System.Console.WriteLine($"O podcast {Nome} com {Host} vai começar!\n");
        foreach(var episodio in ListaDeEpisodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine($"Episodio {episodio.Ordem}: {episodio.Titulo}");

        }
        System.Console.WriteLine($"Total de episodios: {TotalDeEpisodios}");
    }
}