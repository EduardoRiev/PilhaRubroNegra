using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRubroNegra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da sua pilha: ");
            int tamanhoPilha = int.Parse(Console.ReadLine());
            Peça[] peças = new Peça[tamanhoPilha];
            Pilha pilha = new Pilha(tamanhoPilha, -1, tamanhoPilha, peças);

            int op = 1;
            do
            {
                Console.WriteLine("\nMenu de Opções:\n");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Insere um valor na pilha vermelha");
                Console.WriteLine("2 - Insere um valor na pilha negra");
                Console.WriteLine("3 - Remove o valor do topo da pilha vermelha");
                Console.WriteLine("4 - Remove o valor do topo da pilha negra");
                Console.WriteLine("5 - Lista o Array e as pilhas");
                Console.WriteLine("6 - Verifica qual o valor do topo da pilha vermelha");
                Console.WriteLine("7 - Verifica qual o valor do topo da pilha negra\n");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        op = 0;
                        break;

                    case 1:
                        Console.Write("\nDigite o valor a ser inserido na pilha vermelha: ");
                        int b = int.Parse(Console.ReadLine());
                        Peça p1 = new Peça(b);
                        pilha.PushRubro(p1);
                        Console.WriteLine("Valor incluído na pilha vermelha!");
                        break;

                    case 2:
                        Console.Write("\nDigite o valor a ser inserido na pilha negra: ");
                        int c = int.Parse(Console.ReadLine());
                        Peça p2 = new Peça(c);
                        pilha.PushNegro(p2);
                        Console.WriteLine("Valor incluído na pilha negra!");
                        break;

                    case 3:
                        pilha.PopNegro();
                        Console.WriteLine("Valor do topo removido da pilha vermelha!");
                        break;

                    case 4:
                        pilha.PopRubro();
                        Console.WriteLine("Valor do topo removido da pilha negra!");
                        break;

                    case 5:
                        pilha.Listar();
                        break;

                    case 6:
                        Console.WriteLine($"{pilha.GetIndiceRubro()}");
                        break;

                    case 7:
                        Console.WriteLine($"{pilha.GetIndiceNegro()}");
                        break;
                }
            } while (op != 0);
        }
    }
}
