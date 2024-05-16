using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            //var linha = leitor.ReadLine();
            //var texto = leitor.ReadToEnd();
            //var numero = leitor.Read();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                var msg = $"Titular da Conta: {contaCorrente.Titular.Nome}, Número da Conta: {contaCorrente.Numero}, Ag: {contaCorrente.Agencia}, Saldo: R${contaCorrente.Saldo}";
                Console.WriteLine(msg);
            }
        }
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(",");

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var nomeTitular = campos[3];
        var resultado = new ContaCorrente(agencia, numero);
        var titular = new Cliente();

        titular.Nome = nomeTitular;
        resultado.Depositar(saldo);
        resultado.Titular = titular;

        return resultado;
    }
}
