import Conta from './Conta.js';

export default class ContaPoupanca extends Conta {
  constructor(saldoInicial, agencia, cliente) {
    super(saldoInicial, agencia, cliente)
  };
}
