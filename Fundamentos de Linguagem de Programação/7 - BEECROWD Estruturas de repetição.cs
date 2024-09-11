// Exercicios da plataforma judge.beecrowd.com
// Diretivas condicionais:
#define exercicio1

#if exercicio1

/* 1144 (Sequência Lógica) */

int n;

n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("{0} {1} {2}\n", i, Math.Pow(i, 2), Math.Pow(i, 3));
    Console.Write("{0} {1} {2}\n", i, Math.Pow(i, 2) + 1, Math.Pow(i, 3) + 1);
}

#elif exercicio2

/* 1146 (Sequências crescentes) */

int x;

do
{
    x = int.Parse(Console.ReadLine());

    for (int i = 1; i <= x; i++)
    {
        if (i == x)
        {
            Console.WriteLine("{0}", i);
        }
        else
        {
            Console.Write("{0} ", i);
        }
    }
} while (x != 0);

#elif exercicio3

/* 1154 (Idades) */

int idade = 0, pessoas = 0;
float media = 0.0f;

idade = int.Parse(Console.ReadLine());

while (idade >= 0)
{
    pessoas++;
    media += idade;

    idade = int.Parse(Console.ReadLine());
}

media /= (float)pessoas;

Console.WriteLine("{0:F2}", media);

#elif exercicio4

/* 1156 (Sequência S II) */

float s = 0f;

for (int den = 1, div = 1; den <= 39; den += 2, div *= 2)
{
    s += (float)den / div;
}

Console.Write("{0:F2}", s);

#elif exercicio5

/* 1159 (Soma de Pares Consecutivos) */

int x, soma;

do
{
    soma = 0;
    x = int.Parse(Console.ReadLine());

    if (x != 0)
    {
        for (int par = 1, num = x; par <= 5; num++)
        {
            if (num % 2 == 0)
            {
                soma += num;
                par++;
            }
        }
        Console.WriteLine(soma);
    }
} while (x != 0);

#elif exercicio6

/* 1164 (Número Perfeito) */

int repeticoes, numero, confere, soma;
bool perfeito;

repeticoes = int.Parse(Console.ReadLine());

for (int i = 0; i < repeticoes; i++)
{
    perfeito = false;

    numero = int.Parse(Console.ReadLine());

    for (soma = 0, confere = 1; confere < numero; confere++)
    {
        if (numero % confere == 0)
        {
            soma += confere;
        }
    }

    if (numero == soma)
    {
        perfeito = true;
    }

    if (perfeito == true)
    {
        Console.WriteLine("{0} eh perfeito", numero);
    }
    else
    {
        Console.WriteLine("{0} nao eh perfeito", numero);
    }
}

#endif