using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Exercicio2
{   // Programa Calculo da Area a ser Pintada e Quantidade Tinta
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 65; //Tamanho tela
            Console.WriteLine("Calculo de Quantidade de Tinta necessaria para Pintura!");
            Linha(t);
            Console.WriteLine();
            Console.Write("Sr. Usuário informa qual a altura da parede em metros? ");
            float alturaParede = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sr. Usuário informa qual a largura da parede em metros? ");
            float larguraParede = Convert.ToSingle(Console.ReadLine());

            float areaParede = CalArea(alturaParede, larguraParede);
            Linha(t);
            Console.WriteLine($"A parede tem {areaParede} m²");
            const float rendimento = 0.5f;
            Console.WriteLine($"O rendimento da tinta é {rendimento} m²/litro");
            Linha(t);
            float calTinta=CalTinta(areaParede, rendimento);
            Console.WriteLine($"Precisa de {calTinta} litros de tinta");

        }



        public static float CalArea(float altura, float largura)
        {
            float calculoArea = altura * largura;
            return calculoArea;
        }
        public static float CalTinta(float area, float rendimento)
        {
            float calTinta = area/rendimento;
            return calTinta;
        }

        public static void Linha(int numeroCaracter)
        {
            for (int i=1;i<numeroCaracter-1;++i)
            {
                Console.Write("-");

            }
            Console.WriteLine("-");
        }

    }
}
