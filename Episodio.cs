class Episodio
{
    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }
    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string? Resumo => $"O Episodio {Ordem}: {Titulo}, tem duração de {Duracao}min. E conta com a Participação de {string.Join(",", Convidados)}";
    private List<string> Convidados = new();

    public void AdicionarConvidados (string convidado)
    {
        Convidados.Add(convidado);
    }
}