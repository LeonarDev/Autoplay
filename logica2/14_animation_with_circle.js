var tela = document.querySelector('canvas');
var pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

function desenhaCirculo(x, y, raio) {
  pincel.fillStyle = 'blue';
  pincel.beginPath();
  pincel.arc(x, y, raio, 0, 2 * Math.PI);
  pincel.fill();
}

function limpaTela() {
  pincel.clearRect(0, 0, 600, 400);
}

let x = 20;
let sentido = 1;

function atualizaTela() {
  if (x > 595) {
    sentido = -1;
  } else if (x < 5) {
    sentido = 1;
  }
  limpaTela();
  pincel.fillStyle = 'lightgray';
  pincel.fillRect(0, 0, 600, 400);
  desenhaCirculo(x, 20, 10);
  x += sentido;

}

setInterval(atualizaTela, 10);