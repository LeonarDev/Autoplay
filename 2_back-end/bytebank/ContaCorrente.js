import Cliente from './Cliente.js';

export default class ContaCorrente {
  static numeroDeContas = 0;
  agencia;
  numeroDaConta;
  cliente;
  
  _saldo = 0;
  
  get saldo(){
    return this._saldo
  };
  
  set cliente(novoValor){
    if(novoValor instanceof Cliente){
      this._cliente = novoValor;
    };
  };
  
  get cliente(){
    return this._cliente;
  };
  
  constructor(agencia, cliente){
    ContaCorrente.numeroDeContas += 1
    this.numeroDaConta = ContaCorrente.numeroDeContas;
    this.agencia = agencia;
    this.cliente = cliente;
  };
  
  sacar(valor){
    if(this._saldo >= valor){
      this._saldo -= valor;
      return valor;
    };
  };

  depositar(valor){
    if(valor <= 0){
      return;
    };
    this._saldo += valor;
  };

  transferir(valor, conta){
    const valorSacado = this.sacar(valor);
    conta.depositar(valorSacado);
  };
};
