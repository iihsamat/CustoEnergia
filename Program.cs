//Stefeson

double consumo, horasUsoDia;
decimal custo, estimativaMes;

Console.WriteLine("Custo de Energia");

Console.Write("Consumo  de aparelho (em kWh/mês):");
consumo = Convert.ToDouble(Console.ReadLine());

Console.Write("Horas de uso por dia:");
horasUsoDia = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo da energia (em R$/kWh):");
custo = Convert.ToDecimal(Console.ReadLine());

estimativaMes = Convert.ToDecimal(consumo * horasUsoDia) * custo;

Console.WriteLine($"Custo estimado: {estimativaMes:C}");