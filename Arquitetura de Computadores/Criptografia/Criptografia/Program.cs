#define criptografar // || descriptografar

#if criptografar

string senha = "01_Essa_é_Uma_Senha_Teste!";

string reverso = Reverter(senha);
string cifra = CifraDeCesar(reverso);
string criptografia = Criptografar(cifra);

Console.WriteLine("Senha teste: " + senha);
Console.WriteLine("Senha criptografada: " + criptografia);

static string Reverter(string senha)
{
    string resultado = "";

    for (int index = senha.Length - 1; index >= 0; index--)
    {
        resultado += senha[index];
    }

    return resultado;
}

static string CifraDeCesar(string senha)
{
    string resultado = "";

    for (int index = 0; index < senha.Length; index++) // Aplicação cifra de cesar
    {
        int aux = (int)senha[index] + 3; // convertando para valor ASCII inteiro e adicionando + 3;
        resultado += (char)aux; // retornando para char e adicionando à string.
    }

    return resultado;
}

static string Criptografar(string senha)
{
    string criptografia = "";
    int aux;
    int valor = 0;

    for (int index = 0; index < senha.Length; index++)
    {
        aux = (int)(senha[index] + (Math.Pow(2, valor) + 1)); // Aplicando função do TP.
        criptografia += (char)aux;
        valor++;

        if (valor == 3)
        {
            valor = 0;
        }
    }

    return criptografia;
}

#elif descriptografar

string criptografia = "&k|xk\\dgpsk[dguZeñdg{xKg66";

string descriptografia = Descriptografar(criptografia);
string cifraRevertida = ReverterCifraDeCesar(descriptografia);
string senha = Reverter(cifraRevertida);

Console.WriteLine("Senha criptografada: " + criptografia);
Console.WriteLine("Senha teste: " + senha);

static string Descriptografar(string senha)
{
    string criptografia = "";
    int aux;
    int valor = 0;

    for (int index = 0; index < senha.Length; index++)
    {
        aux = (int)(senha[index] - (Math.Pow(2, valor) + 1));
        criptografia += (char)aux;
        valor++;

        if (valor == 3)
        {
            valor = 0;
        }
    }

    return criptografia;
}

static string ReverterCifraDeCesar(string senha)
{
    string resultado = "";

    for (int index = 0; index < senha.Length; index++)
    {
        int aux = (int)senha[index] - 3;
        resultado += (char)aux;
    }

    return resultado;
}

static string Reverter(string senha)
{
    string resultado = "";

    for (int index = senha.Length - 1; index >= 0; index--)
    {
        resultado += senha[index];
    }

    return resultado;
}

#endif