using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //UsarStreamDeEntrada();

        /*
        var linhas = File.ReadAllLines("contas.txt");
        Console.WriteLine(linhas.Length);


        foreach (var linha in linhas) 
        {
            Console.WriteLine(linha);
        }
        */

        /*
        var bytesArquivos = File.ReadAllBytes("contas.txt");
        Console.WriteLine($"Arquivo contas.txt possui {bytesArquivos.Length} bytes");
        */

        File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

        Console.WriteLine("Aplicação finalizada ...");
        Console.ReadLine();
    }

}