import Conta from './Conta.js';

export default class ContaPoupanca extends Conta {
  constructor(saldoInicial, agencia, cliente) {
    super(saldoInicial, agencia, cliente)
  };

  sacar(valor) {
    const taxa = 1.02;
    return this._sacar(valor, taxa);
  }
}
