<h1 align="center">Kanban</h1>

<p align="center">
  <img src='./kanban2.jpg'>
</p>

## ÍNDICE
<!--
- [Review Meeting](#review-meeting)
- [Definição de Pronto](#definição-de-pronto)
- [Retrospectiva](#retrospectiva)
- [Ações](#ações)
- [Daily Scrum](#daily-scrum)
- [Planning Meeting](#planning-meeting)
- [Product e Sprint Backlogs](#product-e-sprint-backlogs)
  - [Product Backlog](#product-backlog)
  - [Sprint Backlog](#sprint-backlog)
  - [Histórias e tarefas](#histórias-e-tarefas)
- [Scrum Master](#scrum-master)
  - [O dia a dia de um Scrum Master](#o-dia-a-dia-de-um-scrum-master)
  - [Evolução do papel](#evolução-do-papel)
  - [Problemas e impedimentos](#problemas-e-impedimentos)
- [Product Owner](#product-owner)
  - [O dia a dia de um PO](#o-dia-a-dia-de-um-product-owner)
  - [Refinamento do backlog](#refinamento-do-backlog)
  - [Um pessoa só](#uma-pessoa-só)
- [Desenvolvedor](#desenvolvedor)
- [Papeis do time todo](#papeis-do-time-todo)
  - [Uma única restrição](#uma-única-restrição)
-->
- [Exercícios](#exercícios)

<br>
<hr>

### Exemplo de Kanban para devs
[Organização de projeto no Trello](https://trello.com/b/5EjisOHa/projeto-app-de-receitas)

<br>

### Kazen - Melhoria Contínua
[Video Método Kaizen](https://www.youtube.com/watch?v=4878_jOpPT4)

<br>

### História da Toyota 

Taiichi Ohno, um dos criadores do Sistema de Produção Toyota, “os dois pilares do Sistema de Produção Toyota são just-in-time e automação com um toque humano, ou autonomação. A ferramenta usada para operar o sistema é kanban”. Em outras palavras, kanban é fundamental para o processo de kaizen (“melhoria contínua”) usado na Toyota. É o mecanismo que faz com que ele funcione.

**A diferença entre os "kanban's"**

kanban - Palavra japonesa para cartão de sinal, Kanji, são as sílabas japonesas, são dois kanjis, o Kan ban.

Sistema kanban - refere-se ao sistema puxado implementado com cartões sinalizadores.

Método Kanban - David Anderson - é usado para se referir à metodologia de melhoria de processo incremental e evolutiva que surgiu na Corbis de 2006 a 2008 e continuou a evoluir na ampla comunidade de desenvolvimento Lean de software nos anos seguintes.

**Relação entre Lean, Kanban e Modelos Ágeis**

Kanban faz parte do pensamento Lean mas não é um Modelo Ágil.

**O que é um sistema puxado?**

Do inglês “pull system”, a produção puxada controla as operações fabris sem a utilização de estoque em processo. Neste modelo, diferentemente da produção empurrada, o fluxo de materiais ganha relevante importância. Dá-se com a utilização do Sistema Kanban.

**Diferenças do Kanban de outros modelos ágeis**

O principal limite é o WIP que indica quando o trabalho pode andar

É mais aberto quanto a adaptação, quanto mais o time aprende mais pode adaptar o quadro a sua realidade.

**Vantagens de usar o Kanban**
- Fluxo contínuo, melhor agilidade
- Mudança evolutiva, menor resistência
- Melhor previsibilidade, controle das variáveis, ritmo contínuo
- Melhor gerenciamento de risco

**Dicas de como começar a usar o Kanban**
- Comece de onde você está
- Concorde em melhorar incrementalmente
- Encoraje atos de liderança e inicialmente respeite papéis, responsabilidades e descrição de cargos.

[Video: Sistema Toyota de Produção - Lean I](https://www.youtube.com/watch?v=c6KVeDbgRgU)
[Video: Sistema Toyota de Produção - Lean II](https://www.youtube.com/watch?v=6vmdVR9dzPM)

<br>
<hr>

### Como visualizar o trabalho na forma de fluxo

- Reunindo o time e pedindo para que todos listem em post-its em que estão trabalhando atualmente.
- Opcionalmente os itens podem depois ser priorizados em uma coluna.
- Entendemos os desafios de uso das ferramentas eletrônicas neste acompanhamento do Kanban, pois a informação não está acessível a todos em tempo real, além de gerar a demanda de que todos dominem o uso de um software para aplicar o Kanban
- Observamos o conceito de information refrigerator e information radiator.

**Identificamos as vantagens de visualizar o trabalho, para:**
- Fazer o trabalho que está “escondido” aparecer
- Tornar o trabalho visível faz com que a informação esteja disponível para todos os interessados
- Auxiliar ao time a ver: Quem está fazendo o que, e a quantidade de trabalho em que o time está envolvido

**Dicas e principais vantagens de mapear o fluxo de trabalho:**
- Começar organizando o trabalho em colunas por onde o trabalho começa
- O nome das colunas pode ser alterado depois
- O melhor modelo é o criado pelo time
- Trabalho pronto é o que gera valor para o cliente
- O Kanban expõe os problemas no processo
- O primeiro quadro não é final, é só o melhor possível
- Identificar todos os estágios do trabalho, do início até o trabalho deixar o time
- Não busque a perfeição, inspecione e adapte o trabalho tendo como premissa que ele não pode ser considerado completo enquanto não estiver entregando valor para o cliente
- Observamos que por meio do mapeamento visual do fluxo de trabalho, você vê: o status do trabalho, e os potenciais problemas como trabalho não progredindo e acumulando em um estágio

**Como são e como fazer cartões do quadro Kanban:**
- O quadro precisa ser compreendido pelo time
- Os cartões servem para mostrar status dos trabalhos e apresentam os seguintes atributos comuns nos quadros de Kanban:
    - Descrição do item de trabalho
    - ID do sistema eletrônico
    - Prazos e datas
    - Quem está trabalhando naquele cartão através de avatar
    - Tipo de trabalho (bug ou normal, por exemplo) Bugs muitas vezes diferenciados por cor

<br>
<hr>

### Dinâmica Virar Moedas
[Video](https://www.youtube.com/watch?v=HW2DEZLRAhw)

**Primeira rodada**. Os participantes passam 12 moedas por vez e para completarem os grupos demoram de 29 a 34 segundos. A primeira entrega, ou seja, a primeira sequência de 12 moedas, chega no final em 27 segundos.

**Segunda rodada**. O instrutor pede para reduzir pela metade, ou seja, de 12 passar para 6 moedas. O time mais lento reduziu 5 segundos, completando em 29 segundos e o time mais rápido fez em 23 segundos. Redução de 20% e 26% respectivamente no tempo.

**Terceira rodada**. Todas as moedas levam apenas 20 segundos para passar. Da primeira rodada para a última houve uma melhoria entre 45%, de 29 para 20 segundos, até 70%, de 34 para 20 segundos.

**A última entrega**, fazendo sequências de 2 em 2 moedas, demorou apenas 12 segundos!

<br>
<hr>

### Work in Progress
Sobre o WIP (Work in Progress):
- Pare de começar e comece a terminar!
- Trabalhar em menos itens entrega valor mais rápido
- O WIP Pode ser definido inicialmente por número de pessoas em cada atividade
- O time é a melhor fonte para definir seu limite de WIP
- Podemos criar uma Coluna de “buffer” - para atividades que envolvem apenas uma aprovação por exemplo
- Limitar o WIP (work in progress) vai mostrar oportunidades de melhoria
- Agir sobre estas oportunidades vai melhor o fluxo do trabalho
- Não existe um WIP “correto” para um time
- Em termos de limites de WIP, observamos que: limites muito ALTOS deixam o trabalho parado, já os limites muito BAIXOS deixam as pessoas paradas sem trabalho.

**Como lidar com itens urgentes, considerando que:**
- O time cria uma política para definir o que é urgente
- A urgência é criada no quadro e é tratada como uma raia separada
- A importância de lembrarmos que a linha de itens de urgência criada mostra o impacto no fluxo de trabalho aumentando o WIP.

<br>
<hr>

### Fluxo de Trabalho x Pessoas
[Video](https://www.youtube.com/watch?v=CostXs2p6r0)

<br>
<hr>

### Principais métricas do Kanban
Lead time – o tempo para todo o fluxo do trabalho

Cycle time – o tempo que o trabalho demora para passar por parte do fluxo.

Throughtput – quantos itens o time completa em um período de tempo, pode ser chamado de vazão.

- As métricas existem para ajudar o time a melhorar
- É recomendável que se deixe o time escolher as suas próprias métricas.
- Não devemos usar as métricas do Kanban para avaliação de performance da equipe.
- É importante que os cartões tenham datas para ser possível extrair as métricas desejadas.
- Na dúvida de qual métrica usar, como ponto de análise inicial usar a Lead time, porque é o tempo que a sua entrega leva para gerar valor para seu cliente
- As métricas devem ser escolhidas pela realidade de cada time.
- As métricas ajudam o time a começar a ver a média dos seus resultados, a fazer previsões e planejar prazos de entrega.

Na questão da urgência é importante sempre monitorar no fluxo de trabalho do quadro Kanban o que é urgente tendo em vista que isso impacta o resultado como um todo da entrega.

<br>
<hr>

### Scrum vs Kanban

[Blog Miro: Kanban vs Scrum Side by Side Comparison](https://miro.com/blog/scrum-kanban-boards-differences/)
<br>
<hr>

### Cuidados na implantação do Kanban

- Deixarmos as políticas explícitas com foco em buscar a melhoria contínua e colaborativa;

- Realização de reuniões periódicas de melhoria baseadas no quadro Kanban, onde o time decide sua frequência. O importante é que ela seja focada nos post-its, não nas pessoas, e que os post-its sejam trabalhados priorizados da direita para a esquerda, o que possibilitará o término de alguns trabalhos antes de se iniciarem outros;

- É relevante nos certificarmos que todo o time entende no que trabalha;

- O Kanban não faz mágica, quem faz a mágica é o time. Na verdade, o Kanban expõe os problemas no processo. Neste contexto, cabe ao time abordar os problemas para poder obter os benefícios do Kanban e com isto obter a verdadeira magia que é o time sempre estar se auto ajustando para poder estar continuamente melhorando;

- A adoção do Kanban é um investimento de longo prazo em capacidade, maturidade e cultura da sua organização.Não se destina a uma solução rápida!

- Focar no que “cheira mal” e nos desvios;

Os erros mais comuns no quadro Kanban são:
a- Andar contra o sentido do fluxo.
b- Ter uma coluna para “on hold” ou espera.
c- Não ter limite ou não respeitar o WIP.
d- Não mapear todos os itens de trabalho ou o post-it “fantasma”
e- Não usar métricas de forma consistente ou relevante.
f- Não deixar a métrica ser imposta, o time precisa estar envolvido na decisão!
g- Punir o time caso o resultado piore, premiar caso o resultado melhore

<br>
<hr>

### 

<br>
<hr>

### 

<br>
<hr>

### 

<br>
<hr>

### 

<br>
<hr>

<h1 align="center">Exercícios</h1>
<p align="center" >
  <img src='../crack_fingers.gif'>
</p>

<br>

### Quais as principais vantagens do Kanban:

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> Fluxo contínuo, melhor agilidade
> Mudança evolutiva, menor resistência
> Melhor previsibilidade
> Controle das variáveis
> Ritmo contínuo
> Melhor gerenciamento de risco
> 

</details>

<hr>
<br>

### O que você recomendaria a um time que está desejando começar a usar Kanban?

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> A primeira etapa ao adotar Kanban é visualizar o trabalho de forma simples.
> Portanto, a recomendação inicial seria reunir o grupo e pedir que anotem em pedaços de papel, cada atividade em que estão trabalhando e colocam os papéis em um mural para que todos possam ver.
> 

</details>

<hr>
<br>

### Quais são as suas recomendações caso o seu time opte por utilizar o quadro Kanban em ferramentas eletrônicas?

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> Garantir que a ferramenta possa ser conectada a alguma TV ou board visual para que o quadro esteja sempre disponível e visível para todo o time, que ela seja fácil de ser aprendida, intuitiva e que a maior parte do time esteja envolvida na escolha da ferramenta.
> Ferramentas eletrônicas possuem vantagens e desvantagens e para garantir que elas funcionem é preciso zelar que o quadro Kanban esteja visível 100% do tempo para todo o time.
> 

</details>

<hr>
<br>

### *Cartões do quadro Kanban contém todas as informações necessárias ao desenvolvimento daquela parte do Software. Baseando-se apenas na descrição os desenvolvedores são capazes de desenvolver e os testadores de testar. Esta é a grande utilidade dos Cartões.*

**Esta informação é verdadeira ou falsa? Justifique.**

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> FALSA. 
> Os cartões do quadro Kanban são apenas uma referência de marcação e contém algumas informações relevantes mas não todas as informações. Por isso é comum os cartões conterem o SYSTEM ID (referência a algum software/aplicação), onde mais documentação poderá ser incluída sobre aquele item. Eles servem para lembrar e para marcar o WIP no quadro.
> 
> Atributos comuns são:
> 
> -- Descrição do item de trabalho
> 
> -- ID do sistema eletrônico
> 
> -- Prazos
> 
> -- Quem está trabalhando naquele cartão
> 
> -- Tipo de trabalho ( bug ou normal, por exemplo)
> 

</details>

<hr>
<br>

### Quais são as melhores práticas quando algo urgente ocorre e o time Kanban precisa incluir este item na rotina do trabalho?

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> O time inclui no quadro uma swinlane, ou raia, que é usada para tratar de itens urgentes. Esta raia possui uma política de urgência que é claramente fixada e conhecida por todos os interessados e precisa ser respeitada.
> 
> Políticas sobre esta linha podem ser:
> 
> -- Apenas um item pode estar na linha por vez
> 
> -- Apenas um item pode ser "acelerado” por semana
> 
> -- Não contar o item urgente no limite do WIP
> 

</details>

<hr>
<br>

### Sobre a métrica de lead time. Que dados você recomendaria incluir nos cartões do quadro Kanban para implementar tal métrica?

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> Data da entrada na primeira coluna de trabalho e 
> data de tarefa completa.
> A métrica lead time mede o tempo que um item de trabalho leva para percorrer todo o fluxo, para tal, precisamos monitorar o dia que o item entrou no fluxo e o dia que o item saiu do fluxo.
>

</details>

<hr>
<br>

### Considerando seus conhecimentos sobre lead time, cycle time e throughput leia atentamente o caso abaixo e selecione a opção correta.

**Como dica para você refletir sobre a questão vale destacar que no exemplo deste exercício, estamos aplicando métricas Kanban num sistema sem termos feito medições in loco, além dos valores descritos abaixo.****

**Marcos precisava encher o maior número de baldes possível porque ele sabia que iria faltar água na casa dele no próximo final de semana. Para isso ele pegou uma mangueira e conectou-a a uma torneira. A mangueira tem 2 metros de comprimento. Desde que ele abriu a torneira até cair a primeira gota d'água no balde o tempo foi de 3 segundos.**

**A cada 1 minutos Marcos conseguiu encher um balde de água. Marcos encheu 60 baldes em uma hora e ficou satisfeito.**

**ou**

**A cada 5 minutos Marcos conseguiu encher um balde de água. Marcos encheu 12 baldes em uma hora e ficou satisfeito.**

**Considerando que o sistema é desde a água sair da torneira até sair da mangueira.**

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> O **lead time é de 3 segundos** e o **throughput é de 60 baldes por hora**, ou 1 balde a cada 5 minutos, não temos como estimar cycle time pois não há particionamento do sistema.
> 
> Cycle time poderia ser estimado caso houvesse alguma etapa a mais, entre a saída da torneira até a saída da mangueira.
> 
> Este caso é como se houvesse apenas duas colunas no quadro Kanban. O leadtime é o tempo total, ou seja, o tempo que a água leva para percorrer a mangueira, o throughput é quantos itens o Marcos completa por período de tempo, ou seja, 60 baldes por hora, ou 1 balde a cada 5 minutos.
> 
> Assim, neste exemplo, citado não está claro pela ausência do cycle time a existência de etapas para recolhimento de água em mais de um balde ao mesmo tempo quantas mangueiras, quantos baldes e quantas torneiras são usadas.
> 
> Vale destacar que na prática num sistema Kanban todas as 3 métricas citadas devem ser coletadas em campo, devido a acontecimentos no sistema que só entendemos durante o processo/operação, os quais a lógica matemática isolada sem todas as variáveis não nos dá todas as respostas.
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>

### PERGUNTA

<details>
<summary>Mostrar resposta</summary>

<br>

> 
> RESPOSTA
> 

</details>

<hr>
<br>
