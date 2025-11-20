using System;
using System.Globalization;

namespace Exercicio09
{   
    // Programa para de concessao de emprestimo bancario
    internal class Program
    {
        static void Main(string[] args)
        {
            var ptBR = CultureInfo.CreateSpecificCulture("pt-BR");
            Linha(col);
            Console.WriteLine("Simulador de Emprestimo Bancário");
            Linha(col);
            Console.Write("Informa o valor do imovel: ");
            float valorImovel = Convert.ToSingle(Console.ReadLine());
            Console.Write("Salario do proponente: ");
            float salarioProp = Convert.ToSingle(Console.ReadLine());
            Console.Write("Prazo do emprestimo (em anos): ");
            float anosEmprestimo = Convert.ToSingle(Console.ReadLine());
           
            // tranforma anos em meses
            float mesesEmprestimo = anosEmprestimo * 12;

            Console.Clear();
            Linha(col);
            Console.WriteLine($"Em um emprestimo de {valorImovel.ToString("C", ptBR)}");
            Console.WriteLine($"No Prazo de {anosEmprestimo} anos");

            // calculo o valor da prestação por mes
            float valorPrestacao = valorImovel / mesesEmprestimo;

            Console.WriteLine($"O valor da prestação mensal será de {valorPrestacao.ToString("C",ptBR)}");

            //Calculo do valor limite da prestação 
            float prestacaoLimite = salarioProp * limiteSalario;
            if (prestacaoLimite > valorPrestacao)
            {
                Console.WriteLine();
                Linha(col);
                Console.WriteLine();
                Console.WriteLine("Seu emprestimo foi Aprovado");
                Console.WriteLine();
                Linha(col);
            }
            else
            {
                Console.WriteLine();
                Linha(col);
                Console.WriteLine();
                Console.WriteLine("Seu emprestimo foi Negado");
                Console.WriteLine($"O limite da prestação para salario é de {prestacaoLimite.ToString("C", ptBR)}");
                Console.WriteLine();
                Linha(col);
            }
        }


        
        // Variaveis iniciais
        public static int col = 35; // tamanho da linha
        public static float limiteSalario = 0.30f;
         
                
                public static void Linha(int col)
        {
            for (int i = 0; i < col - 1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }
    }
}
