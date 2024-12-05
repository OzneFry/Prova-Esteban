Console.WriteLine($"Exercicio 2: Contar palavras em uma string");
string texto = Console.ReadLine();
int numeroDePalavras = texto.Split(new char[] { ' ', '.', '\n', '\t' },
    StringSplitOptions.RemoveEmptyEntries).Length;
Console.WriteLine("Número de palavras: {0}", numeroDePalavras);
