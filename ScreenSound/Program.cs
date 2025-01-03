using System;

Musica musica1 = new Musica();
musica1.Nome = "Amanhecer";
musica1.Artista = "BK";
musica1.Duracao = 212;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Canção pro meu Filho";
musica2.Artista = "Djonga";
musica2.Duracao = 123;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();