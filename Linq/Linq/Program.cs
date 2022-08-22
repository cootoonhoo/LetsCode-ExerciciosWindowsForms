using System;
using System.Collections.Generic;

class Program
{
    private static List<Produto> listaProdutos = new()
    {
        new Produto{Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
        new Produto{Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
        new Produto{Id = 4, Nome = "Celular", Valor = 8500, Ativo = true},
        new Produto{Id = 3, Nome = "Arroz", Valor = 21, Ativo = false},
        new Produto{Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true},
        new Produto{Id = 9, Nome = "Panela", Valor = 41, Ativo = true},
        new Produto{Id = 5, Nome = "Chinelo", Valor = 11, Ativo = false},
        new Produto{Id = 7, Nome = "TV", Valor = 2350, Ativo = true},
        new Produto{Id = 6, Nome = "Patins", Valor = 66, Ativo = true},
    };
    static void Main()
    {
        foreach (var Produto in listaProdutos) {
            Console.WriteLine(Produto);
        }
        AlterarCadastroProduto();
        foreach (var Produto in listaProdutos)
        {
            Console.WriteLine(Produto);
        }
    }
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Valor: R$ {Valor}";
        }
    }
    public static Produto AcharUmProdutoPorId(int Id) => listaProdutos
        .Single(prod => prod.Id == Id);
    public static void AlterarCadastroProduto()
    {
        string NovoNome = "";
        decimal NovoValor = 0.0M;
        bool NovoAtivo = false, teste = false;
        int id = 0;

        do
        {
            Console.WriteLine("Digite o Id do produto:");
            teste = int.TryParse(Console.ReadLine(), out id);
        } while (!listaProdutos.Any(prod => prod.Id == id) || !teste);

        Produto Prod = AcharUmProdutoPorId(id);

        Console.WriteLine("Novo nome do produto:");
        NovoNome = Console.ReadLine();

        do
        {
            Console.WriteLine("Digite o novo valor do produto:");
            teste = decimal.TryParse(Console.ReadLine(), out NovoValor);
        } while (!teste);

        do
        {
            Console.WriteLine("O produto é ativo (S/N):");
            var response = Console.ReadLine();
            if (response == "S")
            {
                teste = true;
                NovoAtivo = true;
            }
            else if (response == "N")
            {
                teste = true;
                NovoAtivo = false;
            }
            else
                teste = false;
        } while (!teste);

        Prod.Nome = NovoNome;
        Prod.Valor = NovoValor;
        Prod.Ativo = NovoAtivo;
    }
}