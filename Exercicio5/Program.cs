using System;

namespace Exercicio5
{
    internal class Program
    {
        // Determinar se um ano é bisexto

        static void Main(string[] args)
        {
            Console.WriteLine("----- TESTE SE O ANO É BISSEXTO ------");
            Console.WriteLine("--------------------------------------");
            Console.Write("Para quantos anos você gostaria da verificação? ");
            int i = 0;
            int quantidade = Convert.ToInt32(Console.ReadLine());
            
            while (i < quantidade)
            {
                Console.Write("Qual o ano deseja verificar se é bissexto? ");
                int ano = Convert.ToInt32(Console.ReadLine());
                if (TestaBisessexto(ano))
                {
                    Console.WriteLine($"O ano {ano} é bissexto!");
                }
                else
                {
                    Console.WriteLine($"O ano {ano} não é bissexto!");

                }
            i++;
            }
        }

        static bool TestaBisessexto(int ano)
        {
            
            if ((Divisivel(ano,4) && !Divisivel(ano, 100)) || (Divisivel(ano,400)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Divisivel(int ano, int divide)
        {
            float resto = ano % divide;
            if (resto ==0 )
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }
    
    }
}
