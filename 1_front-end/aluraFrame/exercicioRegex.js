// PROCEDURAL:

// let codigo = 'GWZ-JJ-12';

// function validaCodigo(codigo) {
//   if(/\D{3}-\D{2}-\d{2}/.test(codigo)) {
//     alert('Código válido!');
//   } else {
//     alert('Código inválido');
//   }
// }

// validaCodigo('GWZ-JJ-12'); // válido
// validaCodigo('1X1-JJ-12'); // inválido


// --------------------------------------------------------------------


// ORIENTADO A OBJETOS (EXEMPLO 1):

// class exercicioRegex {
//   constructor(codigo) {

//     if (!/\D{3}-\D{2}-\d{2}/.test(codigo)) {
//       throw new Error('Código inválido')
//     }
//     this._codigo = codigo
//   }

//   get codigo() {
//     return this._codigo;
//   }
// }

// let codigo1 = new exercicioRegex('GWZ-JJ-12');
// let codigo2 = new exercicioRegex('1X1-JJ-12');

// console.log(codigo1); // código válido
// console.log(codigo2); // código inválido


// --------------------------------------------------------------------


// ORIENTADO A OBJETOS (EXEMPLO 2):

class Codigo{
  constructor(codigo) {
      this.setCodigo(codigo)
  }

  setCodigo(codigo) {
      if (!/\D{3}-\D{2}-\d{2}/.test(codigo)) {
          throw new Error('Código inválido')
      }
      this.codigo = codigo
  }
}

let codigo3 = new Codigo('GWZ-JJ-12');
console.log(codigo3);
// let codigo4 = new Codigo('1X1-JJ-12');
