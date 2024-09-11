// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Entrar via teclado, com dois valores distintos. Exibir o 
maior deles. */

int valorUm, valorDois;

Console.WriteLine("Digite o primeiro valor:");
valorUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
valorDois = int.Parse(Console.ReadLine());

if (valorUm > valorDois)
{
    Console.WriteLine("O primeiro valor digitado é maior.");
}
else if (valorUm == valorDois)
{
    Console.WriteLine("os valores são iquais.");
}
else
{
    Console.WriteLine("O segundo valor digitado é maior");
}

#elif exercicio2

/* Entrar via teclado, com dois valores distintos. Exibir o 
menor deles. */

int valorUm, valorDois;

Console.WriteLine("Digite o primeiro valor: ");
valorUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
valorDois = int.Parse(Console.ReadLine());

if (valorUm < valorDois)
{
    Console.WriteLine("O primeiro valor digitado é menor.");
}
else if (valorUm == valorDois)
{
    Console.WriteLine("Os valores são Iquais");
}
else
{
    Console.WriteLine("O segundo valor digitado é menor.");
}

#elif exercicio3

/* Entrar com dois valores quaisquer. Exibir o maior deles,se existir, 
caso contrário, enviar mensagem avisando que os números são idênticos. */

int valorUm, valorDois;

Console.WriteLine("Digite o primeiro valor:");
valorUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
valorDois = int.Parse(Console.ReadLine());

if (valorUm > valorDois)
{
    Console.WriteLine("O primeiro valor digitado é maior.");
}
else if (valorUm == valorDois)
{
    Console.WriteLine("Os valores são iquais.");
}
else
{
    Console.WriteLine("O segundo valor digitado é maior");
}

#elif exercicio4

/* Calcular e exibir a área de um retângulo, a partir dos 
valores da base e altura que serão digitados. Se a área for maior 
que 100, exibir a mensagem “Terreno grande”. */

float area, bas, altura;

Console.WriteLine("Para calcular a área do retângulo, digite o valor de sua base:");
bas = float.Parse(Console.ReadLine());

Console.WriteLine("Agora, digite o valor de sua altura:");

altura = float.Parse(Console.ReadLine());
area = bas * altura;

Console.WriteLine("");

if (area > 100)
{
    Console.WriteLine("área do triangulo:" + area);
    Console.WriteLine("Terreno Grande!");
}
else
{
    Console.WriteLine("área do triangulo:" + area);
}

#elif exercicio5

/* Entrar via teclado com três valores distintos. Exibir o 
maior deles. */

int valorUm, valorDois, valorTres;
Console.WriteLine("Digite três valores");
valorUm = int.Parse(Console.ReadLine());
valorDois = int.Parse(Console.ReadLine());
valorTres = int.Parse(Console.ReadLine());

if (valorUm > valorDois && valorUm > valorTres)
{
    Console.WriteLine("O Primeiro valor digitado é maior");
}
else if (valorDois > valorTres)
{
    Console.WriteLine("O segundo valor digitado é maior");
}
else
{
    Console.WriteLine("O terceiro valor digitado é maior.");
}

#endif