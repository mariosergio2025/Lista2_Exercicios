namespace Exercicio8
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
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: TipoDeCarro(); break;
                case 2: Dias(); break;
                case 3: Distancia(); break;
                case 4: Calculo(); break;
                case 5: ZeraPreenchimento(); break;
                case 6: break;
                default: Menu(); break;
            }

        }
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
