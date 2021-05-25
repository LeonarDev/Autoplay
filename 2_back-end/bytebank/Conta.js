export default class Conta {
  static numeroDeContas = 0;
  _numero;

  constructor(saldoInicial, agencia, cliente) {
    Conta.numeroDeContas += 1
    this._numero = Conta.numeroDeContas;
    this._agencia = agencia;
    this._saldo = saldoInicial;
    this._cliente = cliente;
  };

  get saldo(){
    return this._saldo
  };
  
  set cliente(novoValor){
    if (novoValor instanceof Cliente) {
      this._cliente = novoValor;
    };
  };
  
  get cliente(){
    return this._cliente;
  };
  
  sacar(valor){
    let taxa = 1;
    return this._sacar(valor, taxa);
  };

  _sacar(valor, taxa) {
     const valorSacado = taxa * valor;

    if (this._saldo >= valorSacado){
      this._saldo -= valorSacado;
      return valorSacado;
    };

    return 0;
  }

  depositar(valor) {
    // valor <= 0 ? console.log(`Não é possível depositar ${valor}: valor negativo`) : this._saldo += valor;

    if (valor >= 0){
      this._saldo += valor;
      console.log(`Depósito realizado com sucesso no valor de R$ ${valor},00`);
    } else {
      console.log(`Não é possível depositar R$ ${valor},00 : valor negativo`);
    }
  };

  transferir(valor, conta) {
    const valorSacado = this.sacar(valor);
    conta.depositar(valorSacado);
  };
}