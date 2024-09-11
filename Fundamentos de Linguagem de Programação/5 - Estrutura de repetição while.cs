// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Criar uma rotina de entrada que aceite somente um 
valor positivo. */

int valor = 0;

while (valor <= 0)
{
    Console.Write("Digite um valor positivo: ");
    valor = int.Parse(Console.ReadLine());
    if (valor <= 0)
    {
        Console.WriteLine("Valor inválido.");
    }
}

Console.WriteLine("\nValor OK: " + valor);

#elif exercicio2

/* Entrar com (dois) valores via teclado, onde o segundo deverá ser maior 
que o primeiro. Caso contrário solicitar novamente apenas o segundo valor. */

int valorUm, valorDois;

Console.WriteLine("Digite o primeiro valor:");
valorUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor, maior que o primeiro:");
valorDois = int.Parse(Console.ReadLine());

while (valorDois <= valorUm)
{
    Console.WriteLine("Digite o segundo valor, maior que o primeiro:");
    valorDois = int.Parse(Console.ReadLine());
    if (valorDois <= valorUm)
    {
        Console.WriteLine("Valor inválido,");
    }
}

Console.WriteLine("\n1° valor = {0}, 2° valor = {1}", valorUm, valorDois);

#elif exercicio3

/* Entrar via teclado com o sexo de determinado usuário, 
aceitar somente “F” ou “M” como respostas válidas. */

char s = ' ';

Console.Write("Sexo:");
while (s != 'M' && s != 'F')
{
    Console.SetCursorPosition(5, 0);
    s = Console.ReadKey().KeyChar;
}

Console.Write("\nOK");

Console.ReadKey();

#elif exercicio4

/* Exibir a tabuada do número 5 (cinco) no intervalo de 
um a dez. */

int number = 1;

while (number <= 10)
{
    Console.WriteLine("5 * {0} = {1}", number, number * 5);
    number++;
}

#elif exercicio5

/* Entrar via teclado com um valor qualquer. Travar a 
digitação, no sentido de aceitar somente valores 
positivos. Após a digitação, exibir a tabuada do valor 
solicitado, no intervalo de um a dez. */

int valor = 0, tabuada = 0;

while (tabuada <= 0)
{
    Console.Write("Digite um valor positivo: ");
    tabuada = int.Parse(Console.ReadLine());
    if (tabuada <= 0)
    {
        Console.WriteLine("Valor inválido,");
    }
}

while (valor <= 10)
{
    Console.WriteLine("{0} * {1} = {2}", tabuada, valor, tabuada * valor);
    valor++;
}

#elif exercicio6

/* Entrar via teclado com um valor (X) qualquer. Travar a digitação, 
no sentido de aceitar somente valores positivos. Solicitar o intervalo 
que o programa que deverá calcular a tabuada do valor digitado, sendo 
que o segundo valor (B), deverá ser maior que o primeiro (A), caso 
contrário, digitar novamente somente o segundo. Após a validação dos dados, 
exibir a tabuada do valor digitado, no intervalo decrescente, ou seja, 
a tabuada de X no intervalo de B para A.*/

int x = 0, a, b;

while (x <= 0)
{
    Console.Write("Digite um valor positivo: ");
    x = int.Parse(Console.ReadLine());

    if (x <= 0)
    {
        Console.WriteLine("Valor inválido,");
    }
}

Console.Write("Digite o valor de a:");
a = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de b:");
b = int.Parse(Console.ReadLine());

while (b <= a)
{
    if (b <= a)
    {
        Console.WriteLine("Valor inválido, b deve ser maior que a.");
    }

    Console.Write("Digite o valor de b:");
    b = int.Parse(Console.ReadLine());
}

a--;

while (b != a)
{
    Console.WriteLine("{0} * {1} = {2}", x, b, x * b);
    b--;
}

#elif exercicio7

/* Exibir a tabuada dos valores de um a vinte, no intervalo 
de um a dez. Entre as tabuadas, solicitar que o usuário 
pressione uma tecla. */

int tabuada = 1, valor = 1;

while (tabuada <= 20)
{
    Console.WriteLine("Tabuada do {0}:\n", tabuada);

    while (valor <= 10)
    {
        Console.WriteLine("{0} * {1} = {2}", tabuada, valor, tabuada * valor);
        valor++;
    }

    Console.WriteLine("\nDigite uma tecla para exibir a tabuada seguinte.");

    Console.ReadKey();
    Console.Clear();

    valor = 0;
    tabuada++;
}

#elif exercicio8

/* Exibir a soma dos números inteiros positivos do intervalo 
de um a cem. */

int contador = 1, valor = 0;

while (contador <= 100)
{
    valor += contador;
    contador++;
}

Console.WriteLine(" soma dos números inteiros positivos do intervalo de um à cem: " + valor);

#elif exercicio9

/* Descreva um programa que receba via teclado 10 (dez) valores 
e que, ao final, exiba o maior e menor deles. */

int contador = 1, valor = 1, maiorValor, menorValor;

Console.Write("Digite o {0}° valor: ", contador);
valor = int.Parse(Console.ReadLine());

maiorValor = valor;
menorValor = valor;
contador++;

while (contador <= 10)
{
    Console.Write("Digite o {0}° valor: ", contador);
    valor = int.Parse(Console.ReadLine());

    if (valor > maiorValor)
    {
        maiorValor = valor;
    }
    if (valor < menorValor)
    {
        menorValor = valor;
    }

    contador++;
}

Console.WriteLine("\nMaior valor digitado: {0}\nMenor valor digitado: {1} ", maiorValor, menorValor);

#elif exercicio10

/* . Exibir os 30 (trinta) primeiros valores da série de 
Fibonacci. A série: 1, 1, 2, 3, 5, 8, ... */

int contador = 1, nacciA = 1, nacciB = 1, aux;

Console.WriteLine("Sequência Fibonnaci:");

while (contador <= 15)
{
    Console.Write("{0}, {1}, ", nacciA, nacciB);

    aux = nacciA + nacciB;
    nacciA = aux;
    nacciB = aux + nacciB;

    contador++;
}

Console.WriteLine();

#endif