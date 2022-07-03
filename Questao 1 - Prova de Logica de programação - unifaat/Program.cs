using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_1___Prova_de_Logica_de_programação___unifaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notatrab, nota1, nota2;
            double media;
            string nomealuno;

            Console.WriteLine("Digite o nome do aluno:");
            nomealuno = Console.ReadLine();

            Console.WriteLine("Digite o a nota do trabalho:");
            notatrab = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = ((nota1 + nota2 + notatrab) / 3); //media será a soma das notas dividido pelo numero de notas

            if (media > 8.5)//estruturas de condição para designar conceitos dependendo da nota
            {
                Console.WriteLine($"A média do aluno {nomealuno} foi de {media}, então o conceito é A");
            }
            else if (media >= 7.0 && media <= 8.4)
            {
                Console.WriteLine($"A média do aluno {nomealuno} foi de {media}, então o conceito é B");
            }
            else if (media >= 6.0 && media <= 6.9)
            {
                Console.WriteLine($"A média do aluno {nomealuno} foi de {media}, então o conceito é C");
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.WriteLine($"A média do aluno {nomealuno} foi de {media}, então o conceito é D");
            }
            else if (media == 0.0)
            {
                Console.WriteLine($"A média do aluno {nomealuno} foi de {media}, então o conceito é E");
            }
            else
            {
                Console.WriteLine("Erro");//Caso a nota ultrapasse o limite o programa mostrara erro
            }
            Console.ReadKey();
        }
    }
}
