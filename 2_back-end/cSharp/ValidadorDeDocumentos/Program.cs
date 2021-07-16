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
            //string cpf2 = "98745366797";
            //string cpf3 = "22222222222";


            try
            {
                new CPFValidator().AssertValid(cpf1);
                Debug.WriteLine($"CPF válido: {cpf1}");
            }
            catch (Exception exc)
            {
                Debug.WriteLine($"CPF inválido: {cpf1} : {exc}");
            }
        }
    }
}
