using System;
using System.Net.Http;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            // webservice para consultar CEP: http://viacep.com.br/
            // exemplo: http://viacep.com.br/ws/01001000/json/

            string cep = "01001000";
            string url = $"http://viacep.com.br/ws/{cep}/json/";

            string result = new HttpClient().GetStringAsync(url).Result;

            Console.WriteLine($"Resultado da url {url} :");
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
