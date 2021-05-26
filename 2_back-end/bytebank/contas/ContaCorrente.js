import Conta from './Conta.js';

export default class ContaCorrente extends Conta {  
  constructor(agencia, cliente){
    super(0, agencia, cliente);
  };

  // sobreescrevendo o comportamento de sacar da "classe mãe"
  sacar(valor) {
    let taxa = 1.1;
    return super._sacar(valor, taxa);
  }
};
