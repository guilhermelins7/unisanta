// Exercicios da plataforma judge.beecrowd.com
// Diretivas condicionais:
#define exercicio1


#if exercicio1

/* 1177 (Preenchimento de Vetor II) */

int valorRecebido;
int[] N = new int[1000];

do
{
    valorRecebido = int.Parse(Console.ReadLine());
} while (valorRecebido < 2 || valorRecebido > 50); // validação do valor

Console.Clear();

for (int i = 0, num = 0; i < N.Length; i++, num++) // laço para ir até numero
{
    if (valorRecebido == num) // Voltar ao valor 0
    {
        num = 0;
    }
    N[i] = num;
}
for (int i = 0; i < N.Length; i++)
{
    Console.WriteLine("N[{0}] = {1}", i, N[i]);
}

#elif exercicio2

/* 1179 (Preenchimento de Vetor IV) */

int[] pares = new int[5];
int[] impares = new int[5];
int cPar = 0, cImp = 0;

for (int i = 1; i <= 15; i++) // Garante que lê 15 valores
{
    int valor = int.Parse(Console.ReadLine()); // Leitura do valor

    if (valor % 2 == 0) // Contador pares
    {
        pares[cPar] = valor;
        cPar++;
    }
    else // Contador impares
    {
        impares[cImp] = valor;
        cImp++;
    }
    if (cPar == 5) // Exibir vetores pares
    {
        for (int e = 0; e <= 4; e++)
        {
            Console.WriteLine("par[{0}] = {1}", e, pares[e]);
        }
        cPar = 0;
    }
    else if (cImp == 5) // Exibir vetores impares
    {
        for (int e = 0; e <= 4; e++)
        {
            Console.WriteLine("impar[{0}] = {1}", e, impares[e]);
        }
        cImp = 0;
    }
}

// Exibir valores restantes

for (int e = 0; e < cImp; e++)
{
    Console.WriteLine("impar[{0}] = {1}", e, impares[e]);
}

for (int e = 0; e < cPar; e++)
{
    Console.WriteLine("par[{0}] = {1}", e, pares[e]);
}

#endif