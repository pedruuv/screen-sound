// Album albumDoACDC = new("Back in Black");
// Banda acdc = new("AC/DC");

// Musica musica1 = new(acdc, "Back in Black")
// {
//     Duracao = 254,
//     IncluidoNoPlano = true
// };

// Musica musica2 = new(acdc, "Hells Bells")
// {
//     Duracao = 312,
//     IncluidoNoPlano = false
// };

// albumDoACDC.AdicionarMusica(musica1);
// albumDoACDC.AdicionarMusica(musica2);
// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoACDC.ExibirMusicasDoAlbum();

// acdc.AdicionarAlbum(albumDoACDC);
// acdc.ExibirDiscografia();

Episodio episodio1 = new("Estreia", 1, 120);
Episodio episodio2 = new("Conversa com XPG", 2, 200);
Episodio episodio0 = new("Piloto", 0, 5);

Podcast podcastManeiro = new("PodcastManeiro", "Pedro");
podcastManeiro.AdicionarEpisodio(episodio1);
podcastManeiro.AdicionarEpisodio(episodio2);
podcastManeiro.AdicionarEpisodio(episodio0);

podcastManeiro.ExibirDetalhes();


