namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ptBR = new System.Globalization.CultureInfo("pt-BR");
            Console.WriteLine("Digite o Valor do Saque: !");
            var entrada = Console.ReadLine();
            var valor = Convert.ToInt32(entrada);

            //Calculando o numero de notas de 200
            var qtdNotas200 = valor / 200;
            valor = valor -(qtdNotas200/200);
            if (qtdNotas200 > 0) { Console.WriteLine($"Entregando {qtdNotas200} de R$ 200,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque .."); }

            //Calculando o numero de notas 100
            var qtdNotas100 = valor / 100;
            valor = valor % 100;
            Console.WriteLine($"Entregando {qtdNotas100} de R$ 100,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            //Calculando o numero de notas 50
            var qtdNotas50 = valor / 50;
            valor = valor % 50;
            Console.WriteLine($"Entregando {qtdNotas50} de R$ 50,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            //Calculando o numero de notas 20
            var qtdNotas20 = valor / 20;
            valor = valor % 20;
            Console.WriteLine($"Entregando {qtdNotas20} de R$ 20,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            //Calculando o numero de notas 10
            var qtdNotas10 = valor / 10;
            valor = valor % 10;
            Console.WriteLine($"Entregando {qtdNotas10} de R$ 10,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            //Calculando o numero de notas 5
            var qtdNotas5 = valor / 5;
            valor = valor % 5;
            Console.WriteLine($"Entregando {qtdNotas5} de R$ 20,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            //Calculando o numero de notas 2
            var qtdNotas2 = valor / 2;
            valor = valor % 2;
            Console.WriteLine($"Entregando {qtdNotas2} de R$ 2,00 - Faltam {valor.ToString("C", ptBR)} reais do valor original do saque ..");

            Console.WriteLine(($"Entregando 1 de 1");
        }
    }
}
