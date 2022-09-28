using Arquivos.Helper;

var caminho = "C:\\Users\\Isaias\\Documents\\Csharp\\Arquivos";
var caminho_arquivo = Path.Combine(caminho,"Pasta 3","arquivo_teste.txt");
var caminho_arquivo2 = Path.Combine(caminho,"Pasta 3","arquivo_teste2.txt");
var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
var listaString2 = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

FileHelper helper = new FileHelper();
helper.ListarDiretorios(caminho);
System.Console.WriteLine("\n\n\n");
helper.ListarArquivosDiretorios(caminho);
System.Console.WriteLine("\n\n\n");
helper.ListarArquivosDiretorios(caminho,"*.txt");
System.Console.WriteLine("\n\n\n");
System.Console.WriteLine("Criando o diretorio: ");
helper.CriarDiretorio(Path.Combine(caminho,"Pasta 3", "SubPasta 2"));
helper.ApagarDiretorio(Path.Combine(caminho, "Pasta 1","SubPasta 1"),true);
helper.CriarArquivoTxt(caminho_arquivo, "Teste de escrita de arquivo");
helper.CriarArquivoTxtStream(caminho_arquivo2,listaString);
helper.AppendTexto(caminho_arquivo,"\nContinuacao do conteudo...\n Ate mais.");
helper.AppendTextoStream(caminho_arquivo2, listaString2);
helper.LerImprimirArquivo(caminho_arquivo);
helper.LerImprimirArquivoStream(caminho_arquivo2);
helper.MoverArquivo(caminho_arquivo, Path.Combine(caminho,"Pasta 2","arquivo_novo_nome.txt"));
helper.CopiarArquivo(Path.Combine(caminho,"Pasta 2","arquivo_novo_nome.txt"),Path.Combine(caminho,"Pasta 3","arquivo_teste.txt"),false);
helper.DeletarArquivo(Path.Combine(caminho,"Pasta 2","arquivo_novo_nome.txt"));

