let criaJogo = (sprite) => {
  let inputPalavra = document.querySelector('#entrada');
  let palavraSecreta = '';
  let etapa = 1;
  let letraChutada = '';
  let lacunas = '';

  console.log(`palavra Secreta = '${palavraSecreta}'`);

  let setPalavraSecreta = (palavra) => {
    inputPalavra.value = palavra;
    palavraSecreta = inputPalavra.value;
    inputPalavra.value = '';
    console.log(`palavra Secreta = '${palavraSecreta}'`);

    getLacunas();
  };


  let processaChute = (chute) => {
    let indices = [];
    
    if (palavraSecreta.includes(chute)) {
      for (let i = 0; i < palavraSecreta.length; i++) {
        if (palavraSecreta[i] === chute) {
          indices.push(i);
        }
      }
      
      console.log(`Chute: '${chute}' | indice: ${indices}`);

      // adicionar CHUTE em LACUNAS, pegando INDICES como referencia:
      for (let i = 0; i < indices.length; i++) {
        let posicaoAtualChute = indices[i];

        console.log(posicaoAtualChute);
        
        lacunas.splice(posicaoAtualChute, 1, chute)
        console.log(lacunas);
      }
    } 
  }


  let getLacunas = () => {
    let dividePalavraSecreta = palavraSecreta.split('');
    lacunas = dividePalavraSecreta.map(letra => {
      if (letra.length != 0) letra = ``;
      return letra;
    })
    return lacunas;
  };

  let getEtapa = () => {
    if (palavraSecreta.length != 0) etapa++
    return etapa;
  };

  return {
    setPalavraSecreta,
    getLacunas,
    getEtapa,
    processaChute
  };
};
