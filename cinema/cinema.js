let movieList = ['Godzila vs Kong', 'Mortal Kombat', 'Viúva Negra'];
let student = false;
let price = 10;

if (student) {
  price /= 2;
}

button = document.getElementById('comprar');

comprarIngresso = () => {
  filme = document.getElementById('filme').value
  data = document.getElementById('data').value;
  hora = document.getElementById('hora').value;
  ingresso = document.getElementById('ingresso').value;
  cadeira = document.getElementById('cadeira').value;
  
  alert(`BILHETE COMPRADO: 
  \n${filme} 
  \n${data} ${hora}
  \n Poltrona ${cadeira}
  \n${ingresso}
  \n`)
}

button.onclick = comprarIngresso;