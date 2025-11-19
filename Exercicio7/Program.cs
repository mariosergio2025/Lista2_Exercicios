using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Xml;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Menu();
        }
        // Variaveis iniciais
        public static int col = 35; // tamanho da linha
        // se vai logia do preenchido
        public static bool preenchidoTipo = false;
        public static bool preenchidoDias = false;
        public static bool preenchidoDistancia = false;
        // valores inciais do dados preenchidos pelo usuario
        public static string tipo = "";
        public static int dias = 0;
        public static float distancia = 0.00f;
        // Valores dos Alugueis
        public static float popularAluguel = 90;
        public static float popularAluguelAte100 = 0.20f;
        public static float popularAulguelPos100= 0.10f;
        public static float luxoAluguel = 150;
        public static float luxoAluguelAte200 = 0.30f;
        public static float luxoAluguelPos200 = 0.25f;


        public static void Menu()
        {
           

            Console.Clear();
            Linha(col);
            Console.WriteLine("--------- MENU --------");
            Linha(col);
            //verifica se ja foi preenchido
            if (preenchidoTipo) { Console.WriteLine("OK  1 - Tipo de Carro"); } else { Console.WriteLine("    1 - Tipo de Carro"); }
            if (preenchidoDias) { Console.WriteLine("OK  2 - Dias de Aluguel"); } else { Console.WriteLine("    2 - Dias de Aluguel"); }
            if (preenchidoDistancia) { Console.WriteLine("OK  3 - Distancia Percorrida"); } else { Console.WriteLine("    3 - Distancia Percorrida"); }
     
            Console.WriteLine("    4 - Calcular Valor");
            Console.WriteLine("    5 - Zeras preenchimentos");
            Console.WriteLine("    6 - Sair");
            Linha(col);
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: TipoDeCarro(); break;
                case 2: Dias(); break;
                case 3: Distancia(); break;
                case 4: Calculo(); break;
                case 5: ZeraPreenchimento();break;
                case 6: break;   
                default: Menu(); break;
            }
                
        }
        public static void TipoDeCarro()
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("Qual o tipo de carro ");
                Console.WriteLine("L - para Luxo");
                Console.WriteLine("P - para Popular");
                tipo = Console.ReadLine();
                
            } while (tipo != "P" && tipo != "L" && tipo !="p" && tipo!="l");
            if (tipo == "P" || tipo == "p") { tipo = "Popular"; } else { tipo = "Luxo"; }
                preenchidoTipo = true;
            Menu();                     

        }

        public static void ZeraPreenchimento()
        {
        preenchidoTipo = false;
        preenchidoDias = false;
        preenchidoDistancia = false;
        tipo = "";
        dias = 0;
        distancia = 0.00f;
        Menu();
        }

        public static void Dias()
        {
            Console.Clear();
            Console.WriteLine("Quantos dia de aluguel? ");
            dias = Convert.ToInt32(Console.ReadLine());
            preenchidoDias = true;
            Menu();

        }
        public static void Distancia()
        {
            Console.Clear();
            Console.WriteLine("Quantos Km você percorreu? ");
            distancia = Convert.ToSingle(Console.ReadLine());
            preenchidoDistancia = true;
            Menu();

        }
        public static void Calculo()
        {
            string espera = "";
            Console.Clear();
            Linha(col);
            Console.WriteLine("-----------Calculando---------");
            Linha(col);
            Console.WriteLine("");
        
            if (preenchidoTipo == false || preenchidoDias == false ||preenchidoDistancia==false)
            {
                Console.WriteLine("Acabe de preencher os dados antes de calcular");
                Console.WriteLine("Tecle Enter para retornar ao Menu");
                espera = Console.ReadLine();
                Menu();
            }
        
            Console.WriteLine($"Vc alugou um carro tipo: {tipo}");
            Console.WriteLine($"Alugado pelo periodo de {dias} dias");
            Console.WriteLine($"E percorreu uma distancia de {distancia} km");
            Console.WriteLine("");
            Linha(col);
            Console.WriteLine("");
            float valorPercurso = 0;
            float valorAlguel = 0;

            if (tipo == "Popular") 
            {
                
                valorAlguel = popularAluguel * dias;
                if (distancia <= 100)
                {
                    valorPercurso = distancia * popularAluguelAte100;
                }
                else
                { 
                    valorPercurso = distancia * popularAulguelPos100;
                           
                }
              
            }
            else
            {
                
                valorAlguel = luxoAluguel * dias;
                if (distancia <= 200)
                {
                    valorPercurso = distancia * luxoAluguelAte200;
                }
                else
                {
                    valorPercurso = distancia * luxoAluguelPos200;

                }
                
            }
            Console.WriteLine($"Valor do Aluguel _________{valorAlguel.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
            Console.WriteLine($"Valor do Km percorrido _____{valorPercurso.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
            Linha(col);
            float valorTotal = valorAlguel + valorPercurso;
            Console.WriteLine($"Valor Total do Aluguel ___{valorTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
            Console.WriteLine();
            Linha(col);
            Console.WriteLine();
            Console.WriteLine("Tecle Enter para retornar ao Menu");
            espera = Console.ReadLine();
            Menu();
                          

        }


        public static void Linha(int col)
        {
            for (int i = 0; i < col-1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

    }
}
