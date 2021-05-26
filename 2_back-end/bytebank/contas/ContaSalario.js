import Conta from './Conta';

export default class ContaSalario extends Conta {
  constructor(cliente) {
    super(0, 1100, cliente)
  }

  sacar(valor) {
    const taxa = 1.01;
    
    return this._sacar(valor, taxa);
  }
}