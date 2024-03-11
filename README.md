# Desafio Estágio Target

## Questão 1

1 - Observe o trecho de código abaixo:

```cs
int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
{
    K = K + 1;
    SOMA = SOMA + K;
}
imprimir(SOMA);
```

Ao final do processamento, qual será o valor da variável SOMA?

RESPOSTA: 91 ;

## Questão 2

2 - Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

RESPOSTA: [Clique Aqui](https://github.com/MiloVSM/desafio-estagio-target/blob/main/Exercicio_02/Exercicio_02/Program.cs)

## Questão 3

3 - Descubra a lógica e complete o próximo elemento:

a) 1, 3, 5, 7, **9** (Soma +2)

b) 2, 4, 8, 16, 32, 64, **128** (Multiplica por 2)

c) 0, 1, 4, 9, 16, 25, 36, **49** (Numeros elevados por 2)

d) 4, 16, 36, 64, **100** (Números pares elevados por 2)

e) 1, 1, 2, 3, 5, 8, (Sequência Fibonacci)

f) 2,10, 12, 16, 17, 18, 19, **200** (Números que começam com "D"?)

## Questão 4

4 - Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

RESPOSTA:

```
interruptor 1, 2, 3;
Lampada A, B, C:

Primeiro acendo o interruptor 1 e espero alguns minutos até a lampada esquentar;
Apago o interruptor 1;
Acendo o interruptor 2 e vou imediatamente até a sala da lampada "A";

    Se a lampada "A" estiver acesa
        -ela esta ligada ao interruptor 2;

    Se a lampada "A" estiver apagada e quente
        - ela ligada ao interruptor 1

    Se a lampada "A" estiver apagada e fria
        - ela ligada ao interruptor 3;


Agora que sabemos qual interruptor controla a lampada "A", resta descobrir os outros dois;
Basta deixarmos um aceso e o outro apagado e assim podemos elimina-los na segunda visita.

Por exemplo: se for interruptor 1 que controla a lampada "A"; Acendo interruptor 2 e deixo o interruptor 3 apagado;
Vou até a sala da lampada "B", se estiver acesa está ligada ao interruptor 2 e se estiver apagada pertence ao interruptor 3;
Logo a lampada "C" pertence ao interruptor que sobrou;

```

## Questão 5

5 - Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;

RESPOSTA: [Clique Aqui](https://github.com/MiloVSM/desafio-estagio-target/blob/main/Exercicio_05/Exercicio_05/Program.cs)
