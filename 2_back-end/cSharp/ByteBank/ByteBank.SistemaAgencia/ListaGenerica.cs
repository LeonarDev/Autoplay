using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class ListaGenerica<tipoGenerico>
    {
        private tipoGenerico[] _itens;
        private int _posicaoAtual;

        public int Tamanho
        {
            get
            {
                return _posicaoAtual;
            }
        }

        public ListaGenerica(int capacidadeInicial = 5)
        {
            _itens = new tipoGenerico[capacidadeInicial];
            _posicaoAtual = 0;
        }

        public void MeuMetodo(string texto = "string", int numero = 5)
        {
        }

        public void Adicionar(tipoGenerico item)
        {
            VerificarCapacidade(_posicaoAtual + 1);
            _itens[_posicaoAtual] = item;
            _posicaoAtual++;
        }

        public void AdicionarVarios(params tipoGenerico[] itens)
        {
            foreach (tipoGenerico item in itens)
            {
                Adicionar(item);
            }
        }

        public void Remover(tipoGenerico item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _posicaoAtual; i++)
            {
                tipoGenerico itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _posicaoAtual - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _posicaoAtual--;
        }

        public tipoGenerico GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _posicaoAtual)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            tipoGenerico[] novoArray = new tipoGenerico[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }

        public tipoGenerico this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
