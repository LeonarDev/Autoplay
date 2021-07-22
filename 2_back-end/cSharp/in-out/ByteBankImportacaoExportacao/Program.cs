using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args)
        {
            //LidandoComFileStream();

            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                //var linha = leitor.ReadToEnd();  -> Carrega todo o conteúdo do arquivo de uma só vez (pode travar a aplicação) É recomendável não usar

                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverteStringParaContaCorrente(linha);

                    Console.WriteLine($"Conta Corrente => Número: {contaCorrente.Numero} | Agência: {contaCorrente.Agencia} | Saldo: {contaCorrente.Saldo} | Titular: {contaCorrente.Titular.Nome}");
                    //Console.WriteLine(linha);
                }
            }

            Console.ReadLine();
        }

        static ContaCorrente ConverteStringParaContaCorrente(string linha)
        {
            string[] camposDocumento = linha.Split(' ');

            var agenciaString = camposDocumento[0];
            var numeroString = camposDocumento[1];
            var saldoString = camposDocumento[2].Replace('.', ',');
            var nomeTitular = camposDocumento[3];

            var agenciaInt = int.Parse(agenciaString);
            var numeroInt = int.Parse(numeroString);
            var saldoDouble = double.Parse(saldoString);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);
            resultado.Titular = titular;

            return resultado;
        }
    }
} 
 