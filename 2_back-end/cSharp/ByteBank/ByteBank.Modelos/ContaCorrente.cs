// using ByteBank; linha necessária para identificar o namespace caso não contenha no arquivo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente do ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int totalDeContas { get; private set; }
        private static int TaxaOperacao;
        public int ContadorSaquesInvalidos { get; private set; }
        public int ContadorTransferenciasInvalidas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
        private double _saldo;
        public double Saldo
        {
            get
            {
            return this._saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        /// <summary>
        /// Cria uma instância de Conta Corrente com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir valor maior que zero</param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir valor maior que zero</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0) throw new ArgumentException("O argumento 'Agencia' deve ser maior que ZERO.", nameof(agencia));
            if (numero <= 0) throw new ArgumentException("O argumento 'Numero' deve ser maior que ZERO.", nameof(numero));

            Agencia = agencia;
            Numero = numero;
            totalDeContas++;
            TaxaOperacao = 30 / totalDeContas;
        }

        public void Depositar(double valor) {
            if (valor > 0) this._saldo += valor;
        }

        /// <summary>
        /// Realiza o saque e atualiza o valor da proopriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando um valor negativo é utilizado no argumento <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/>.</exception>
        /// <param name="valor">Representa o vlaor do saque, deve ser maior que zero e maior que o <see cref="Saldo"/></param>
        public void Sacar(double valor)
        {
            if (valor < 0) throw new ArgumentException("Valor inválido para o saque.", nameof(valor));

            if (this._saldo < valor)
            {
                ContadorSaquesInvalidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            this._saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                ContadorTransferenciasInvalidas++;
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasInvalidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }
}
