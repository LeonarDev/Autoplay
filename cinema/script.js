bilhete = document.getElementById('bilhete');
button = document.getElementById('comprar');

comprarIngresso = () => {
  filme = document.getElementById('filme').value
  data = document.getElementById('data').value;
  hora = document.getElementById('hora').value;
  ingresso = document.getElementById('ingresso').value;
  // cadeira = document.getElementById('cadeira').value;
  cadeira = document.querySelector('input[type="radio"]:checked');

  if (cadeira == null) {
    alert('Favor selecionar uma poltrona')
  }

    alert(`BILHETE COMPRADO: 
    \n${filme} 
    \n${data} ${hora}
    \n Poltrona ${cadeira.value}
    \n${ingresso}
    \n`)
}

button.onclick = comprarIngresso;