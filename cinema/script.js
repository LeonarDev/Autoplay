// bilhete = document.getElementById('bilhete');
let button = document.getElementById('comprar');
let preco = 26;


let isValid = () => {
  if (ingresso === 'Meia-entrada') {
    preco = 13;
  }

  alert(`BILHETE COMPRADO: 
  \n${filme} 
  \n${data} ${hora}
  \n Poltrona ${cadeira.value}
  \n${ingresso} entrada por R$ ${preco}
  \n`)
}

comprarIngresso = () => {
  filme = document.getElementById('filme').value;
  data = document.getElementById('data').value;
  hora = document.getElementById('hora').value;
  ingresso = document.getElementById('ingresso').value;
  // cadeira = document.getElementById('cadeira').value;
  cadeira = document.querySelector('input[type="radio"]:checked');

if (filme === '') {
  alert(`Favor selecionar um filme`);

} else if (data === '') {
  alert(`Favor selecionar uma data`);

} else if (hora === '') {
  alert(`Favor selecionar um horário`);

} else if (ingresso === '') {
  alert(`Favor selecionar o tipo de ingresso`);

} else if (cadeira === null) {
  alert(`Favor selecionar uma poltrona`);

} else {
  isValid();
}

  // cadeira === null ? alert(`Favor selecionar uma poltrona`) 
  // : filme === undefined ? alert(`Favor selecionar um filme`)
  // : isValid()

}


button.onclick = comprarIngresso;