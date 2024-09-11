// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Calcular e exibir a média geométrica de dois
valores quaisquer que serão digitados. */

int numeroUm, numeroDois;
float mediaGeometrica;

Console.WriteLine("Digite o primeiro número: ");
numeroUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
numeroDois = int.Parse(Console.ReadLine());

mediaGeometrica = (float)Math.Sqrt(numeroUm * numeroDois);

Console.WriteLine("A media geometrica dos dois valores é: " + mediaGeometrica);

#elif exercicio2

/* Sabendo que uma milha marítima equivale a um mil, 
oitocentos e cinquenta e dois metros e que um quilômetro 
possui mil metros, fazer um programa para converter 
milhas marítimas em quilômetros. */

float milha, metro, km;

Console.WriteLine("Digite o valor da milha: ");
milha = float.Parse(Console.ReadLine());

metro = milha * 1852f;
km = metro / 1000;

Console.WriteLine("O valor em quilometros é: " + km);

#elif exercicio3

/* Calcular e exibir a tensão de um determinado circuito 
eletrônico a partir dos valores da resistência e corrente 
elétrica que serão digitados. Utilize a lei de Ohm. */

int tensao, corrente, resistencia;

Console.WriteLine("Digite o valor da resistência:");
resistencia = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da corrente: ");
corrente = int.Parse(Console.ReadLine());

tensao = resistencia * corrente;

Console.WriteLine("O valor da tensão é: " + tensao);

#elif exercicio4

/* Entrar via teclado com o valor de uma temperatura em 
graus Celsius, calcular e exibir sua temperatura equivalente em Fahrenheit. */

int celcius;
float fahrenheit;

Console.WriteLine("Digite o a temperatura em Celcius: ");
celcius = int.Parse(Console.ReadLine());

fahrenheit = (float)(celcius * 9f / 5) + 32;

Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);

#elif exercicio5

/* A partir do diâmetro de um círculo que será digitado, 
calcular e exibir sua área. */

float area, diametro, pi = 3.141f;

Console.WriteLine("Digite o valor do diametro: ");
diametro = float.Parse(Console.ReadLine());

area = (pi / 4) * (float)Math.Pow(diametro, 2);

Console.WriteLine("A área do circulo é: " + area);

#elif exercicio6

/* Calcular e exibir o volume de um cone a partir dos 
valores da altura e do raio da base que serão digitados. */

float volume, pi = 3.141f, altura, raioDaBase;

Console.WriteLine("Digite o valor da altura: ");
altura = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do raio da base: ");
raioDaBase = float.Parse(Console.ReadLine());

volume = 1 / 3f * pi * (float)Math.Pow(raioDaBase, 2) * altura;

Console.WriteLine("O volume do cone é: " + volume);

#elif exercicio7

/* Calcular e exibir a velocidade final (em km/h) de um automóvel, 
a partir dos valores da velocidade inicial (em m/s), da aceleração (m/s²) 
e do tempo de percurso (em s) que serão digitados. */

float velocidadeFinal, velocidadeInicial, aceleracao, tempoDePercurso;

Console.WriteLine("Informe a velocidade inicial (m/2): ");
velocidadeInicial = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a aceleração (m/s²): ");
aceleracao = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o tempo de percurso em segundos: ");
tempoDePercurso = float.Parse(Console.ReadLine());

velocidadeFinal = (float)3.6 * (velocidadeInicial + (aceleracao * tempoDePercurso));

Console.WriteLine("A velocidade final é: " + velocidadeFinal);

#elif exercicio8

/* Calcular e exibir o volume livre de um ambiente que contém 
uma esfera de raio “r” inscrita em um cubo perfeito de aresta “a”. 
Os valores de “r“ e “a” serão digitados. */

float volumeLivre, volumeEsfera, volumeCubo, pi = 3.141f, raio, aresta;

Console.WriteLine("Digite o valor do raio da esfera: ");
raio = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da aresta do cubo: ");
aresta = float.Parse(Console.ReadLine());

volumeEsfera = 4 / 3f * pi * (float)Math.Pow(raio, 3);
volumeCubo = (float)Math.Pow(aresta, 3);
volumeLivre = volumeCubo - volumeEsfera;

Console.WriteLine("O volume livre do ambiente é: " + volumeLivre);

#elif exercicio9

/* Entrar via teclado com o valor da cotação do dólar e 
uma certa quantidade de dólares. Calcular e exibir o 
valor correspondente em Reais (R$). */

float cotacao, dolar, reais;

Console.WriteLine("Informe a cotacação do dolar: ");
cotacao = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de dólares: ");
dolar = float.Parse(Console.ReadLine());

reais = cotacao * dolar;

Console.WriteLine("O valor correspondente em real é: " + reais);

#elif exercicio10

/* Entrar via teclado com o valor de 5 (cinco) produtos. 
Após as entradas, digitar um valor referente ao pagamento 
da somatória destes valores. Calcular e exibir o troco que deverá ser 
devolvido. */

float produtoUm, produtoDois, produtoTres, produtoQuatro, produtoCinco,
pagamento, troco;

Console.WriteLine("Digite o valor dos 5 produtos em sequência: ");
produtoUm = float.Parse(Console.ReadLine());
produtoDois = float.Parse(Console.ReadLine());
produtoTres = float.Parse(Console.ReadLine());
produtoQuatro = float.Parse(Console.ReadLine());
produtoCinco = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de pagamento: ");
pagamento = float.Parse(Console.ReadLine());

troco = pagamento - (produtoUm + produtoDois + produtoTres + produtoQuatro + produtoCinco);

Console.WriteLine("O troco é: " + troco);

#endif