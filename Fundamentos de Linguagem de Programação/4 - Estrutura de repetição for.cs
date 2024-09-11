// Diretivas condicionais:
#define exercicio1

#if exercicio1

/* Calcular e exibir a soma dos “N” primeiros valores da 
sequência abaixo. O valor “N” será digitado, deverá ser 
positivo, mas menor ou igual a 20 (vinte).

1, 2, 3, 4,
-  -  -  - ...
2, 3, 4, 5 
*/

int N;
float result = 0f;

for (N = 0; N <= 0 || N > 20;)
{
    Console.WriteLine("informe um valor:");
    N = int.Parse(Console.ReadLine());
    if (N < 1 || N > 20)
    {
        Console.WriteLine("Valor inválido, ele dever estar entre 1 e 20.");
    }
}

for (int num = 1, den = 2; num <= N; num++, den++)
{
    result += (float)num / den;
}
Console.WriteLine("A soma é: {0:F3}", result);

#elif exercicio2

/* Calcular e exibir a soma dos “N” primeiros valores da 
sequência abaixo. O valor “N” será digitado, deverá ser 
positivo, mas menor ou igual a 50 (cinquenta).

2  5  10  17
-, -, --, --, ...
1  8  27  64

*/

int n;
float soma = 0f;

for (n = 0; n <= 0 || n > 50;)
{
    Console.WriteLine("Informe um valor: ");
    n = int.Parse(Console.ReadLine());
    if (n < 1 || n > 50)
    {
        Console.WriteLine("Numero digitado inválido. Ele deve estar entre 1 e 50.");
    }
}

for (int num = 1; num <= n; num++)
{
    soma += (float)((Math.Pow(num, 2) + 1) / Math.Pow(num, 3));
}

Console.WriteLine(soma);

#elif exercicio3

/* A prefeitura de uma cidade fez uma pesquisa entre 
seus 10 (dez) habitantes, coletando dados sobre o 
salário e o número de filhos. A prefeitura deseja saber: 

a) a média dos salários da população;
b) a média dos números de filhos; 
c) o maior salário; 
d) a porcentagem de pessoas com salários até R$ 1.000,00. */

int habitante, numeroFilhos = 0;
float salario = 0f, mediaSalario = 0f, mediaNumeroFilhos, maiorSalario = 0f, porcPessoas = 0f;

for (habitante = 1; habitante <= 10; habitante++)
{
    Console.Write("Informe o numero de filhos do habitante {0}: ", habitante);
    numeroFilhos += int.Parse(Console.ReadLine());

    Console.Write("Informe o salario do habitante {0}: ", habitante);
    salario = float.Parse(Console.ReadLine());

    mediaSalario += salario;

    if (salario > maiorSalario)
    {
        maiorSalario = salario;
    }
    if (salario <= 1000)
    {
        porcPessoas += 1; // 1 = 10%
    }

    Console.WriteLine();
}

mediaSalario /= (float)(10 + numeroFilhos);
mediaNumeroFilhos = (float)numeroFilhos / 10;
porcPessoas *= 10; // transformação para %

Console.WriteLine("a) A média dos salários da população é: " + mediaSalario);
Console.WriteLine("b) A média dos números de filhos é: " + mediaNumeroFilhos);
Console.WriteLine("c) o maior salário é: " + maiorSalario);
Console.WriteLine("d) a porcentagem de pessoas com salário de até 1.000,00 é: {0}% ", porcPessoas);

#elif exercicio4

/*  Uma pessoa faz uma aplicação no valor digitado pelo usuário, 
durante 11 meses, a uma taxa de juros compostos de 5% a.m., 
capitalizados mensalmente. Calcular o montante no final do prazo. */

float valor = 0f, taxa = 0.05f;

for (int meses = 1; meses <= 11; meses++)
{
    valor += valor * taxa;

    Console.Write("Digite o valor da aplicação no {0}° mês: ", meses);
    valor += float.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Montante no finaldo prazo: {0:F2}", valor);

#endif