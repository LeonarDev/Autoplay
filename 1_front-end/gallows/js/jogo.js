let criaJogo = () => {
  let inputPalavra = document.querySelector('#entrada');
  let palavraSecreta = '';
  let etapa = 1;

  console.log(`palavra Secreta = '${palavraSecreta}'`);
  
  let setPalavraSecreta = (palavra) => {
    inputPalavra.value = palavra;
    palavraSecreta = inputPalavra.value;
    inputPalavra.value = '';
    console.log(`palavra Secreta = '${palavraSecreta}'`);
  };

  let getLacunas = () => {
    let dividePalavraSecreta = palavraSecreta.split('');
    let lacunas = dividePalavraSecreta.map(letra => {
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
    setPalavraSecreta: setPalavraSecreta,
    getLacunas: getLacunas,
    getEtapa: getEtapa
  };
};
