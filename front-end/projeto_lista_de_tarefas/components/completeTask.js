const CheckButton = () => {
  const checkButton = document.createElement('button');

  checkButton.classList.add('check-button');
  checkButton.innerText = 'concluir';
  checkButton.addEventListener('click', checkTask);

  return checkButton;
}

const checkTask = (event) => {
  const checkButton = event.target;
  const checkTask = checkButton.parentElement;

  checkTask.classList.toggle('done');
}

export default CheckButton;
