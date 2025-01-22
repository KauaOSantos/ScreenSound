using System;

Album albumDoDjonga = new Album();
albumDoDjonga.Nome = "O menino que queria ser Deus ";

Musica musica1 = new Musica();
musica1.Nome = "Canção pro meu filho";
musica1.Duracao = 186;

Musica musica2 = new Musica();
musica2.Nome = "Junho de 94";
musica2.Duracao = 239;


albumDoDjonga.AdicionarMusica(musica1);
albumDoDjonga.AdicionarMusica(musica2);

albumDoDjonga.ExibirMusicasDoAlbum();

//Musica musica1 = new Musica();
//musica1.Nome = "Amanhecer";
//musica1.Artista = "BK";
//musica1.Duracao = 212;
//musica1.Disponivel = true;
//Console.WriteLine(musica1.Disponivel);