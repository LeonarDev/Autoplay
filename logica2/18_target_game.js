let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
let raio = 10;
let xAleatorio;
let yAleatorio;

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

desenhaAlvo = (x, y) => {
  desenhaCirculo(x, y, raio + 20, 'red');
  desenhaCirculo(x, y, raio + 10, 'white');
  desenhaCirculo(x, y, raio, 'red');
}

sorteiaPosicao = (maximo) => {
  return Math.floor(Math.random() * maximo);
}

atualizaTela = () => {
  limpaTela();

  xAleatorio = sorteiaPosicao(600);
  yAleatorio = sorteiaPosicao(400);
  
  desenhaAlvo(xAleatorio, yAleatorio);
}

setInterval(atualizaTela, 5000);

dispara = (evento) => {
  let x = evento.pageX - tela.offsetLeft 
  let y = evento.pageY - tela.offsetTop 
    
  if ( (x > xAleatorio - raio)
  && (x < xAleatorio + raio)
  && (y > yAleatorio - raio)
  && (y < yAleatorio + raio) ) {
    alert('BANG! NA MOSCA!');
  }
}
  
tela.onclick = dispara;