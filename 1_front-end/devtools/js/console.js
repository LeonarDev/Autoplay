console.group('Tipos de mensagens do console');
  console.log('mensagem padrão no console');
  console.error('mensagem de erro no console');
  console.warn('mensagem de aviso no console');
console.groupEnd();

console.table([
  ['info 1','info 2','info 3'],
  [2,3,4]
]);

console.table([
  {'nome da Coluna': 'Informação 1', numero: 12},
  {coluna: 'info 2'},
  {numero: 2,}
]);
