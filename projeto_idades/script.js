let birthdayInput = document.getElementById('birthday');
let button = document.getElementById('button');
let resultMessage = document.getElementById('result-message');
let image = document.getElementById('image');
let age;
let selectedGender;

const getAge = () => {
  return age = new Date().getFullYear() - birthdayInput.value;
}

const man = () => {
  image.src = 'img/homem.png';
  resultMessage.innerHTML = `Avaliado - ${selectedGender.value} com ${age} anos de idade`;
}

const woman = () => {
  image.src = 'img/mulher.png';
  resultMessage.innerHTML = `Avaliado - ${selectedGender.value} com ${age} anos de idade`;
}

const invalid = () => {
  image.src = 'img/erro.png';
  resultMessage.innerHTML = `Informe um ano de nascimento válido!`;
}

button.addEventListener('click', () => {
  selectedGender = document.querySelector('input[type="radio"]:checked');
  getAge();

  if (selectedGender.value === 'Homem' && age > 0 && age < 100) {
    man();
  } else if (selectedGender.value === 'Mulher' && age > 0 && age < 100) {
    woman();
  } else {
    invalid();
  }
})
