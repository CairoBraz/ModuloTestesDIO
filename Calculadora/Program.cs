using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"A soma de {num1} e {num2} é {c.Somar(num1, num2)}");
