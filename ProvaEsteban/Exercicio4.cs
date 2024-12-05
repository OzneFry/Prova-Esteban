Console.WriteLine($"Exercício 4: Calculadora de dias entre datas");
Console.WriteLine("Digite uma data inicial no formato mes/dia/ano:");
DateTime data1 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Digite uma data final mes/dia/ano:");
DateTime data2 = DateTime.Parse(Console.ReadLine());
TimeSpan diferenca = data2 - data1;
int dias = Math.Abs(diferenca.Days);
Console.WriteLine("Diferença em dias: {0}", dias);
