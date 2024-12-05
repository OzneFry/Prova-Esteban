Console.WriteLine("Digite a idade da pessoa em dias:");
int idadeEmDias = int.Parse(Console.ReadLine());
int anos = idadeEmDias / 365;
int meses = (idadeEmDias % 365) / 30;
int dias = (idadeEmDias % 365) % 30;
Console.WriteLine("{0} anos", anos);
Console.WriteLine("{0} meses", meses);
Console.WriteLine("{0} dias", dias);
