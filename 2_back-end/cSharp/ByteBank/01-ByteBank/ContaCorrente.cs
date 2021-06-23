// using ByteBank; linha necessária para identificar o namespace caso não contenha no arquivo

namespace ByteBank
{
    public class ContaCorrente
    {
        public ContaCorrente(int agencia, int numero) {
            Agencia = agencia;
            Numero = numero;
            totalDeContas++;
        }

        public static int totalDeContas { get; private set; }

        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo;

        public double getSaldo() { return this._saldo; }

        public void Depositar(double valor) {
            if (valor > 0) this._saldo += valor;
        }

        public bool Sacar(double valor) {
            if (this._saldo < valor) {
                return false;
            } 
            this._saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (this._saldo < valor) {
                return false;
            } 
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
