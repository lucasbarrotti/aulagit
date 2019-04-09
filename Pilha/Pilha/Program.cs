using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pilhas
{

    private int[] valores;
    private int topo;
    public Pilhas(int n)
    {
        if (n > 0)
        {
            valores = new int[n];
            topo = -1;
        }
    }

    public int Push(int valor)
    {
        if (topo < valores.Length - 1)
        {
            topo++;
            valores[topo] = valor;
            return 0;
        }
        return -1;
    }

    public int Pop()
    {
        if (topo >= 0)
        {
            int valor = valores[topo];
            topo--;
            return valor;
        }
        else return -1;
    }

    public string imprimirPilha()
    {
        string saida = "\t";
        if (topo >= 0)
        {
            for (int i = topo; i >= 0; i--)
            {
                saida = saida + valores[i] + "\n\t";
            }
            return saida;
        }
        else return "\nPilha Vazia";
    }
}

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilhas pilha = new Pilhas(5);
            int sair = 0;
            string imprime = "";
            while (sair == 0)
            {
                imprimeOpcoes();
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    sair = 1;
                }
                else
                    if (opcao == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um numero para inserir a palavra");
                        pilha.Push(int.Parse(Console.ReadLine()));
                        imprime = pilha.imprimirPilha();
                        Console.WriteLine(imprime);
                    }
                    else
                        if (opcao == 2)
                        {
                            Console.Clear();
                            pilha.Pop();
                            imprime = pilha.imprimirPilha();
                            Console.WriteLine(imprime);
                        }
                        else
                            if (opcao == 3)
                            {
                                Console.Clear();
                                imprime = pilha.imprimirPilha();
                                Console.WriteLine(imprime);
                            }
            }
        }
        static public void imprimeOpcoes()
        {
            Console.WriteLine("\nEscolha uma opção\n");
            Console.WriteLine("Sair digite 0");
            Console.WriteLine("Inserir uma pilha digite 1");
            Console.WriteLine("Tirar da pilha digite 2");
            Console.WriteLine("Imprimir pilha digite 3\n");
        }
    }
}
