public class Exe2
{
    public static void MainMethod()
    {
        Console.Write("Por favor, digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Agora, digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome} {sobrenome}! Seja muito bem-vindo!");
    }
}
