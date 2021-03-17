let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

desenhaRetangulo = (x, y, largura, altura, cor) => {
pincel.fillStyle=cor;
pincel.fillRect(x,y, largura, altura);
pincel.strokeStyle='black';
pincel.strokeRect(x,y, largura, altura);
}

desenhaTexto = (x, y, texto) => {
var tela = document.querySelector('canvas');
var pincel = tela.getContext('2d');

pincel.font='15px Georgia';
pincel.fillStyle='black';
pincel.fillText(texto, x, y);
}

var serie2015 = [50, 25, 20, 5];
var serie2016 = [65, 20, 13, 2];
var cores = ['blue', 'green', 'yellow', 'red'];

desenhaBarra = (x, y, serie, cores, texto) => {
desenhaTexto(x, y - 10, texto);

let somaAltura = 0;

for (let index = 0; index < serie.length; index += 1) {
  let altura = serie[index];
  desenhaRetangulo(x, y + somaAltura, 50, altura, cores[index]);
  somaAltura += altura;
}
}

desenhaBarra(50, 50, serie2015, cores, '2015');
desenhaBarra(150, 50, serie2016, cores, '2016');
