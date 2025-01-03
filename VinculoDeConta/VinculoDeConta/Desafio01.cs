using System;

//////
public class ContaBancaria
{
    public int numeroIndicador;
    public string titular;
    public double saldo;
    public string senha;
}

//////
public class Conta
{
    public string Titular { get; set; }
    public double Saldo { get; set; }

//////
    public void ExibirDadosConta()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}

//////
public class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    private int ano;
    public int Ano
    {
        get => ano;
        set
        {
            ano =
                value >= 1960 && value <= 2023 ? value : 0;
            if (ano == 0)
                Console.WriteLine("O ano informado deve estar entre 1960 e 2023");
        }
    }

    public string DescricaoDetalhada =>
    $"A Fabricante {Fabricante} fez o carro {Modelo} que é do ano de {Ano}";

    public void Acelerar()
    {
        Console.WriteLine("O Motorista acelerou para ganhar a corrida.");
    }
    public void Frear()
    {
        Console.WriteLine("O Motorista freou para evitar um atropelamento.");
    }
    public void Buzinar()
    {
        Console.WriteLine("O Motorista bozinou para evitar um acidente.");
    }
}

//////
public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private int estoque;
    public int Estoque
    {
        get => estoque;
        set
        {
            estoque = VerificaNumero(value);
        }
    }
    public bool ProdutoValido { get; set ; }

    private int preco;
    public int Preco {
        get => preco;
        set
        {
            preco = VerificaNumero(value);
        }
    }
    public int VerificaNumero(int value)
    {
        if (value <= 0)
        {
            ProdutoValido = false;
            return 0;
        }
        else
        {
            return value;
        }
            
    }
    public string VerificaValido()
    {
        if (ProdutoValido)
        {
            return $"O produto {Nome} da marca {Marca} está com o preço de R$ {Preco} e tem {Estoque} unidades no estoque.";
        }
            if (Estoque <= 0 && Preco <= 0)
                return "O Estoque e o Preço devem ser maiores que 0.";
            else if (Estoque <= 0)
                return "O Estoque do Produto deve ser maior que 0.";
            else if (Preco <= 0)
                return "O Preço do Produto deve ser maior que 0.";
            else
            {
                return "";
            }
    }

    public string InformacoesProduto => VerificaValido();
    public Produto() { ProdutoValido = true; }

}

//////
public class Soma
{
    public int A { get; set; }
    public int B { get; set; }
    public string Resultado =>
        $"Soma dos números {A} + {B} = {A + B}";
}