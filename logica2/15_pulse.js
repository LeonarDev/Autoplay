let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

function desenhaCirculo(x, y, raio, cor) {
  pincel.fillStyle = cor;
  pincel.beginPath();
  pincel.arc(x, y, raio, 0, 2 * Math.PI);
  pincel.fill();
}

function limpaTela() {
  pincel.clearRect(0, 0, 600, 400);
}

let raio = 20;
let fluxo = 1;

pulse = () => {
  if (raio < 20) {
    fluxo = 1;
  } else if ( raio > 30 ) {
    fluxo = -1;
  }
  
  limpaTela();
  pincel.fillStyle = 'lightgray';
  pincel.fillRect(0, 0, 600, 400);
  raio += fluxo;
  desenhaCirculo(300, 100, raio, 'purple')
}

setInterval(pulse, 100)