using Arquivos.Helper;

var caminho = "C:\\Users\\Isaias\\Documents\\Csharp\\Arquivos";

FileHelper helper = new FileHelper();
helper.ListarDiretorios(caminho);
System.Console.WriteLine("\n\n\n");
helper.ListarArquivosDiretorios(caminho);
System.Console.WriteLine("\n\n\n");
helper.ListarArquivosDiretorios(caminho,"*.txt");
System.Console.WriteLine("\n\n\n");
System.Console.WriteLine("Criando o diretorio: ");
helper.CriarDiretorio(Path.Combine(caminho,"Pasta 3", "SubPasta 2"));