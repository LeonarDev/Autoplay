class Cliente {
  nome;
  cpf;
  agencia;
  saldo;
};

const CLIENTE_1 = new Cliente();
const CLIENTE_2 = new Cliente();

CLIENTE_1.nome = "Ricardo";
CLIENTE_1.cpf = 11122233309;
CLIENTE_1.agencia = 1001;
CLIENTE_1.saldo = 0;

CLIENTE_2.nome = "Alice";
CLIENTE_2.cpf = 88822233309;
CLIENTE_2.agencia = 1001;
CLIENTE_2.saldo = 0;

console.log(CLIENTE_1);
console.log(CLIENTE_2);
