# Oracle PL/SQL: Dominando packages
Repositório de exercícios propostos pelo **[Curso 5](https://cursos.alura.com.br/course/oracle-plsql-dominando-packages)** da Formação "SQL com Oracle Database" da **[Alura](https://www.alura.com.br/)**.


Software utilizado: **[SQL Developer](https://www.oracle.com/tools/downloads/sqldev-downloads.html)**.

<br>

- Aplicando sinônimos e privilégios nos pacotes
- Gerenciando as dependências
- Entendendo e usando a sobrecarga corretamente
- Encapsulando código com rotinas internas
- Trabalhando com exceções e constantes


<br>

#### Começando:

01) No menu superior, clique em Arquivo e depois em Abrir. Abra o script 01_Criar_Usuarios.sql.

02) Acima de todos os comandos do script, digite o seguinte comando para criar uma variável de sessão, para executar comandos em sequência. Logo em seguida, execute-o:

```sql
ALTER SESSION SET "_ORACLE_SCRIPT"=true;
```

03) Selecione todo o código restante e depois execute-o.

04) Crie agora uma nova conexão no SQL developer. Para isso, clique no sinal de adição +, na aba Conexões, no lado esquerdo da tela.

[1]('./imgs/image1.png')

05) Nos campos Name, Nome do Usuário e Senha, digite user_dev. Em seguida, clique em Salvar.

06) Clique novamente no + para criar uma nova conexão.

07) Nos campos Name, Nome do Usuário e Senha, digite user_app. Em seguida, clique em Salvar.

08) Agora, na aba Conexões, clique na conexão user_dev:

[2]('./imgs/image2.png')

9) Preencha a senha e clique em OK.

10) No menu superior, vá novamente em Arquivo, depois em Abrir e selecione o arquivo 02_Criar_Tabelas.sql.

11) Selecione o código completo do script e execute-o.

12) Volte à conexão CONEXÃO ORACLE XE, digite e execute os códigos abaixo:

```sql
ALTER USER user_dev QUOTA UNLIMITED ON USERS;

ALTER USER user_app QUOTA UNLIMITED ON USERS;
```

13) De volta à conexão user_dev, abra o arquivo 03_Incluir_Dados_Tabelas.sql.

14) Selecione todo o script e execute-o.

15) Agora, abra o arquivo 04_Criar_Ambiente_Curso.sql.

16) Selecione todo o script e execute o código.

17) Agora, crie um script associado à conexão user_dev.

18) Digite e execute os seguintes comandos, para dar os privilégios de acesso para o user_app:

```sql
GRANT EXECUTE ON atualizar_cli_seg_mercado TO user_app;

GRANT EXECUTE ON atualizar_faturamento_previsto TO user_app;

GRANT EXECUTE ON excluir_cliente TO user_app;

GRANT EXECUTE ON incluir_cliente TO user_app;
```

19) Para testar se o acesso está funcionando, crie um script associado à conexão user_app.

20) Digite e execute a seguinte procedure, para incluir um novo cliente:

```sql
EXECUTE user_dev.incluir_cliente(5, 'Primeiro Cliente incluido por user_app', '23456', 2, 100000);
```
21) Para visualizar a tabela, digite e execute o seguinte:

```sql
SELECT * FROM user_dev.CLIENTE;
```

22) A tabela é apresentada abaixo:

[3]('./imgs/image3.png')

23) Note que o cliente 5 foi incluído com sucesso pelo usuário user_app.


<!-- 
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

<br> 

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

 -->