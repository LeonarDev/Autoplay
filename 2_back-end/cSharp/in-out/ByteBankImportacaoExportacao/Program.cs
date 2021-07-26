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
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

            var bytesAquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"O arquivo contas.txt possui {bytesAquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.WriteLine("Digite o seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação finalizada. . .");

            Console.ReadLine();

            //EscritaBinaria();
            //LeituraBinaria();
            //Console.WriteLine("Aplicação finalizada.");

            //Console.ReadLine();
        }
    }
} 
 