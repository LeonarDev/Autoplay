using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtraiValorArgumento
    {
        private readonly string _argumentos;   
        public string URL { get; }

        //string url = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=2000";

        public ExtraiValorArgumento(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumeno 'url' não pode ser nulo ou vazio.", nameof(url));
            }

            _argumentos = url.Substring(url.IndexOf('?') + 1);
            URL = url;
        }
        
        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string parametro)
        {
            string query = parametro.ToLower() + "=";
            string argumentosLowerCase = _argumentos.ToLower();
            int indiceQuery= argumentosLowerCase.IndexOf(query);
            string resultado = _argumentos.Substring(indiceQuery + query.Length);
            int indiceEcomercial = resultado.IndexOf("&");

            if (indiceEcomercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEcomercial);
        }
    }
}
