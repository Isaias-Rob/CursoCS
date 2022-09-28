using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Arquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho){
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);

            foreach(var caminhoP in retornoCaminho){
                System.Console.WriteLine(caminhoP);
            }
        }

        public void ListarArquivosDiretorios(string caminho){
            var retornoArquivos = Directory.GetFiles(caminho,"*",SearchOption.AllDirectories);

            foreach(var arquivo in retornoArquivos){
                System.Console.WriteLine(arquivo);
            }
        }
        public void ListarArquivosDiretorios(string caminho, string opt){
            var retornoArquivos = Directory.GetFiles(caminho,opt,SearchOption.AllDirectories);

            foreach(var arquivo in retornoArquivos){
                System.Console.WriteLine(arquivo);
            }
        }

        public void CriarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
            System.Console.WriteLine("Criado!");
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos){
            Directory.Delete(caminho,apagarArquivos); //Causara erros se o diretorio conter arquivos e o bool estiver como false

        }

        public void CriarArquivoTxt(string caminho, string conteudo){
            if(File.Exists(caminho)){
                File.WriteAllText(caminho,conteudo);
            }
        }

        public void CriarArquivoTxtStream(string caminho, List<string> conteudo){
            using(var stream = File.CreateText(caminho)){ //limpar a stream e liberar o arquivo por isso o using
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

        public void AppendTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo); //se não existir ele cria o arquivo.
        }

        public void AppendTextoStream(string caminho, List<string> conteudo){
            using(var stream = File.AppendText(caminho)){ 
                foreach(var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerImprimirArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo){
                System.Console.WriteLine(linha);
            }
        }

        public void LerImprimirArquivoStream(string caminho){
            string linha = string.Empty;
            using(var stream = File.OpenText(caminho)){
                while((linha = stream.ReadLine()) != null){
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string source, string destination, bool sobrescrever){
            File.Move(source, destination, sobrescrever);//por padrao nao sobrescreve arquivos com o mesmo nome
        }

        public void CopiarArquivo(string source, string destination, bool sobrescrever){
            File.Copy(source, destination, sobrescrever); //por padrao nao sobrescreve arquivos com o mesmo nome
        }

        public void DeletarArquivo(string caminho){
            File.Delete(caminho);
        }
    }
}