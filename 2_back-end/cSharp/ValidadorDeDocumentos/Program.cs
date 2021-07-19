using Caelum.Stella.CSharp.Validation;
using System;
using System.Diagnostics;

namespace ValidadorDeDocumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";

            string cnpj1 = "17175450133770";
            string cnpj2 = "45700718735752";

            string tituloEleitor1 = "31550558143";
            string tituloEleitor2 = "777541881422";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            ValidarTituloEleitoral(tituloEleitor1);
            ValidarTituloEleitoral(tituloEleitor2);
        }

        private static void ValidarCPF(string cpf)
        {
            try
            {
                new CPFValidator().AssertValid(cpf);
                Console.WriteLine($"CPF válido: {cpf}");
                Console.WriteLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine($"CPF inválido: {cpf} : {exc.ToString()}");
                Console.WriteLine();
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Console.WriteLine($"CNPJ válido: {cnpj}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"CNPJ inválido: {cnpj}");
                Console.WriteLine();
            }
        }

        private static void ValidarTituloEleitoral(string tituloEleitor)
        {
            if (new TituloEleitoralValidator().IsValid(tituloEleitor))
            {
                Console.WriteLine($"Título Eleitoral válido: {tituloEleitor}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Título Eleitoral inválido: {tituloEleitor}");
                Console.WriteLine();
            }
        }
    }
}
