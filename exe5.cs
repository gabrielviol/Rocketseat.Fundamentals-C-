public class Exe5
{
    public static void MainMethod()
    {
        Console.Write("Digite a placa do veículo: ");

        string placa = Console.ReadLine();

        if (placa.Length == 7)
        {
            char[] caracteresPlaca = placa.ToCharArray();

            for(int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(caracteresPlaca[i]))
                {
                    Console.Write("Placa invalida!");
                    return;
                }
            }
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(caracteresPlaca[i]))
                {
                    Console.Write("Placa invalida!");
                    return;
                }
            }
            Console.WriteLine($"Placa valida {placa}");
            return;

        }
        Console.Write("Placa invalida!");
        return;

    }
}
