# PongBreaker!

Este jogo, de autoria de Ava Melillo, Heitor Amarim e Lucas Bento, da turma 303 de 2021, está sendo planejado em volta de uma mecânica simples e conhecida, parecida com a de Pong e Brick Breaker, com implementações de acessibilidade, e, é claro, de nosso próprio estilo.

## Telas Iniciais
___

### Tela do Menu Principal
![Tela do Menu Principal](/reposAssets/menuMain.png)
Como na maioria dos jogos, a primeira coisa que o jogador encontra é o menu principal. Entramos em um consenso sobre o estilo simples, geométrico e dinâmico, com uma pitada de moderno, que encaixa muito bem no tema de Pong e Brick Breacker. Os botões da tela inicial ganharam mais destaque que os demais em tamanho e animação, por abrangerem as ações chave para o funcionamento do jogo. Vale lembrar que todas as imagens aqui ainda não são finais e estão passíveis de mudança!

___

### Tela de Seleção de Níveis
![Tela do Menu de Seleção de Níveis](/reposAssets/menuLevelSelect.png)
O botão esquerdo do menu principal leva para essa tela, que possibilita a seleção entre os níveis já desbloqueados. Os níveis serão desbloqueados em ordem, e a princípio deixamos quinze apenas por essa disposição ficar bonita aos olhos, já que nenhum deles ainda está implementado. Na imagem acima, apenas o primeiro nível está desbloqueado, indicado pela opacidade maior.

___

### Tela de configurações
![Tela do Menu de Configurações](/reposAssets/menuConfigs.png)
Já o botão direito do menu principal é o que mostra as configurações disponíveis que afetam o jogo inteiro. Os sliders de som dão uma ótima indicação visual e também terá resposta sonora. As cores, já pensadas ao redor dos três diferentes tipos de daltonismo (protanopia, deuteranopia e tritanopia), ainda podem ser acentuadas com as respectivas opções, além de uma outra dedicada ao alto contraste.
Também é nessa tela que está disponível os créditos do jogo, o *reset* de dados, para reaproveitar o jogo do início, e o tutorial, quando este for implementado.

___

## O jogo!
![Fase Dois](/reposAssets/levelTwo.png)
A jogabilidade foi altamente inspirada por Pong, principalmente pela tela horizontal, que dá um tempo de reação um pouco mais generoso ao mesmo tempo que mantém uma claridade gráfica, e Brick Breaker, para as mecânicas principais. A fase acima mostra um dos primeiros desafios, que é acertar a bolinha em todos os retângulos, que são destruídos ao contato. Caso ela bata na parede da direita você perde, e você movimenta a barrinha da direira para cima e para baixo, a fim de evitar a perca da bolinha e a direcionar conforme a altura onde ela bateu na barrinha.

![Fase Sete](/reposAssets/levelSeven.png)
Ao decorrer das fases são apresentados tijolos de cores diferentes, cada um com uma funcionalidade que ativa ao encostar na bolinha: o cinza não pode ser quebrado pela bola, o verde te dá proteção contra a próxima vez que a bolinha encostar na parede da direita, o vermelho explode e leva consigo os tijolos brancos e cinzas ao seu redor, e o amarelo deixa a barrinha um pouco maior por alguns segundos.

![Fase Sete com modo daltônico ativado](/reposAssets/levelSevenTritanotopia.png)
Acima está a demonstração das diferentes cores sob efeito do filtro de tritanotopia, e é possível perceber como as cores mudam para acomodar a possível existente dificuldade na diferenciação delas.  Cada tijolo também tem um som diferente ao contato, facilitando ainda mais a distinção entre cada um, e uma ideia levada em consideração mas não cumprida é a medição da velocidade e posição da bolinha por meio das barras verticais transparentes, que emitiriam um som sempre que a bolinha passasse por elas.