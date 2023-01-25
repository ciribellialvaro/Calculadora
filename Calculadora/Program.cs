using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        enum Menu { 
            Soma = 1,
            Subtracao = 2,
            Divisao = 3,
            Multiplicacao = 4,
            Potencia = 5,
            Raiz = 6,
            Sair = 7
        }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)//enquanto o usuário não escolheu sair(!escolheuSair), exiba o menu
            {
                //exiba o menu
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                //capturei o numero que veio em formato de texto, e converso em numero, e depois converto em formato Menu:
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                        
                }
                
                
                Console.Clear();

            }
            //feche

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int result = primeiroNumero + segundoNumero;

            Console.WriteLine("O resultado é " + result);
            //Console.WriteLine("O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
    }
}
