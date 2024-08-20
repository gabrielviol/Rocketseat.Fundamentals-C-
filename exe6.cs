public class Exe6
{
    public static void MainMethod()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha um formato para exibir a data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        Console.Write("Digite a opção desejada (1-4): ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Data completa: {dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss")}");
                break;

            case "2":
                Console.WriteLine($"Data: {dataAtual.ToString("dd/MM/yyyy")}");
                break;

            case "3":
                Console.WriteLine($"Hora: {dataAtual.ToString("HH:mm:ss")}");
                break;

            case "4":
                Console.WriteLine($"Data: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy")}");
                break;

            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma opção de 1 a 4.");
                break;
        }

    }

}