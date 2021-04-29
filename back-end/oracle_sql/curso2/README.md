# Consultas SQL no Oracle: Projeções, Seleções, Joins e Views
Repositório de exercícios propostos pelo **[Curso 2](https://cursos.alura.com.br/course/oracle-database-consultas-sql)** da Formação "SQL com Oracle Database" da **[Alura](https://www.alura.com.br/)**.


Software utilizado: **[SQL Developer](https://www.oracle.com/tools/downloads/sqldev-downloads.html)**.

<br>

- Projeções e seleções
- Consultas com condicionais LIKE, DISTINCT e HAVING
- JOINs e seus tipos
- Sub-consultas para refinar os resultados
- Views no banco de dados
- Funções principais no Oracle

<br>

## EXERCÍCIOS

### [Exercício 1]
**Quantos clientes possuem o último sobrenome Mattos?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 1](./exercicios/Screenshot_1.png)

</details>

<hr>
<br>

### [EXERCÍCIO 2] 
**Quantos bairros diferentes da cidade do Rio de Janeiro possuem clientes?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 2](./exercicios/Screenshot_2.png)

</details>

<hr>
<br>

### [EXERCÍCIO 3] 
**Queremos obter as 10 primeiras vendas do dia 01/01/2017. Qual seria o comando SQL para obter este resultado?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 3](./exercicios/Screenshot_3.png)

</details>

<hr>
<br>

### [EXERCÍCIO 4] 
**Utilizando duas querys SQL, qual foi a maior venda do produto "Linha Refrescante - 1 Litro - Morango/Limao", em quantidade?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 4](./exercicios/Screenshot_4.png)

</details>

<hr>
<br>

### [EXERCÍCIO 5] 
**Aproveitando o exercício do vídeo anterior, quantos itens existem com a maior quantidade de venda para o produto '1101035'?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 5](./exercicios/Screenshot_5.png)

</details>

<hr>
<br>

### [EXERCÍCIO 6] 
**Veja o ano de nascimento dos clientes e classifique-os como:**

- **Nascidos antes de 1990 são velhos**
- **Nascidos entre 1990 e 1995 são jovens**
- **Nascidos depois de 1995 são crianças**

**Liste o nome dos clientes e suas classificações.**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 6](./exercicios/Screenshot_6.png)

</details>

<hr>
<br>

### [EXERCÍCIO 7] 
**Como agrupar os produtos por embalagem, pegar a média de preço para cada tipo de embalagem e conferir o status de preço para cada embalagem (caro/em conta/barato)?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 7](./exercicios/Screenshot_7.png)

</details>

<hr>
<br>

### [EXERCÍCIO 8] 
**Quais os clientes que fizeram mais de 2000 compras em 2016?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 8](./exercicios/Screenshot_8.png)

</details>

<hr>
<br>

### [EXERCÍCIO 9] 
**Levando em consideração que o valor financeiro das vendas consiste em multiplicar a quantidade pelo preço, obtenha o faturamento anual da empresa.**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 9](./exercicios/Screenshot_9.png)

</details>

<hr>
<br>

### [EXERCÍCIO 10] 
**Tendo em vista a seguinte consulta:**
```sql
SELECT CPF, COUNT(*) FROM NOTAS_FISCAIS
WHERE TO_CHAR(DATA_VENDA, 'YYYY') = '2016'
GROUP BY CPF
HAVING COUNT(*) > 2000
```
**Qual seria a consulta, usando subconsulta, que seria equivalente à consulta acima?**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 10](./exercicios/Screenshot_10.png)

</details>

<hr>
<br>

### [EXERCÍCIO 11] 
**Faça uma consulta listando o nome do cliente e o endereço completo (com rua, bairro, cidade e estado).**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 11](./exercicios/Screenshot_11.png)

</details>

<hr>
<br>

### [EXERCÍCIO 12] 
**Faça uma sub-query que mostre o nome e a idade dos clientes.**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 12](./exercicios/Screenshot_12.png)

</details>

<hr>
<br>

### [EXERCÍCIO 13] 
**Na tabela de *notas fiscais*, temos o _valor do imposto_.**
**Na tabela de *itens*, temos a _quantidade_ e o _faturamento_. Calcule o valor do imposto pago no ano de 2016, arredondando para o menor inteiro.**

<details>
<summary>Mostrar resposta</summary>
  
![Exercicio 13](./exercicios/Screenshot_13.png)

</details>

<hr>
<br>
