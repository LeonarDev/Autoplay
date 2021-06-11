let inputPalavra = document.querySelector('#entradaPalavra');
let inputChute = document.querySelector('#entradaChute');
let divPalavra = document.querySelector('.divPalavra');
let divChute = document.querySelector('.divChute');
let ulLacunas = document.querySelector('.lacunas');
let botaoConfirmaPalavra = document.querySelector('.botaoConfirmaPalavra');
let botaoConfirmaChute = document.querySelector('.botaoConfirmaChute');  
let palavraSecreta = '';
let etapa = 1;
let numeroLacunas = '';

console.log(`palavra Secreta = '${palavraSecreta}'`);

let setPalavraSecreta = (palavra) => {
  if (palavra.includes(' ')) { 
    alert('A palavra não pode conter espaço!');
    window.location.reload();
  };

  inputPalavra.value = palavra;
  palavraSecreta = inputPalavra.value;
  console.log(`palavra Secreta = '${palavraSecreta}'`);

  console.log(palavraSecreta.split(''));
  
  getLacunas();
  exibeLacunas();
  alternaDivs();
  inputChute.focus();
};

let processaChute = (chute) => {
  if (chute.includes(' ')) { 
    alert('Seu chute não pode conter espaço!');
    throw Error('Chute inválido!');
  };

  let indices = [];
  
  if (palavraSecreta.includes(chute.toLowerCase())) {
    for (let i = 0; i < palavraSecreta.length; i++) {
      if (palavraSecreta[i] === chute.toLowerCase()) {
        indices.push(i);
      }
    }
    
    console.log(`Chute: '${chute}' | indice: ${indices}`);

    // adiciona CHUTE em LACUNAS, pegando INDICES como referencia:
    for (let i = 0; i < indices.length; i++) {
      let posicaoAtualChute = indices[i];
      let liLacuna = document.querySelectorAll('.lacuna')
      
      numeroLacunas.splice(posicaoAtualChute, 1, chute.toLowerCase());

      liLacuna[posicaoAtualChute].appendChild(document.createTextNode(chute.toLowerCase()))
    }
  } else {
    console.log(`Não existe a letra ${chute} na palavra secreta`);
    nextFrame();

    setTimeout(() => {
      if (isFinished == true) {
        alert(`FIM DE JOGO! A palavra secreta era: '${palavraSecreta}'`);
        window.location.reload();
      }
    }, 200);
  }
  inputChute.value = '';
  inputChute.focus();
  verificaSeGanhou();
}

let getLacunas = () => {
  let dividePalavraSecreta = palavraSecreta.split('');
  numeroLacunas = dividePalavraSecreta.map(letra => {
    if (letra.length != 0) letra = ``;
    return letra;
  })
  return numeroLacunas;
};

let exibeLacunas = () => {
  getLacunas().forEach(lacuna => {
    $('<li>')
      .addClass('lacuna')
      .text(lacuna)
      .appendTo(ulLacunas);
  });
};

let getEtapa = () => {
  if (palavraSecreta.length != 0) etapa++
  return etapa;
};

// Adiciona palavra secreta através do botão
botaoConfirmaPalavra.addEventListener('click', () => {
  if (inputPalavra.value.length != 0) {
    setPalavraSecreta(inputPalavra.value);
  }
});

// Adiciona palavra secreta através do enter
inputPalavra.addEventListener('keydown', (event) => {
  if (event.code === "Enter") setPalavraSecreta(inputPalavra.value);
});

// Adiciona chute através do botão
botaoConfirmaChute.addEventListener('click', () => {
  if (inputChute.value.length != 0) processaChute(inputChute.value);
});

// Adiciona chute através do enter
inputChute.addEventListener('keydown', (event) => {
  if (event.code === "Enter") processaChute(inputChute.value);
});

// Alterna para a div de chute após adicionar a palavra secreta
let alternaDivs = () => {
  if (palavraSecreta.length != 0) {
    divPalavra.style.display = 'none';
    divPalavra.style.visibility = 'hidden';
    divChute.style.display = 'block';
    divChute.style.visibility = 'visible';
  }
};

let verificaSeGanhou = () => {
  setTimeout(() => {
    if (numeroLacunas.join() ==  palavraSecreta.split('').join()) {
      alert('Parabéns! Você ganhou o jogo.');
      window.location.reload();
    }
  }, 200);
};
