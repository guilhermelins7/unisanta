// Diretivas condicionais.
#define exercicio1

#if exercicio1

/* Descreva um programa que calcule a soma dos 
números inteiros positivos menores que 100. */

int number = 1, soma = 0;

do
{
    soma += number;
    number++;
} while (number < 100);

Console.WriteLine(soma);

#elif exercicio2

/* Descreva um programa que exiba no monitor os 100 
primeiros números inteiros múltiplos de 5. */

int fiveMult = 5;
int contador = 1;

do
{
    Console.WriteLine(fiveMult * contador);
    contador++;
} while (contador <= 100);

#elif exercicio3

/*  Descreva um programa que a calcule a soma de: 1 + 
3 + 5 + 7 + … + 121. */

int number = 1;
int soma = 0;

do
{
    soma += number;
    number += 2;
} while (number <= 121);

Console.WriteLine(soma);

#elif exercicio4

/* Descreva um programa que exiba no monitor a 
sequência de números: 10, 8, 6, 4, 2,0. */

int number = 10;

do
{
    Console.Write("{0}, ", number);
    number -= 2;
} while (number != -2);

#elif exercicio5

/* Calcule e exiba no monitor a soma e o produto dos 5
primeiros termos da série:

1   1   1   1    1
- + - + - + -- + -- ...
1   4   9   16   25

 */

int denominador = 1, divisor = 1;
float soma = 0, produto = 1;

do
{
    soma += (float)denominador / (divisor * divisor);
    produto *= (float)denominador / (divisor * divisor);

    divisor++;
} while (divisor <= 5);

Console.WriteLine("Soma: {0}\nProduto: {1}", soma, produto);

#elif exercicio6

/* Desenvolva um programa que multiplique dois números 
inteiros A e B, que são digitados via teclado, utilizando 
somente somas. Proteja para que a digitação garanta 
que A seja maior que B bem como A e B sejam inteiros. */

int a, b, multi = 0;

Console.WriteLine("Digite o valor de a:");
a = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Digite o valor de b, que deve ser menor que a: ");
    b = int.Parse(Console.ReadLine());
    if (b >= a)
    {
        Console.WriteLine("Valor inválido,");
    }
} while (b >= a);

do
{
    multi += a;
    b--;
} while (b != 0);

Console.WriteLine("A multiplicação dos números é: " + multi);

#elif exercicio7

/* Analise o tempo de execução do problema anterior e 
determine uma solução na qual a multiplicação ocorra 
num tempo mínimo */

int a, b, multi = 0;

Console.WriteLine("Digite o valor de a:");
a = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Digite o valor de b, que deve ser menor que a: ");
    b = int.Parse(Console.ReadLine());
    if (b >= a)
    {
        Console.WriteLine("Valor inválido,");
    }
    else
    {
        do
        {
            multi += a;
            b--;
        } while (b != 0);
    }
} while (b >= a);

Console.WriteLine("A multiplicação dos números é: " + multi);

#elif exercicio8

/* Desenvolva um programa que calcule a soma dos 
algarismos de um número inteiro “N” digitado via 
teclado. */

int n = 0, numero, soma = 0, casasDecimais = 1;

do
{
    Console.WriteLine("Digite um número de dois algarismos positivo: ");
    n = int.Parse(Console.ReadLine());
    if (n < 10)
    {
        Console.WriteLine("Número inválido,");
    }
} while (n < 10);

numero = n;

do
{
    do
    {
        if (numero > 9)
        {
            numero /= 10;
            casasDecimais *= 10;
        }
    } while (numero > 9);

    soma += numero;
    numero = n % casasDecimais;
    casasDecimais = 1;

} while (numero > 0);

Console.WriteLine(soma);

#elif exercicio9

/* Descreva um programa que calcule a potência inteira 
N qualquer de um número positivo B utilizando somente 
produtos. Prever a possibilidade de N ser maior, menor 
ou igual a zero. */

int n, b;
float potencia = 0;

do
{
    Console.WriteLine("Informe um número positivo:");
    b = int.Parse(Console.ReadLine());
    if (b <= 0)
    {
        Console.WriteLine("Valor inválido");
    }
} while (b <= 0);

Console.WriteLine("Informe qual é a potência N a ser elevada:");
n = int.Parse(Console.ReadLine());

potencia = b;

if (n > 0)
{
    do
    {
        potencia *= b;
        n--;
    } while (n >= 2);
}
else if (n == 0)
{
    potencia = 0;
}
else
{
    do
    {
        potencia *= b;
        n--;
    } while (n >= 2);

    potencia = (float)1 / potencia;
}

Console.WriteLine("A potência é: " + potencia);

#elif exercicio10

/* Desenvolva um programa que exiba no vídeo os 20 
primeiros números primos. Um número é, por definição, 
primo se ele não tem divisores, exceto 1 e ele próprio. */

int numero = 1, contador = 0, primo = 1;
bool prim = true;

do
{
    if (numero == 1 || numero == 2)
    {
        Console.Write("{0}, ", numero);

        numero++;
        primo++;
    }
    else
    {
        contador = numero - 1;
        do
        {
            if (numero % contador == 0)
            {
                prim = false;
            }

            contador--;

        } while (contador > 1);

        if (prim == true)
        {
            Console.Write("{0}, ", numero);
            primo++;
        }

        prim = true;
        numero++;

    }
} while (primo <= 20);

Console.WriteLine();

#endif