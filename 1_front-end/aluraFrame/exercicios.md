# Exercício 1

Um programador criou uma função genérica para imprimir todos os itens de qualquer lista no console:


```js
function exibeNoConsole(lista) {
    lista.forEach(item => console.log(item));
}
```

Excelente, mas em nossa aplicação, dentro de um contexto específico, temos duas listas distintas que queremos imprimir no console.

Sendo assim, precisamos chamar a função duas vezes:

```js
let listaDeNomes1 = ['Flávio', 'Rogers', 'Júlia'];
let listaDeNomes2 = ['Vieira', 'Fernanda', 'Gerson'];
let lista = [];

listaDeNomes1.forEach(item => lista.push(item));
listaDeNomes2.forEach(item => lista.push(item));

exibeNoConsole(lista);
```

Contudo, todo array em JavaScript possui o método `concat`. 
Alterando nosso código:

```js
let listaDeNomes1 = ['Flávio', 'Rogers', 'Júlia'];
let listaDeNomes2 = ['Vieira', 'Fernanda', 'Gerson'];

let lista = listaDeNomes1.concat(listaDeNomes2);

exibeNoConsole(lista);
```

O resultado de `concat` é um novo array com todos os elementos de quem realizou o `concat` e quem foi passado para a função.

Se quisermos, podemos enxugar ainda mais nosso código:

```js
let listaDeNomes1 = ['Flávio', 'Rogers', 'Júlia'];
let listaDeNomes2 = ['Vieira', 'Fernanda', 'Gerson'];

exibeNoConsole([].concat(listaDeNomes1, listaDeNomes2));
```

Veja que não criamos mais a variável temporária `lista`. 

Estamos passando o resultado da concatenação de um array vazio `[]` com outras duas listas. 

Aliás, a função `concat` aceita receber um número **infinito** de parâmetros, inclusive aqueles que não são um array. Vejamos um exemplo:

```js
let listaDeNomes1 = ['Flávio', 'Rogers', 'Júlia'];
let listaDeNomes2 = ['Vieira', 'Fernanda', 'Gerson'];

exibeNoConsole([].concat(listaDeNomes1, listaDeNomes2, 'Rômulo'));
```

<br>

# Exercício 2

Temos a página upload.html, na qual o usuário insere os dados do arquivo que deseja fazer upload. É claro que é um formulário de mentirinha, até porque o processo de upload é mais complexo, mas a ideia aqui é exercitar seu conhecimento adquirido em JavaScript:

```js
<!-- upload.html -->
<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <title>Upload de arquivo</title>
</head>
<body>
  <label>Informações do arquivo</label>
  <input class="dados-arquivo" placeholder="formato: nome/tamanho/tipo">

  <button onclick="arquivoController.envia()"  >Enviar</button>

  <script src="Arquivo.js"></script>
  <script src="ArquivoController.js"></script>
  <script>
    let arquivoController = new ArquivoController();
  </script>
</body>
</html>
```

Aprendemos a organizar nosso código no padrão MVC e por isso temos uma classe que é uma abstração de um arquivo. Suas propriedade são nome, tamanho, tipo:

```js
class Arquivo {
  constructor(nome, tamanho, tipo) {
    this._nome = nome;
    this._tamanho = tamanho;
    this._tipo = tipo;
  }

  get nome() {
    return this._nome;
  }

  get tamanho() {
    return this._tamanho;    
  }

  get tipo() {
    return this._tipo;
  }
}
```

É claro, temos um controller que sabe instanciar um modelo da classe Arquivo com os dados do formulário, toda vez que o usuário clicar no botão "Enviar":

```js
class ArquivoController {
  constructor() {
    this._inputDados = document.querySelector('.dados-arquivo');
  }

  envia() {
    //cria um Arquivo com as suas propriedades;
    this._limpaFormulario();
    // exibe mensagem no console com os dados do arquivo.
  }

  _limpaFormulario() {
    this._inputDados.value = '';
    this._inputDados.focus();
  }
}
```

Veja que o método envia, de ArquivoController, não está completo porque temos um problema. O problema é que o designer achou melhor ter apenas um campo onde o usuário digita na sequência o nome, o tamanho e o tipo do arquivo. Infelizmente o construtor de Arquivo não está preparado para receber a string com todos os dados, mas cada um em separado como parâmetro do construtor. E por fim, para complicar só mais um pouquinho, a entrada do usuário deve ser toda considerada em caixa alta, ou seja, maiúsculo.

Sua tarefa é implementar o método envia de ArquivoController. Ele deverá ler a entrada do usuário e adequá-la ao construtor de Arquivo. Assim que você conseguir criar uma instância de arquivo, você deve imprimir seus dados no console.

Lembre-se que o usuário digita no campo de entrada os dados do arquivo no formato: nome / tamanho / tipo e deve estar em caixa alta!

<hr>

### Resolução:

Vejamos uma implementação do método envia:

```js
envia() {
  let dados = this._inputDados.value.split('/').map(item => item.toUpperCase());
  let arquivo = new Arquivo(...dados); // usando spread operator
  console.log(`Dados do arquivo: ${arquivo.nome}, ${arquivo.tamanho}, ${arquivo.tipo}`);
  this._limpaFormulario();
}
```

Primeiramente, resolvemos o problema do input! A string com todos os dados do arquivo será desmembrada através da função split, que nos devolve um array com cada informação. Depois, a função map cria um novo array, colocando cada informação em caixa alta. No entanto, não podemos passar esse array diretamente para o construtor de Arquivo, pois ele não está preparado para receber um array, mas três parâmetros. Como esses parâmetros equivalem a cada informação no array que criamos a partir da string, passamos o array como parâmetro para o construtor de Arquivo usando o spread operator. Por fim, abusamos salutarmente de template string para exibir as informações do arquivo no console.

Usamos a função map, mas nem era necessário. Que tal converter primeiro para maiúscula antes de realizar o split?

```js
envia() {
  let dados = this._inputDados.value.toUpperCase().split('/');
  let arquivo = new Arquivo(...dados); // usando spread operador
  console.log(`Dados do arquivo: ${arquivo.nome}, ${arquivo.tamanho}, ${arquivo.tipo}`);
  this._limpaFormulario();
}
```

Não é porque map é poderoso que forçaremos seu uso, certo?

Se o tratamento da entrada dos dados do arquivo é feito em outros lugares do sistema, podemos isolar essa responsabilidade em uma classe que pode nos ajudar sempre com essa tarefa, um helper:

```js
class ArquivoHelper {
  static cria(informacao) {
    return new Arquivo(...informacao.toUpperCase().split('/'));
  }
}
```

Não podemos esquecer de importar o script do nosso helper, certo?

Por fim, alterando nosso método.

```js
//ArquivoController.js

envia() {
  let arquivo = ArquivoHelper.cria(this._inputDados.value);
  console.log(`Dados do arquivo: ${arquivo.nome}, ${arquivo.tamanho}, ${arquivo.tipo}`);
  this._limpaFormulario();
}
```
