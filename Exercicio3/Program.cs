using System;

namespace Exercicio3
{
    //Programa para descobrir se é para ou impar
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            Console.Write("Sr. Usuário por favor digite um numero inteiro? ");
            int numeroTeste = Convert.ToInt32(Console.Read());
            String resultado=TestaNumero(numeroTeste);
            Linha(x);
            Console.WriteLine("O numero digitado é " + resultado);
                               
            }



        }
        public static string TestaNumero(int numero)
        {
            int resto = numero % 2;

            string resto1 = "IMPAR";

            
            if (resto == 0) { resto1 = "PAR"; } 

            return resto1;
        }
        public static void Linha(int numeroCaracter)
        {
            for (int i = 1; i < numeroCaracter - 1; ++i)
            {
                Console.Write("-");

            }
            Console.WriteLine("-");
        }
               
    }
}
