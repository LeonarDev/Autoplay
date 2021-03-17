let tela = document.querySelector('canvas');
let pincel = tela.getContext('2d');
pincel.fillStyle = 'lightgray';
pincel.fillRect(0, 0, 600, 400);

desenhaQuadrado = (x, y, tamanho, cor) => {
  pincel.fillStyle = cor;
  pincel.beginPath();
  pincel.fillRect(x, y, tamanho, tamanho);
  pincel.strokeRect(x, y, tamanho, tamanho)
}

desenhaTexto = (texto, x , y) => {
  pincel.font='20px Georgia';
  pincel.fillStyle='black';
  pincel.fillText(texto, x, y);    
}

desenhaTexto("Qual é a fração?", 50, 30);

desenhaQuadrado(50, 50, 100, 'green');
desenhaQuadrado(150, 50, 100, 'green');
desenhaQuadrado(250, 50, 100, 'green');
desenhaQuadrado(350, 50, 100, 'white');
