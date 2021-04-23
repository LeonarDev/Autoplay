# Oracle PL/SQL: Procedures, funções e exceções
Repositório de exercícios propostos pelo **[Curso 4](https://cursos.alura.com.br/course/oracle-plsql-procedures-funcoes-excecoes)** da Formação "SQL com Oracle Database" da **[Alura](https://www.alura.com.br/)**.


Software utilizado: **[SQL Developer](https://www.oracle.com/tools/downloads/sqldev-downloads.html)**.

<br>

- Os principais comandos PL/SQL
- Inserir, atualizar e remover dados de tabelas
- Criar procedures e funções para encapsular código
- Recuperar registros com o Cursor
- Tratar e definir exceções

<!-- 
![MySQL](./img/sql.jpg)

<br>

## Resumo de comandos

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

**Realizar as operações no MySQL conforme as tabelas apresentadas abaixo.**

![Tabelas](./img/tabelas.png)

<hr>
<br>

### [Exercício 1]
**Recuperar o nome e o endereço de todos os funcionários que trabalham para o departamento "Pesquisa".**

![Exercicio 1](./img/exercicio-1.png)

<hr>
<br>

### [EXERCÍCIO 2] 
**Para cada projeto localizado em "Mauá", liste o número do projeto, o número do departamento que o controla, o último nome, endereço e data de nascimento do gerente do departamento.**

![Exercicio 2](./img/exercicio-2.png)

<hr>
<br>

### [EXERCÍCIO 3] 
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
<br>