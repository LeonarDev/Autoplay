let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

desenhaEsquadro = (xa, ya, xc, yc, cor1, cor2) => {
  pincel.fillStyle = cor1;
  pincel.beginPath();
  pincel.moveTo(xa, ya);
  pincel.lineTo(xa, yc);
  pincel.lineTo(xc, yc);
  pincel.fill();

  pincel.fillStyle = cor2;
  pincel.beginPath();
  pincel.moveTo(xa + 50, ya + 125);
  pincel.lineTo(xa + 50, yc - 50);
  pincel.lineTo(xc - 125, yc - 50);
  pincel.fill();
}

desenhaEsquadro(50, 50, 400, 400, 'purple', 'lightgray')
