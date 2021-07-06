using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total de contas: " + ContaCorrente.totalDeContas);

            ContaCorrente conta1 = new ContaCorrente(867, 86712540);
            Console.WriteLine("Total de contas: " + ContaCorrente.totalDeContas);

            Console.WriteLine("GetAgencia da conta1: " + conta1.Agencia); //getter
            Console.WriteLine("GetNumero da conta1: " + conta1.Numero); //getter

            ContaCorrente conta2 = new ContaCorrente(867, 86745820);
            Console.WriteLine("Total de contas: " + ContaCorrente.totalDeContas);

            Console.WriteLine("----------------");

            CalcularBonificacao();

            Console.WriteLine("----------------");

            UsarSistema();

            DateTime dataFinal = new DateTime(2023, 10, 31);
            DateTime dataAtual = DateTime.Now;
            TimeSpan prazo = dataFinal - dataAtual;
            string mensagemPrazo = "Prazo final em " + GetIntervaloDeDias(prazo);
            Console.WriteLine(mensagemPrazo);

            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        static string GetIntervaloDeDias(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if (quantidadeMeses == 1)
                {
                    return quantidadeMeses + " mês";
                }
                return quantidadeMeses + " meses";
            }
            return timeSpan.Days + " dias";
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            //Desenvolvedor guilherme = new Funcionarios.Desenvolvedor("456.175.468-20");
            //guilherme.Nome = "Guilherme";

            //gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
            gerenciadorBonificacao.GetTotalBonificacao());
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
        }
    }
}
