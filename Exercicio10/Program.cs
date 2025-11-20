using System.Globalization;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caixa Eletronico Virtual");
            Console.WriteLine("------------------------------------");
            // variavel para facilicar - formatação moeda PT-BR
            var ptBR = CultureInfo.CreateSpecificCulture("pt-BR");

            // Notas Disponiveis 
            var notaDisp = new int[] { 200, 10, 50, 20, 100, 5, 2, 1 };
            int troca = 0;

            //Colocar em ordem decrescente as notas do dinheiro
            for (int j = 0; j<notaDisp.Length-1;j++)

            { 
                for (int i = 0; i < notaDisp.Length - 1; i++)
                {
                    troca = notaDisp[i + 1];

                    if (notaDisp[i] < notaDisp[i + 1])
                    {
                        troca = notaDisp[i];
                        notaDisp[i] = notaDisp[i + 1];
                        notaDisp[i + 1] = troca;
                    }

                }
            }
            // Desconsider as notas de 0 e apresenta as disponiveis
            int tiposDifNotas = 0;
            Console.WriteLine();
            Console.Write("Notas Disponiveis ");
            
            for (int i = 0; i < notaDisp.Length; i++)
            {
                if (notaDisp[i] != 0) 
                {
                    tiposDifNotas++;
                    Console.Write(" - "+notaDisp[i].ToString("C",ptBR));
                }
            }
            Console.WriteLine();

            // Entrado do valor desejado
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.Write("Digite o Valor do Saque: ");
            var entrada = Console.ReadLine();
            var valor = Convert.ToInt32(entrada);

            // incializa uma variavel para não perder quanto a pessoa sacou
            var restante = valor;
            int numNotas = 0;

            //Apresenta o calculo de saque de cada nota
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < tiposDifNotas; i++)
            {
                numNotas = 0;
                while (restante>=notaDisp[i])
                {
                    
                        restante = restante - notaDisp[i];
                        numNotas = numNotas + 1;
                }
                
                if (numNotas != 0) { Console.WriteLine($"Saque de {numNotas} nota de {notaDisp[i].ToString("C",ptBR)}"); }
                
            }
            // Caso tenha sobrado dinheiro avisa que não foi possivel
            if (restante >0) { Console.WriteLine($"Saque de {restante.ToString("C",ptBR)} não foi possiviel, por falta de notas"); }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();

          
            /* Exemplo feito pelo professor em sala
             
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

            Console.WriteLine("Entregando 1 de 1");
            */
        }
    }
}
