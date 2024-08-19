public class Exe3
{
    public static void MainMethod()
    {
        double num1 = 12.5;
        double num2 = 4.3;

        double soma = num1 + num2;
        Console.WriteLine($"Soma: {num1} + {num2} = {soma}");

        double subtracao = num1 - num2;
        Console.WriteLine($"Subtração: {num1} - {num2} = {subtracao}");

        double multiplicacao = num1 * num2;
        Console.WriteLine($"Multiplicação: {num1} * {num2} = {multiplicacao}");

        if (num2 != 0)
        {
            double divisao = num1 / num2;
            Console.WriteLine($"Divisão: {num1} / {num2} = {divisao}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida!");
        }

        double media = (num1 + num2) / 2;
        Console.WriteLine($"Média: ({num1} + {num2}) / 2 = {media}");

    }
}
