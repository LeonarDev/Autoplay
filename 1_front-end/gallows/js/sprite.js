var divSprite = document.querySelector('.sprite');
var frameAtual = 1;
var frameFinal = 9;

setInterval(() => {
  if (frameAtual <= frameFinal) {
    divSprite.classList.add(`frame${frameAtual += 1}`)
  }
}, 500);
