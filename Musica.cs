class Musica
{
    public Musica(Banda artista, string nome)
    {
        Nome = nome;
        Artista = artista;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool IncluidoNoPlano { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertence a band {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if (IncluidoNoPlano)
        {
            System.Console.WriteLine("Disponível no Plano");
        }
        else
        {
            System.Console.WriteLine("Adquira o Plano Plus+");
        }
    }

}
