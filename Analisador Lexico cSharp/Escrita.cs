using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Resolver problema relacionado a saída do arquivo.
/// C:\Users\Rafahel\Desktop
/// entrada.txt
/// </summary>


namespace Analisador_Lexico_cSharp {
    class Escrita {
        /// <summary>
        ///  Continuar a implementação da classe de escrita.
        /// </summary>
        /// <param name="caminho"></param>
        /// <param name="nome"></param>
        public static void escreverUltimoSimbolo(String caminho, String nome,List<int> saidas, String entrada) {
            try {
                
                System.IO.StreamWriter file = new System.IO.StreamWriter(caminho + "/" + "RESULTADO_" + nome, append: true);
                file.Write(entrada + " -> ");
                for (int i = 0; i < saidas.Count; i++) {
                    if (saidas[i] <= 0) {
                        continue;
                    }
                    file.Write(saidas[i] + " ");
                }
                file.Write("\n");
                file.Close();
            }
            catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO: NÃO FOI POSSÍVEL ESCREVER PARA O ARQUIVO: " + caminho + "/" + "RESULTADO_" + nome);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(e.ToString());
                //Console.WriteLine(ERRO.ToString());
                Console.ResetColor();
            }
        }
        public static void limpaArquivo(String caminho, String nome) {
            try {
                System.IO.StreamWriter file = new System.IO.StreamWriter(caminho + "/" + "RESULTADO_" + nome, append: false);
                file.Write("");
                file.Close();
            }
            catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERRO: NÃO FOI POSSÍVEL ESCREVER PARA O ARQUIVO: " + caminho + "/" + "RESULTADO_" + nome);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(e.ToString());
                //Console.WriteLine(ERRO.ToString());
                Console.ResetColor();
            }
        }

        

    }
}
