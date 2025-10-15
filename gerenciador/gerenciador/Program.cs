using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> compras = new List<string>();
        int opcao;
        string tarefas;

        do
        {
            Console.WriteLine("--- Lista de Compras ---");
            Console.WriteLine("(1) Adicionar tarefas");
            Console.WriteLine("(2) Mostrar tarefas");
            Console.WriteLine("(3) Remover tarefas");
            Console.WriteLine("(4) Editar tarefas");
            Console.WriteLine("(5) Ordenar tarefas em ordem alfabetica");
            Console.WriteLine("(6) Sair");
            Console.WriteLine("Escolha uma opção: ");


            bool opcaoValida = int.TryParse(Console.ReadLine(), out opcao);


            if (!opcaoValida || opcao > 6 || opcao < 1)
            {
                Console.WriteLine("Opção invalida.. Pressione ENTER para continuar");
                Console.ReadLine();
                continue;
            }


        }
        while (opcao != 6); 
        {
            Console.WriteLine("Programa encerrado com sucesso... Até Logo!!");
        }

    }
}
