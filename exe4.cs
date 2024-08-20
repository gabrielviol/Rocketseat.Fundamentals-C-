public class Exe4
{
    public static void MainMethod()
    {
		Console.Write("Por favor, digite uma ou mais palavras: ");

		string input = Console.ReadLine();

		string[] palavras = input.Split(' ');

		foreach(string palavra in palavras)
		{
			Console.Write($"A palavra '{palavra}' tem {palavra.Length} caracteres. \n");
		}
	}
}