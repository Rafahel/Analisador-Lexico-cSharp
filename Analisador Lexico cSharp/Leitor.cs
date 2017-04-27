using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Analisador_Lexico_cSharp {
    class Leitor {
        private String caminho;
        private List<String> texto =  new List<string>();
        private System.IO.StreamReader file; 
        public List<String> LerArquivo(String caminho, String nome) {
            String conteudo;
            this.caminho = caminho;
            try {
                this.file = new System.IO.StreamReader(caminho + "/" + nome);
                while ((conteudo = this.file.ReadLine()) != null) {

                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    //Console.WriteLine(conteudo);
                    //Console.ResetColor();
                    texto.Add(conteudo);
                }
                this.file.Close();
                
            }
            catch (Exception) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO: ARQUIVO NÃO EXISTENTE");
                Console.ResetColor();
                
            }
            
            return this.texto;
        }

        public List<String> separador(List<String> texto) {
            List<String> novaLista = new List<string>();

            for (int i = 0; i < texto.Count; i++) {
                for (int j = 0; j < texto[i].Split().Length; j++) {
                    String temp = texto[i].Split()[j];
                    novaLista.Add(temp);
                    //Console.ForegroundColor = ConsoleColor.DarkGreen;
                    //Console.WriteLine(temp);
                    //Console.ResetColor();
                }
                
                
            }
         
            return novaLista;
        }

        public static bool arquivoExiste(String caminho, String nome) {
            try {
                System.IO.StreamReader file = new System.IO.StreamReader(caminho + "/" + nome);
                file.Close();
                return true;
            }
            catch (Exception) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Caminho ou arquivo inválido, tente novamente.");
                Console.ResetColor();
                return false;
            }

        }

    }
}
