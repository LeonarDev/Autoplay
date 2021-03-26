let birthdayInput = document.getElementById('birthday');
let button = document.getElementById('button');
let resultMessage = document.getElementById('result-message');
let image = document.getElementById('image');
let age;
let selectedGender;

const getAge = () => {
  return age = new Date().getFullYear() - birthdayInput.value;
}

const checkGender = (gender) => {
  image.src = `img/${gender}.png`;
  
  gender === 'male' || gender === 'female' ? 
    resultMessage.innerHTML = `Avaliado - ${selectedGender.value} com ${age} anos de idade` 
    : resultMessage.innerHTML = `Informe um ano de nascimento válido!`
}

button.addEventListener('click', () => {
  selectedGender = document.querySelector('input[type="radio"]:checked');
  getAge();

  selectedGender.value === 'Homem' && age > 0 && age <= 100 ? checkGender('male')
  : (selectedGender.value === 'Mulher' && age > 0 && age <= 100) ? checkGender('female') 
  : checkGender('error');
})
