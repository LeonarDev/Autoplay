desenhaQuadrado = (x, y, cor) => {
  let tela = document.querySelector('canvas');
  let pincel = tela.getContext('2d');

  pincel.fillStyle = cor;
  pincel.fillRect(x, y, 50, 50);
  pincel.fillStroke = 'black';
  pincel.strokeRect(x, y, 50, 50);
}

for (let x = 0; x < 600; x += 50) {
  desenhaQuadrado(x, 0, 'green'); 
}
