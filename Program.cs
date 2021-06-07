using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais: \r\n");

            int idadeAna = 11;
            int quantidadePessoas = 2;

            if (idadeAna >= 18)
            {
                Console.WriteLine("Ana possui mais de 18 anos de idade. Pode participar.");

            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Ana não possui mais de 18 anos, mas está acompanhada. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Ana não possui mais de 18 anos de idade. Não pode entrar.");
                }
            }


            Console.ReadLine();
        }
    }
}