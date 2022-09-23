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
    }
}