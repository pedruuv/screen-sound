class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albuns = new();
    private string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discografia da Banda: {Nome}");
        foreach (var album in albuns)
        {
            System.Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}