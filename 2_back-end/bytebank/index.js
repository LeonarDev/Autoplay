import Cliente from './Cliente.js';
import ContaCorrente from './ContaCorrente.js';

const CLIENTE_1 = new Cliente("Ricardo", 11122233309);
const CLIENTE_2 = new Cliente("Alice", 88822233309);

const CONTA_1 = new ContaCorrente(1001, CLIENTE_1);
const CONTA_2 = new ContaCorrente(1002, CLIENTE_2);





// console.log(CLIENTE_2.cpf);
console.log(CONTA_1);
console.log('');
console.log(CONTA_2);
