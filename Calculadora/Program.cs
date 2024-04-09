Console.WriteLine("================================================");
Console.WriteLine("||   Bem-Vindo(a) à minha Calculadora em C#   ||");
Console.WriteLine("================================================");
Console.WriteLine($"||           por GUSTAVO NAPPI (2024)         ||");
Console.WriteLine("================================================");

double num1 = 0;
double num2 = 0;
double resultado = 0;

Console.Write("Insira o número 1: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o número 2: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha uma opção: ");
Console.WriteLine("\t+ : Soma");
Console.WriteLine("\t- : Subtração");
Console.WriteLine("\t* : Multiplicação");
Console.WriteLine("\t/ : Divisão");

switch (Console.ReadLine())
{
    case "+":
        resultado = num1 + num2;
        Console.WriteLine("O resultado da operação será de: " + resultado);
        break;

    case "-":
        resultado = num1 - num2;
        Console.WriteLine("O resultado da operação será de: " + resultado);
        break;
    case "*":
        resultado = num1 * num2;
        Console.WriteLine("O resultado da operação será de: " + resultado);
        break;
    case "/":
        resultado = num1 / num2; // Divisão corrigida aqui
        Console.WriteLine("O resultado da operação será de: " + resultado);
        break;
}

Console.WriteLine("OBRIGADO POR TESTAR!");

Console.ReadKey();
