// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Calcular e exibir a área de um quadrado, a partir 
do valor de sua aresta que será digitado. */

float quadrado, aresta;

Console.WriteLine("Digite o valor da aresta:");
aresta = float.Parse(Console.ReadLine());

quadrado = (float)Math.Pow(aresta, 2f); // || aresta * aresta;

Console.WriteLine("A área do quadrado é: " + quadrado);

#elif exercicio2

/* Calcular e exibir a área de um quadrado a partir do 
valor de sua diagonal que será digitado. */

float area, diagonal;

Console.WriteLine("Digite o valor da diagonal: ");
diagonal = float.Parse(Console.ReadLine());

area = (float)Math.Pow(diagonal, 2) / 2;

Console.WriteLine("A área do quadrado é " + area);

#elif exercicio3

/* A partir dos valores da base e altura de um 
triângulo, calcular e exibir sua área. */

float bas, altura, area;

Console.WriteLine("Digite o valor da base:");
bas = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da altura:");
altura = float.Parse(Console.ReadLine());

area = (bas * altura) / 2;

Console.WriteLine("A área do triangulo é: " + area);

#elif exercicio4

/* Calcular e exibir o volume de uma esfera a partir do 
valor de seu diâmetro que será digitado. */

float pi = 3.141f, volume, diametro, raio;

Console.WriteLine("Digite o valor do diametro: ");
diametro = float.Parse(Console.ReadLine());

raio = diametro / 2;

volume = (float)(4 * Math.Pow(raio, 3) / 3) * pi;

Console.WriteLine("O valor do volume é: {0}", volume);

#elif exercicio5

/* Calcular e exibir a média aritmética de quatro 
valores quaisquer que serão digitados. */

float media, a, b, c, d;

Console.WriteLine("Digite:");

Console.Write("Valor 1: ");
a = float.Parse(Console.ReadLine());

Console.Write("Valor 2: ");
b = float.Parse(Console.ReadLine());

Console.Write("Valor 3: ");
c = float.Parse(Console.ReadLine());

Console.Write("Valor 4: ");
d = float.Parse(Console.ReadLine());

media = (a + b + c + d) / 4;

Console.WriteLine("O valor da sua média aritmética é: " + media);

#endif