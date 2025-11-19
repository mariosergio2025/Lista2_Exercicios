using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Exercicio6
{
    internal class Program
    { // Programa custo da viagem
        static void Main(string[] args)
        {
            const float precoDistanciaMaior = 0.45f;//Distancia maior que 200 km preço por km
            const float precoDistanciaMenor = 0.50f; //Distancia menor ou igual que 200 km preço por km
            const float parteFixaPreco = 5.65f;// Valor fixo da corriga
            float custoViagem = parteFixaPreco;
            float custoViagemVariavel = 0;
            Console.WriteLine("Calculo do custo da Viagem");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.Write("Qual distancia da viagem em Km? ");
            float distancia=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Parcela fixa do preço _________________________________________ {custoViagem.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");

            if (distancia<=200) 
                {
                int temporaria = 0;
                Console.Write($"Parte Variavel do preço _______ {distancia} km x {precoDistanciaMenor.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))} por km______");
                custoViagemVariavel = (distancia * precoDistanciaMenor);
                temporaria = Convert.ToString(distancia).Length + custoViagemVariavel.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")).Length;
                
                for (int a=11; a > temporaria; --a)
                {
                    Console.Write("_");
                    
                }
                Console.WriteLine($"__{custoViagemVariavel.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
                custoViagem = custoViagem+ custoViagemVariavel;
                
                }
            else 
                {
                int temporaria = 0;
                Console.Write($"Parte Variavel do preço _______ {distancia} km x {precoDistanciaMaior.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))} por km______");
                custoViagemVariavel = (distancia * precoDistanciaMaior);
                temporaria = Convert.ToString(distancia).Length + custoViagemVariavel.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")).Length;

                for (int a = 11; a > temporaria; --a)
                {
                    Console.Write("_");

                }
                Console.WriteLine($"__{custoViagemVariavel.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
                custoViagem = custoViagem + custoViagemVariavel;
                }
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"O preço da viagem será _______________________________________ {custoViagem.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))} ");
            
        }
    
    }
}
