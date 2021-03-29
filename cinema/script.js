let button = document.getElementById('comprar');
let preco = 26;

let isValid = () => {
  if (ingresso === 'Meia-entrada') {
    preco = 13;
  }

  alert(`BILHETE COMPRADO: 
  \n${filme} \n${data} às ${hora} \n Poltrona ${cadeira.value} \n${ingresso} por R$ ${preco} \n`)
}

comprarIngresso = () => {
  filme = document.getElementById('filme').value;
  data = document.getElementById('data').value;
  hora = document.getElementById('hora').value;
  ingresso = document.getElementById('ingresso').value;
  cadeira = document.querySelector('input[type="radio"]:checked');

  filme === '' ? alert(`Favor selecionar um filme`)
  : data === '' ? alert(`Favor selecionar uma data`)
  : hora === '' ? alert(`Favor selecionar um horário`)
  : ingresso === '' ? alert(`Favor selecionar o tipo de ingresso`)
  : cadeira === null ? alert(`Favor selecionar uma poltrona`) 
  : isValid();
}

button.onclick = comprarIngresso;
