// using ByteBank; linha necessária para identificar o namespace caso não contenha no arquivo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
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
