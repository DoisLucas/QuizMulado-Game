## QuizMulado (Alpha)

  ***QuizMulado*** é um aplicação mobile desenvolvida na Unity Engine utilizando **C#** como linguagem base, o objetivo do game consiste em responder perguntas no estilo *"Who Wants to Be a Millionaire"* de forma divertida e educativa.
  
  
 **Funcionamento:**
  
Para cada acerto o jogador recebe uma quantia em moeda, e uma proxima pergunta é mostrada, a recompensa em moeda varia de acordo com o nivel de dificuldade da pergunta, para cada erro o jogador perde uma vida de um total inicial de 5, acabando as vidas a partida se encerra, mostrando em seguida a pontuação obtida na partida. As pontuações são salvas no perfil do jogador fazendo com que cada vez mais o jogador se esforçe para quebrar seu record pessoal.

Com as moedas é possivel adquirir poderes na loja do game, dentre eles estão:

* Poder do pulo onde é possivel pular a pergunta atual.
* Poder 50/50 onde 2 alternativas erradas das 4 são descartadas.
* Poder da vida onde adiciona mais uma vida permanentemente ao jogo.
* Poder da estatistica onde é possivel resetar as estatisticas do jogador deixando suas moedas e poderes.

**Desenvolvimento:**

Foi utilizado o padrão de projeto **Singleton** no qual garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto, onde centralizo todas as informaçoes essenciais que utilizo nas demais classes, como por exemplo todo o controle de audio da aplicação. O projeto atualmente possui 8 Scenes e 19 Script.

**Navegação:**

<p align="center">

<img src="https://github.com/DoisLucas/QuizMulado-Unity-CSharp/blob/master/Imagens/Fluxograma.png" width="80%" height="80%"/>

</p>


<B>* A cena partida possui uma recursividade, onde ela mesmo se chama N vezes, onde N é o numero de perguntas da partida, saindo do loop apenas quando não tiver mais vidas.

** Na cena Fim tem a opção de jogar novamente, fazendo com que o fluxo volte para a cena de partida com as perguntas realocadas, e a opção de voltar para o inicio.

*** Ao abandonar a partida o jogador é redirecionado para a cena de escolha do tema.</B>

