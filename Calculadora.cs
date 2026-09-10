using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a operação (+, -, *, /):");
        string operacao = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;

            case "-":
                resultado = num1 - num2;
                break;

            case "*":
                resultado = num1 * num2;
                break;

            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: divisão por zero!");
                    return; // sai do Main() imediatamente
                }
                resultado = num1 / num2;
                break;

            default:
                Console.WriteLine("Operação inválida!");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
}