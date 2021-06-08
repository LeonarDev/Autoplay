let divSprite = document.querySelector('.sprite');
let frameAtual = 1;
let frameFinal = 9;

setInterval(() => {
  if (frameAtual <= frameFinal) divSprite.classList.add(`frame${frameAtual += 1}`)
}, 500);
