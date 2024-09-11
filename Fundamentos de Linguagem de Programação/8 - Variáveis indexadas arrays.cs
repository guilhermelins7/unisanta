// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Desenvolva um programa que armazene em um vetor os 10 
primeiros termos da série abaixo:
1 2 3 4
- - - - 
2 3 4 5
 */

float[] vetor = new float[10];
int valor = 1;

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = (float)valor / ++valor;
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("{0:F3}, ", vetor[i]);
}

Console.WriteLine();

#elif exercicio2

/* Crie um programa que armazene na memória do computador, 
os 100 primeiros números inteiros múltiplos de 5. */

int[] vetor = new int[100];

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = i * 5;
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("{0}, ", vetor[i]);
}

Console.WriteLine();

#elif exercicio3

/* Descreva um programa que armazene em um vetor 20 números inteiros e 
positivos que são digitados, e que em seguida leia esse vetor calculando 
a média aritmética dos números que são ímpares.*/

int[] vetor = new int[20];
float media = 0.0f;
int valores = 0;

for (int i = 0; i < vetor.Length; i++)
{
    do
    {
        Console.Write("Digite um número inteiro e positivo para armazenar na posição {0}° do vetor: ", i + 1);
        vetor[i] = int.Parse(Console.ReadLine());
    } while (vetor[i] <= 0);
}

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 != 0)
    {
        media += (float)vetor[i];
        valores++;
    }
}

media /= (float)valores;
Console.WriteLine("média aritmética dos números que são ímpares: " + media);

#elif exercicio4

/* Armazenar um máximo de 20 valores em um vetor. A quantidade de valores a serem 
armazenados será escolhida pelo usuário. Enviar mensagem de erro, caso a quantidade 
de valores escolhida esteja fora da faixa possível e solicitar a quantidade novamente. 
Após a digitação dos valores, criar uma rotina de consulta, onde o usuário digita um número 
e o programa exibe em qual posição do vetor este número está localizado. Se o número não for 
encontrado, enviar mensagem “Valor não encontrado!”. */

int valores, numero;
bool encontrado = false;

do
{
    Console.Write("Informe a quantidade de valores a serem armazenados:");
    valores = int.Parse(Console.ReadLine());
    if (valores < 0 || valores > 20)
    {
        Console.WriteLine("Valor fora da faixa, digite novamente um valor valido.");
    }
} while (valores < 0 || valores > 20);

int[] vetor = new int[valores];

for (int i = 0; i < vetor.Length; i++)
{
    Console.Write("Informe o {0}° valor: ", i + 1);
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Valores armazenados.");

Console.Write("Informe um número para consultar se existe no vetor:");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < vetor.Length; i++)
{
    if (numero == vetor[i])
    {
        Console.WriteLine("O número está localizado no indice {0} do vetor.", i);
        encontrado = true;
    }
}

if (encontrado = false)
{
    Console.WriteLine("Valor não encontrado!");
}

#elif exercicio5

/* Desenvolva um programa que receba uma palavra via teclado e verifique se ela é 
“palíndroma”. Uma palavra é “palíndroma” se é idêntica quando lida de trás para diante. 
Por exemplo, "ovo" é um palíndromo.*/

string palavra = "";
bool pali = true;

Console.Write("digite uma palavra para checar se é palíndroma: ");
palavra = Console.ReadLine();

for (int f = (palavra.Length - 1), i = 0; i < palavra.Length; f--, i++)
{
    if (palavra[f] != palavra[i])
    {
        pali = false;
    }
}

if (pali == true)
{
    Console.WriteLine("a palavra {0} é palíndroma.", palavra);
}
else
{
    Console.WriteLine("a palavra {0} não é palíndroma.", palavra);
}

#elif exercicio6

/* Armazenar dez valores em um vetor. Após a digitação, exibir 
os valores em ordem crescente. */

int[] valores = new int[10];

for (int i = 0; i < valores.Length; i++)
{
    Console.Write("Informe o {0}° valor: ", i + 1);
    valores[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < valores.Length - 1; i++)
{
    for (int c = 0; c < valores.Length - 1 - i; c++)
    {
        if (valores[c] > valores[c + 1])
        {
            int temp = valores[c];
            valores[c] = valores[c + 1];
            valores[c + 1] = temp;
        }
    }
}

Console.WriteLine("Valores em ordem crescente: ");

for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine(valores[i]);
}

#endif