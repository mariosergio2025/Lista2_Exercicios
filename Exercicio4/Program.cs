using System.Globalization;

namespace Exercicio4
{
    internal class Program
    {
        // Programa multa
        static void Main(string[] args)
        {
            Console.Write("Qual a velocidade do veiculo em km/h? ");
            float velocidade=Convert.ToSingle(Console.ReadLine());
            
            // velocidade limite para não receber multa
            float limite = 80;
            // multa por execsso de velocidade 
            float valorMulta = 5;
            if (velocidade > limite)
            {
                float velocidadeMais = velocidade - limite;
                Console.WriteLine($"Voce esta {velocidadeMais} km/h a mais que o limite de velocidade");
                float multa = velocidadeMais * valorMulta;
                Console.WriteLine("Voce será multando em " + multa.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")));
            }
            else { Console.WriteLine("Você esta dentro do limite de velocidade"); }


            }
    }
}
