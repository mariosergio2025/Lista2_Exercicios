using System.ComponentModel.Design;
using System.Globalization;

namespace Exercicio8
{
    internal class Program
    {
        // Variaveis iniciais
        public static int col = 35; // tamanho da linha
        // se vai logia do preenchido
        public static bool preenchidoNome = false;
        public static bool preenchidoSalario = false;
        public static bool preenchidoAnos = false;
        // valores inciais do dados preenchidos pelo usuario
        public static string nome = "";
        public static float salario = 0;
        public static float anos = 0.00f;
        // Tabela Reajuste salario
        public static float aumento3 = 1.03f;
        public static float aumenta3a10 = 1.125f;
        public static float aumenta10eacima = 1.20f;
        public static float novosalario = 0.00f;
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Linha(int col)
        {
            for (int i = 0; i < col - 1; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-");
        }

       

        public static void Menu()
        {
            Console.Clear();
            Linha(col);
            Console.WriteLine("--------- MENU --------");
            Linha(col);
            //verifica se ja foi preenchido
            if (preenchidoNome) { Console.WriteLine("OK  1 - Nome Funcionario"); } else { Console.WriteLine("    1 - Nome Funcionario"); }
            if (preenchidoSalario) { Console.WriteLine("OK  2 - Salario Funcionario"); } else { Console.WriteLine("    2 - Salario Funcionario"); }
            if (preenchidoAnos) { Console.WriteLine("OK  3 - Tempo de Empresa"); } else { Console.WriteLine("    3 - Tempo de Empresa"); }

            Console.WriteLine("    4 - Calcular Valor Salario");
            Console.WriteLine("    5 - Zeras preenchimentos");
            Console.WriteLine("    6 - Sair");
            Linha(col);
            
            string opcao = Console.ReadLine();

            switch (Convert.ToInt32(opcao))
            {
                case 1: NomeFunciorio(); break;
                case 2: SalarioFuncionario(); break;
                case 3: TempoEmpresa(); break;
                case 4: Calculo(); break;
                case 5: ZeraPreenchimento(); break;
                case 6: break;
                default: Menu(); break;
            }

        }
        public static void NomeFunciorio()
        {
            Console.Clear();
            Linha(col);
            Console.Write("Digite o nome completo do funcionario : ");
            nome = Console.ReadLine();
            Linha(col);
            Console.WriteLine("Nome do funcionario cadastrado...");
            Linha(col);
            preenchidoNome = true;
            Console.WriteLine();
            Console.WriteLine("<Precione uma tecla para voltar ao Menu>");
            Console.ReadKey();
            Menu();
        }


        public static void SalarioFuncionario()
        {
            Console.Clear();
            Linha(col);
            Console.Write("Digite o salario atual do funcionario : ");
            salario = Convert.ToSingle(Console.ReadLine());
            Linha(col);
            Console.WriteLine("Salario Atual Cadastrado...");
            preenchidoSalario=true;
            Console.WriteLine();
            Console.Write("<Precione uma tecla para voltar ao Menu>");
            Console.ReadKey();
            Menu(); 
        }

        public static void TempoEmpresa()
        {
            Console.Clear();
            Linha(col);
            Console.Write("Digite tempo de empresa em Anos: ");
            anos = Convert.ToSingle(Console.ReadLine());
            Linha(col);
            Console.WriteLine("Tempo de empresa cadastrado...");
            preenchidoAnos = true;
            Console.WriteLine();
            Console.Write("<Precione uma tecla para voltar ao Menu>");
            Console.ReadKey();
            Menu();
        }


        public static void Calculo()
        {
            Console.Clear();
            Linha(col);
            var ptbr = CultureInfo.CreateSpecificCulture("pt-br");              
            if (preenchidoNome==false || preenchidoSalario==false || preenchidoAnos==false)
            {
                Console.WriteLine("Voce ainda não cadastros todos os dados, volte ao menu e finalize");
                Console.WriteLine("<Precione uma tecla para voltar ao Menu>");
                Console.ReadKey(); 
                Menu();
            }
            Console.WriteLine($"Nome : {nome}");
            Console.WriteLine($"Salario atual: {salario.ToString("C",ptbr)}");
            Console.WriteLine($"Tempo de empresa : {anos} anos");
            Linha(col);

            if(anos <3) { novosalario = salario * aumento3; }
            if (anos >= 3 && anos <10) { novosalario = salario * aumenta3a10; }
            if (anos >= 10) { novosalario = salario * aumenta10eacima; }
            Console.WriteLine($"O novo salario : {novosalario.ToString("C", ptbr)}");
            Linha(col);
            Console.WriteLine();
            Console.Write("<Precione uma tecla para voltar ao Menu>");
            Console.ReadKey();
            Menu();
        }

        public static void ZeraPreenchimento()
        {

            preenchidoNome = false;
            preenchidoSalario = false;
            preenchidoAnos = false;
            nome = "";
            salario = 0.00f;
            anos = 0.00f;
            Menu();
            
        }
    }


}
