using System;
using System.Collections.Generic;

namespace ATIVIDADE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            char controle = 's';

            do{
                ItemPedido item = new ItemPedido();
                Console.Clear();

                Console.WriteLine("\n Olá! Seja Bem-Vindo");

                Console.WriteLine("Qual a descrição do item?");
                item.descrição = Console.ReadLine();

                Console.WriteLine("Qual o valor do item?");
                item.valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o quantidade de itens?");
                item.quantidade = int.Parse(Console.ReadLine());
                
                pedido.IncluirItem(item);
                Console.WriteLine("Item adicionado ao pedido.");

                Console.WriteLine("Deseja adicionar outro item ao pedido?");
                controle = Console.ReadKey().KeyChar;

            }while(controle == 's' || controle == 'S');

            Console.WriteLine("\n O valor total é: " + pedido.FinalizarPedido());
        }
    }
}
