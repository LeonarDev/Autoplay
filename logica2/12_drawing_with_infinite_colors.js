let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');

pincel.fillStyle = 'lightgrey';
pincel.fillRect(0, 0, 600, 400);

let desenha = false;

let color = document.querySelector('input');

function desenhaCirculo(evento) {
  if(desenha) {
    let x = evento.pageX - tela.offsetLeft;
    let y = evento.pageY - tela.offsetTop;
    pincel.fillStyle = color.value;
    pincel.beginPath();
    pincel.arc(x, y, 10, 0, 2 * 3.14);
    pincel.fill();
  }
  console.log(x + ',' + y);
}

tela.onmousemove = desenhaCirculo;

function habilitaDesenhar() {
  desenha = true;
}

function desabilitaDesenhar() {
  desenha = false;
}

tela.onmousedown = habilitaDesenhar;

tela.onmouseup = desabilitaDesenhar;
