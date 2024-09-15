# Algoritmo de Criptografia e Descriptografia

Este projeto demonstra um sistema simples de criptografia e descriptografia proposto inicialmente nas aulas de Arquitetura de Computadores. Foram utilizadas uma combinação de técnicas, incluindo uma função matemática proposta em aula e Cifra de César que incrementei posteriormente. O código é projetado para permitir tanto a criptografia quanto a descriptografia de uma senha.

## Estrutura do Código

O código está estruturado para permitir a seleção entre a criptografia e a descriptografia através de diretivas de compilação (`#define` e `#if`).

### Diretiva de Compilação

Para escolher entre criptografar ou descriptografar, defina `#define criptografar` ou `#define descriptografar` no início do código.

```csharp
#define criptografar // || descriptografar
```

## Funcionalidade

### Criptografia

Quando `#define criptografar` está ativo:

1. **Reverter**: Reverte a senha original.
2. **Cifra de César**: Aplica uma cifra de César à senha revertida (deslocamento de +3 no valor ASCII dos caracteres).
3. **Criptografar**: Aplica uma função matemática de criptografia personalizada que adiciona um valor baseado em uma função exponencial ao valor ASCII dos caracteres.

```csharp
static string Reverter(string senha) { ... }
static string CifraDeCesar(string senha) { ... }
static string Criptografar(string senha) { ... }
```

### Descriptografia

Quando `#define descriptografar` está ativo:

1. **Descriptografar**: Reverte o processo da função matemática de criptografia.
2. **Reverter Cifra de César**: Reverte o deslocamento aplicado pela cifra de César (deslocamento de -3 no valor ASCII dos caracteres).
3. **Reverter**: Reverte a senha descriptografada para obter a senha original.

```csharp
static string Descriptografar(string senha) { ... }
static string ReverterCifraDeCesar(string senha) { ... }
static string Reverter(string senha) { ... }
```

## Exemplos

### Criptografia

```csharp
#define criptografar

string senha = "01_Essa_é_Uma_Senha_Teste!";
string reverso = Reverter(senha);
string cifra = CifraDeCesar(reverso);
string criptografia = Criptografar(cifra);

Console.WriteLine("Senha teste: " + senha);
Console.WriteLine("Senha criptografada: " + criptografia); // retorna "&k|xk\\dgpsk[dguZeñdg{xKg66"
```

### Descriptografia

```csharp
#define descriptografar

string criptografia = "&k|xk\\dgpsk[dguZeñdg{xKg66"; // Senha criptografada no primeiro algoritmo.
string descriptografia = Descriptografar(criptografia);
string cifraRevertida = ReverterCifraDeCesar(descriptografia);
string senha = Reverter(cifraRevertida);

Console.WriteLine("Senha criptografada: " + criptografia);
Console.WriteLine("Senha teste: " + senha); // retorna "01_Essa_é_Uma_Senha_Teste!"
```

## Funções

- **Reverter**: Inverte a string fornecida.
- **CifraDeCesar**: Aplica uma cifra de César (deslocamento de +3) aos caracteres da string.
- **Criptografar**: Aplica uma função personalizada para criptografar a string.
- **Descriptografar**: Reverte a função de criptografia personalizada.
- **ReverterCifraDeCesar**: Reverte a cifra de César (deslocamento de -3) aplicada aos caracteres da string.

## Como Usar

1. Defina `#define criptografar` para criptografar uma senha ou `#define descriptografar` para descriptografar uma senha.
2. Compile e execute o código.
3. Verifique a saída para ver a senha criptografada ou descriptografada.