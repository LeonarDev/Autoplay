# Modelagem de banco de dados relacional: NoSQL
Repositório de exercícios propostos pelo **[Curso 6](https://cursos.alura.com.br/course/modelagem-banco-nosql/)** da Formação "Modelagem de dados" da **[Alura](https://www.alura.com.br/)**.


Softwares utilizados: **[MySQL Workbench](https://www.mysql.com/products/workbench/)** e **[MongoDB](https://www.mongodb.com/try/download/community)**.

<br>

![NoSQL](./img/nosql.png)

<br>
















<!-- ## Resumo de comandos

#### Criar um banco de dados:

```sql
CREATE DATABASE nome-do-banco;
```

<br>

#### Mostrar todos os bancos de dados:

```sql
SHOW DATABASES;
```

<br>

#### Antes de criar uma tabela ou realizar qualquer operação, é necessário selecionar o banco que será usado:

```sql
USE nome-do-banco;
```

<br>

#### Exemplo prático:

```sql
CREATE DATABASE banco_clientes;

USE banco_clientes;

CREATE TABLE tabela_clientes (
  idCliente int NOT NULL auto_increment,
  nomeEmpresa varchar(255) not null,
  nomeDiretor varchar(255) default NULL,
  numEmpregados mediumint default NULL,
  PRIMARY KEY (idCliente)
) ;

```

<br>

#### Exibir todas as tabelas do banco selecionado:

```sql
SHOW tables;
```

<br>

#### Obter informações sobre uma tabela:

```sql

```

<br>

#### 
```sql

```

<br>

#### 
```sql

```

<br>

#### 
```sql

```

<br>

#### 
```sql

```

<br>

#### 
```sql

```

<br>

#### 
```sql

```

<br> -->



















## EXERCÍCIOS


<!-- **Realizar as operações no MySQL conforme as tabelas apresentadas abaixo.**

 ![Tabelas](./img/tabelas.png) -->

<hr>
<br>

### [Exercício 1]
**Seja o seguinte JSON que representa a classe de Departamentos. Podemos ver que ele possui dados dos departamentos e os projetos nos quais o departamento é responsável.**

```json
{
  "Numero_Departamento": "5",
  "Data_Inicio_Gerente": "1988-05-22",
  "Nome_Departamento": "Pesquisa",
  "Cpf_Gerente": "33344555587",
  "Projeto": [
    {
      "Numero_Projeto": "2",
      "Nome_Projeto": "Produto Y",
      "Local_Projeto": "Itu"
    },
    {
      "Numero_Projeto": "3",
      "Nome_Projeto": "Produto Z",
      "Local_Projeto": "São Paulo"
    }
  ]
}
```

**O JSON acima apenas serve para representar o formato dos dados. Vamos imaginar que, na tabela que representa esta classe, temos centenas de linhas já preenchidas com valores das instâncias das classe no formato apresentado.**

**O nome da tabela é tb_object_departamento e o campo que representa o JSON chama-se JSONVALUE**

**Queremos saber quais departamentos possuem gerentes cujo ano de início da gerência foi em 2005. Apresentar apenas o nome do departamento.**

```sql
SELECT
  JSON_EXTRACT(JSONVALUE, "$.Nome_Departamento") 
FROM
  tb_object_departamento 
WHERE
  YEAR(JSON_EXTRACT(JSONVALUE,"$.Data_Inicio_Gerente")) = 2005;
```

<!-- ![Exercicio 1](./img/exercicio-1.png) -->

<hr>
<br>

### [EXERCÍCIO 2] 
**Seja o seguinte JSON que representa a entidade “Trabalha_em” na nossa empresa que implementa projetos:**

```json
{
  "Cpf_Funcionario": "111222333",
  "Numero_Projeto": "5",
  "Horas": 30
}
```

**Construa a consulta SQL para obter a média de horas trabalhadas por projeto. (Nome da tabela tb_object_trabalha_em e nome do campo JSONVALUE).**

```sql
SELECT
  JSON_EXTRACT(JSONVALUE, "$.Numero_Projeto"), 
  AVG(JSON_EXTRACT(JSONVALUE, "$.Horas")) 
FROM 
  tb_object_trabalha_em
GROUP BY 
  JSON_EXTRACT(JSONVALUE, "$.Numero_Projeto")
```

<!-- ![Exercicio 2](./img/exercicio-2.png) -->

<hr>
<br>

<!-- ### [EXERCÍCIO 3] 
**Descobrir os nomes dos funcionários que trabalham em todos os projetos controlados pelo departamento 5.**

![Exercicio 3](./img/exercicio-3.png)

<hr>
<br>

### [EXERCÍCIO 4] 
**Fazer uma lista dos números de projetos para aqueles que envolvem um funcionário cujo último nome é 'Souza'. Seja como trabalhador, seja como gerente do departamento que controla o projeto.**

![Exercicio 4](./img/exercicio-4.png)

<hr>
<br>

### [EXERCÍCIO 5] 
**Recuperar os nomes dos funcionários que não possuem dependentes.**

![Exercicio 5](./img/exercicio-5.png)

<hr>
<br>

### [EXERCÍCIO 6] 
**Listar o nome dos gerentes que possuem pelo menos um dependente.**

![Exercicio 6](./img/exercicio-6.png)

<hr>
<br> -->