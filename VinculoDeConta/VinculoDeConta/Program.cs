using System;

// 02
Conta conta1 = new Conta();
conta1.Titular = "Kauã";
conta1.Saldo = 10000.0;

Console.WriteLine($"Essa conta é do titular {conta1.Titular} que está com o saldo de R$ {conta1.Saldo}.");

// 03
Conta conta2 = new Conta();
conta2.Titular = "Vitor";
conta2.Saldo = 10000.0;
conta1.ExibirDadosConta();
conta2.ExibirDadosConta();

// 04
Carro carro = new Carro();
carro.Fabricante = "Toyota";
carro.Modelo = "Corolla Hybrid";
carro.Ano = 2023;
Console.WriteLine(carro.DescricaoDetalhada);

//
Produto produto1 = new Produto();
produto1.Nome = "Fone de Ouvido";
produto1.Marca = "Xiaomi";
produto1.Preco = 50;
produto1.Estoque = 100;

Console.WriteLine (produto1.InformacoesProduto);