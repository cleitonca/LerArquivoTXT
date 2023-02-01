
var caminho = new StreamReader(@"D:\Estudo de Desenvolvimento\CSharp\LerArquivoTXT\Arquivo.txt");

using (caminho)
{
    while (!caminho.EndOfStream)
    {
        var linhaCaminho = caminho.ReadLine();
        Console.WriteLine(linhaCaminho);
    }
}


