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
            Console.WriteLine("Executando Projeto - Condicionais: \r\n");

            int idadeFulana = 11;
            int quantidadePessoas = 2;

            if (idadeFulana >= 18)
            {
                Console.WriteLine("Fulana possui mais de 18 anos de idade. Pode participar.");

            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Fulana não possui mais de 18 anos, mas está acompanhada. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("Fulana não possui mais de 18 anos de idade e não está acompanhada. Não pode entrar.");
                }
            }
            Console.ReadLine();
        }
    }
}
