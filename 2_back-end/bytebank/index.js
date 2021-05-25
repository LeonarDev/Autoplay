import Cliente from './Cliente.js';
import ContaCorrente from './ContaCorrente.js';
import ContaPoupanca from './ContaPoupanca.js';

const CLIENTE_1 = new Cliente("Ricardo", 11122233309);
const CLIENTE_2 = new Cliente("Alice", 88822233309);

const CONTA_1 = new ContaCorrente(1001, CLIENTE_1);
const CONTA_2 = new ContaPoupanca(0, 1001, CLIENTE_2);

console.log('---------------------------------------------------------------------');
console.log('');
console.log('CONTA INICIAL:');
console.log('');
console.log(CONTA_1);

console.log('');
console.log('---------------------------------------------------------------------');
console.log('');


console.log('DEPÓSITO DE VALOR NEGATIVO:');
console.log('');
CONTA_1.depositar(-500);

console.log('');
console.log(CONTA_1);

console.log('');
console.log('---------------------------------------------------------------------');
console.log('');

console.log('DEPÓSITO DE VALOR POSITIVO:');
console.log('');
CONTA_1.depositar(200);

console.log('');
console.log(CONTA_1);