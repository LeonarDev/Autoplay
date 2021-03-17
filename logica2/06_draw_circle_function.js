let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

function desenhaCirculo(x, y, raio, cor) {
  pincel.fillStyle = cor;
  pincel.beginPath();
  pincel.arc(x, y, raio, 0, 2*3.14);
  pincel.fill();
}

desenhaCirculo(300, 200, 20, 'red')
desenhaCirculo(340, 200, 20, 'black')
desenhaCirculo(300, 240, 20, 'blue')
desenhaCirculo(260, 200, 20, 'orange')
desenhaCirculo(300, 160, 20, 'yellow')
