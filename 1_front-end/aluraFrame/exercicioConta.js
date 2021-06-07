class Conta {
  constructor(saldo) {
    this._saldo = saldo;
  }

  get saldo() {
    return this._saldo;
  }

  atualiza(taxa) {
    throw new Error('É necessário chamar este método com uma classe filha');
  }
}

class ContaCorrente extends Conta {
  atualiza(taxa) {
    this._saldo += taxa;
  }
}

class ContaPoupanca extends Conta {
  atualiza(taxa) {
    this._saldo += (taxa * 2);
  }
}

conta1 = new ContaCorrente(100);
conta2 = new ContaPoupanca(100);

conta1.atualiza(2);
conta2.atualiza(2);

console.log(conta1.saldo);
console.log(conta2.saldo);
