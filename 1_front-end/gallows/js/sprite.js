// var sprite = createSprite('.sprite');

let divSprite = document.querySelector('.sprite');
let frameAtual = 1;
let frameFinal = 9;
let isFinished = false;

setInterval(() => {
  let nextFrame = `frame${frameAtual += 1}`
  if (frameAtual <= frameFinal) divSprite.classList.add(nextFrame);
  if (frameAtual == frameFinal) isFinished = true;
}, 500);


let resetButton = document.querySelector('#reset-game');
resetButton.addEventListener('click', () => {
  window.location.reload()
})
