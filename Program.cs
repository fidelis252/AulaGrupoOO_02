using AtividadeGrupo02.Models;
using System;

namespace AtividadeGrupo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto!\n");

            Produto p1 = new Produto();
            Carrinho compra = new Carrinho();
            Entrega entrega = new Entrega();

            Console.WriteLine("Insira o nome do produto:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Insira a marca do produto:");
            p1.Marca = Console.ReadLine();
            Console.WriteLine("Insira o valor do Produto:");
            p1.valor = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a Quantidade do Produto:");
            compra.Quantidade = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Tipo de entrega:" +
                    "\nInsira 0 para download." +
                    "\nInsira 1 para envio por email.");
                entrega.TipoEntrega = Convert.ToInt32(Console.ReadLine());
                
            } while ((entrega.TipoEntrega == 0 || entrega.TipoEntrega == 1)!=true);

            
            compra.Produto = p1;
            compra.setValorTotal();
            compra.Entrega = entrega;
            
            Console.Clear();

            Console.WriteLine("Origado por comprar com a gente!" +
                "\nSegue a descrição do seu pedido:");
            Console.WriteLine($"Foram comprados {compra.Quantidade} produtos:" +
                $"\nProduto:{p1.Nome}" +
                $"\nMarca: {p1.Marca}" +
                $"\nValor: {p1.valor}" +
                $"\nValor Total da Compra é: {compra.getValorTotal().ToString("F")}" +
                $"\nO tipo de entrga é:{entrega.mostraEntrega()}");
        }
    }
}
