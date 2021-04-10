# Modelagem de dados 
Repositório de exercícios propostos pelo pdf **modelagemDeDados_aulaOnline**.

Software utilizado: **[brModelo](http://www.sis4.com/brModelo/download.html)**.

<br>

## [Exercício 1] Clínica Veterinária
**O objetivo é desenvolver um modelo de dados para um hospital veterinário. Cada cliente pode possuir um ou vários animais em tratamento. Cada animal pode estar sofrendo de uma ou várias enfermidades. Os casos mais simples são resolvidos, geralmente, por um único veterinário, entretanto podem ocorrer casos em que um animal é atendido por mais de um veterinário.**

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/01.png?raw=true">

<hr>
<br>

## [Exercício 2] Locadora de Veículo
**Elaborar o M.E.R., bem como identificar os atributos de cada entidade e
relacionamentos, para uma Locadora de Automóveis, sabendo-se que:**
- 􀀀Para cada veículo locado é necessário saber, a marca, modelo, descrição, cor, placa
e outros;
- Para cada contrato é necessário saber, data, preço da diária, o veículo, o cliente e o
valor do seguro;
- Para cada cliente é necessário saber, o nome, endereço, cpf e outros dados
pessoais;
- Para as manutenções dos veículos é necessário saber, por modelo o custo médio
mensal.

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/02.png?raw=true">

<hr>
<br>

## [Exercício 3] Ambiente Corporativo
**Elaborar o M.E.R., bem como identificar os atributos de cada entidade e relacionamentos, para um ambiente corporativo, composto de departamentos, sabendo-se que:**
- Cada departamento possui um código, nome, sigla e um chefe;􀀀
- Os chefes de departamento estão divididos em categorias e, para a empresa, é
importante saber a data em que foi assumida cada chefia; 􀀀
- Os empregados da empresa estão ligados a um departamento e a cada um deles
está associado matrícula, nome, sexo, telefone, dependentes, data de admissão e
cargo;
- Os empregados são alocados em projetos e a informação data de alocação deve
ser mantida; e
- Cada projeto é caracterizado por um número, nome e horas previstas.

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/03.png?raw=true">

<hr>
<br>

## [Exercício 4] Comercial
**Uma empresa deseja informatizar sua Área Comercial. Após levantamento junto às áreas envolvidas, as seguintes necessidades foram identificadas:**
- Para os produtos comercializados pela empresa é necessário saber o seu código,
nome, custo, preço e a família de produtos a que pertence, bem como os preços e
quantidades por pedido de venda. Para estes é necessário ter informações como
número, data, cliente e as faturas
- 􀀀Para os clientes é necessário ter o código, nome, endereço, pedidos de venda,
faturas e duplicatas; e
- Para as faturas o número, data, duplicatas geradas e a transportadora dos
produtos constantes na mesma. Quanto às duplicatas, necessita-se o número, data
de vencimento, cliente e o portador (banco).
**Fazer o diagrama entidade relacionamento e identificar os atributos de cada entidade e de cada relacionamento**

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/04.png?raw=true">

<hr>
<br>

## [Exercício 5] Construção Cívil
**Uma empresa de Construção Civil deseja informatizar sua Área de Pessoal, bem como o de Administração de Obras. Para atender estas necessidades o seguinte foi detectado:**
- Todos os empregados tem um cargo e existe um plano de carreira para os mesmos;
- Os empregados estão lotados em órgãos, cada um deles tendo um chefe. Dentre os critérios para promoção dos empregados, destacam-se o da titulação e a participação em cursos profissionalizantes, com suas respectivas datas;
- Para todas as obras executadas, previamente são definidas as atividades que serão executadas, com seus respetivos cronogramas por participante, seu custo orçado, seu prazo de execução e o responsável pela mesma. Ainda são definidos os materiais a serem utilizados por atividade, independente do executor, e os custos previstos;
- A empresa definiu a necessidade de manter-se um histórico dos preços praticados pelos seus fornecedores;
- Para uma melhor administração das obras, foi definido que semanalmente deveria ser emitido um relatório, demonstrando por obra o seu custo orçado e o real até a data, bem como o cronograma de execução, apontando os desvios existentes, se for o caso.

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/05.png?raw=true">

<hr>
<br>

## [Exercício 6] Sistema Acadêmico
**Sobre a área de Controle Acadêmico de uma Universidade temos as seguintes informações:**
- É composta por diversos departamentos, os quais podem oferecer diversos cursos;
- Uma disciplina é oferecida por um único departamento;
- Todo aluno está matriculado em um único curso;􀀀Uma mesma disciplina pode constar do currículo de diversos cursos;
- Todo professor está lotado em um departamento e pode ministrar diversas disciplinas.Fazer o diagrama entidade relacionamento e identificar os atributos de cada entidade e de cada relacionamento.

**Fazer o diagrama entidade relacionamento e identificar os atributos de cada entidade e de cada relacionamento, sinalize também os atributos identificadores (chaves).**

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/06.png?raw=true">

<hr>
<br>

## [Exercício 7] Companhia aérea
**Considere a descrição de um sistema de venda de passagens aéreas dada abaixo e desenhe um diagrama ER de acordo com as seguintes informações:**
- Para um passageiro são registrados o número do documento de identidade e o seu nome.
- Um avião é caracterizado por um número de série único e por um modelo. 􀀀
- Um assento é uma posição única em um avião, identificada por um código.
- Um assento é da classe econômica ou executiva.
- Um avião possui vários assentos e pode ser usado em vários vôos.
- Um voo é identificado por um número e utiliza: um avião, um piloto, um aeroporto de partida e outro de chegada.
- Um passageiro pode reservar um assento em um voo.

<img src="https://github.com/LeonarDev/Autoplay/blob/main/back-end/modelagem_db/Aulas_Autoplay/Exercicios/07.png?raw=true">
