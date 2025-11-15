using System.Globalization;

namespace Exercicio1
{
    //Faça um programa que leia quanto dinheiro tem na carteira e converta o valor em dolar
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cotacaoDolar = 5.15m;
            Console.Write("Sr. usuário qual o valor em R$ você tem na carteira? ");
            decimal dinheiroCarteira = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Com a cotação de 1 dolar para "+cotacaoDolar.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")));
            Console.WriteLine(" e você tendo "+dinheiroCarteira.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")) +" na carteira");
            Console.WriteLine("");
            Console.WriteLine("");
            decimal convertidoEmDollar = dinheiroCarteira / cotacaoDolar;
            Console.WriteLine("O equivalente em dolar que possui na carteira são: " + convertidoEmDollar.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
        }
    }
}
