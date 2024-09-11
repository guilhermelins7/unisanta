// Diretivas condicionais
#define exercicio1

#if exercicio1

/* Verificar se três valores quaisquer (A, B, C) que serão digitados 
formam ou não um triângulo retângulo. Lembre-se que o quadrado da 
hipotenusa é igual à soma dos quadrados dos catetos. */

float hipotenusa, catetoUm, catetoDois;
float a, b, c;

Console.WriteLine("Digite 3 valores:");
a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());
c = float.Parse(Console.ReadLine());

if (a > b && a > c)
{
    hipotenusa = a;
    catetoUm = b;
    catetoDois = c;
}
else if (b > c)
{
    hipotenusa = b;
    catetoUm = a;
    catetoDois = c;
}
else
{
    hipotenusa = c;
    catetoUm = a;
    catetoDois = b;
}

if (Math.Pow(hipotenusa, 2f) == Math.Pow(catetoUm, 2f) + Math.Pow(catetoDois, 2f))
{
    Console.WriteLine("Os números formam um triangulo retangulo.");
}
else
{
    Console.WriteLine("Os números não formam um triangulo retangulo.");
}

#elif exercicio2

/* Entrar com o peso, o sexo e a altura de uma determinada pessoa. 
Após a digitação, exibir se esta pessoa está ou não com seu peso ideal. 
Veja tabela da relação peso/altura2:

Relação p/a² Feminino  |    Mensagem
-----------------------------------------
      R < 19           |  Abaixo do peso
    19 <= R < 24.      |    Peso ideal
      R >= 24          |  Acima do peso
 -----------------------------------------

Relação p/a² Masculino |    Mensagem
-----------------------------------------
      R < 20           |  Abaixo do peso
    20 <= R < 25.      |    Peso ideal
      R >= 25          |  Acima do peso
 -----------------------------------------
*/

float peso, altura, relacao;
string sexo;

Console.WriteLine("Informe o seu sexo: [F] ou [M]");
sexo = Console.ReadLine().ToUpper();

Console.WriteLine("Informe sua altura:");
altura = float.Parse(Console.ReadLine());

Console.WriteLine("Informe seu peso:");
peso = float.Parse(Console.ReadLine());

relacao = peso / (float)Math.Pow(altura, 2);


Console.WriteLine("\nRelação Pese/altura²: " + relacao);

switch (sexo)
{
    case "F":
        if (relacao >= 24)
        {
            Console.WriteLine("acima do Peso.");
        }
        else if (relacao >= 19)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("abaixo do peso");
        }
        break;
    case "M":
        if (relacao >= 25)
        {
            Console.WriteLine("acima do Peso.");
        }
        else if (relacao >= 20)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("abaixo do peso");
        }
        break;
    default:
        Console.WriteLine("Alguma informação foi inválida.");
        break;
}

#elif exercicio3

/* A partir dos valores da aceleração (a em m/s²), da 
velocidade inicial (v0 em m/s) e do tempo de percurso(t em s).
Calcular e exibir a velocidade final de automóvel em km/h. 
Exibir mensagem de acordo com a tabela abaixo. Fórmula para o cálculo 
da velocidade em m/s: V = v0 + a.t. 

Velocidade em Km/h (V)  |        Mensagem
-------------------------------------------------
      V < = 40          |    Veículo muito lento
    40 < V <= 60        |   Velocidade permitida
    80 < V <= 120       |  Velocidade de cruzeiro
    60 < V <= 80        |     Veículo rápido
      R >= 120          |   Veículo muito rápido
 ------------------------------------------------
 
*/

float aceleracao, velocidadeInicial, tempoPercurso, velocidadeFinal;
string mensagem;

Console.WriteLine("Para Calcular a Velocidade Final:");

Console.Write("Informe a aceleração: ");
aceleracao = float.Parse(Console.ReadLine());

Console.Write("Informe a velocidade inicial: ");
velocidadeInicial = float.Parse(Console.ReadLine());

Console.Write("Informe o tempo de percurso: ");
tempoPercurso = float.Parse(Console.ReadLine());

velocidadeFinal = (velocidadeInicial + aceleracao * tempoPercurso) * (float)3.6;

Console.Clear();
Console.WriteLine("Velocidade Final do veículo: {0} km/h", velocidadeFinal);

switch (velocidadeFinal)
{
    case >= 120:
        mensagem = "Veículo muito rápido.";
        break;
    case > 80:
        mensagem = "Veículo rápido.";
        break;
    case > 60:
        mensagem = "Velocidade de cruzeiro.";
        break;
    case > 40:
        mensagem = "Velocidade permitida.";
        break;
    case > 0:
        mensagem = "Veículo muito lento.";
        break;
    default:
        mensagem = "Veículo parado.";
        break;
}

Console.WriteLine(mensagem);

#endif