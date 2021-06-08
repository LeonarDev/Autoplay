let divSprite = document.querySelector('.sprite');
let frameAtual = 1;
let frameFinal = 9;
let isFinished = false;

nextFrame = () => {
  let addFrame = `frame${frameAtual += 1}`
  if (frameAtual <= frameFinal) divSprite.classList.add(addFrame);
  if (frameAtual == frameFinal) isFinished = true;
}

let resetButton = document.querySelector('#reset-game');
resetButton.addEventListener('click', () => {
  window.location.reload()
})
