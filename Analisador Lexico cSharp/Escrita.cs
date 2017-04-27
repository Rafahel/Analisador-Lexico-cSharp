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
        public static void escreverUltimoSimbolo(String caminho, String nome, int saida, String entrada) {
            try {
                
                System.IO.StreamWriter file = new System.IO.StreamWriter(caminho + "/" + "Analise_lexica.txt", append: true);
                if (saida < 176 || saida > 0) {
                    file.Write(saida + " ");
                }
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
                System.IO.StreamWriter file = new System.IO.StreamWriter(caminho + "/" + "Analise_lexica.txt", append: false);
                file.Write("");
                file.Close();
                System.IO.StreamWriter fileB = new System.IO.StreamWriter(caminho + "/" + "reconhecimento_lexico.txt", append: false);
                fileB.Write("");
                fileB.Close();
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

        public static void escreveAnaliseLexica(String caminho, String nome, String entrada, List<int> valores) {
            System.IO.StreamWriter file = new System.IO.StreamWriter(caminho + "/" + "reconhecimento_lexico.txt", append: true);

            string[] estados = { "literal_numerico", "literal_numerico", "literal_numerico", "literal_numerico", "", "literal_numerico",
                                    "literal_numerico", "literal_numerico", "outros_tokens", "negacao", "atribuicao", "op_relacional","op_relacional", "agrupador",
                                    "op_arit_p4", "op_arit_p3", "op_arit_p2", "op_arit_p1", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "op_logico", "identificador", "op_logico", "identificador",
                                    "identificador", "op_logico", "identificador", "identificador", "identificador", "op_logico", "identificador", "identificador",
                                    "identificador", "identificador", "inicio_bloco", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "estr_cond_aninhada", "identificador", "identificador",
                                    "tipo_dado", "identificador", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "controle_fluxo", "manip_arquivo", "identificador", "repeticao_controle", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "desvio_cond", "identificador", "desvio_cond",
                                    "identificador", "fim_bloco", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "desvio_cond", "identificador", "identificador", "identificador", "entrada",
                                    "tipo_dado", "identificador", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "func_mat", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "identificador", "saida", "identificador",
                                    "repeticao_controle", "identificador", "identificador", "identificador", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "func_mat", "identificador", "identificador", "identificador",
                                    "identificador", "identificador", "repeticao_controle", "identificador", "identificador", "identificador", "tipo_dado", "identificador",
                                    "identificador", "identificador", "identificador", "identificador", "estr_cond_aninhada", "identificador", "repeticao_controle",
                                    "identificador", "identificador", "outros_tokens", "identificador", "identificador", "identificador", "outros_tokens",
                                    "identificador", "identificador", "outros_tokens", "identificador", "identificador", "identificador", "identificador",
                                    "repeticao_test_ini", "func_mat", "controle_fluxo", "bool", "identificador", "identificador", "controle_fluxo",
                                    "manip_arquivo", "bool", "identificador"};

            String mostra;
            String estado;
            file.Write(entrada + ": ");
            for (int i = 0; i < valores.Count; ++i) {
                mostra = entrada;
                estado = "";

                if (valores[i] != -1) {
                    estado += valores[i].ToString();
                }

                if (i < (valores.Count - 1)) {
                    mostra = mostra.Insert(i, estado);
                }
                else {
                    mostra += estado;
                }

                file.Write(mostra);

                if (valores[i] == 888) {
                    file.Write("; Erro Simbolo nao Existente");
                    break;
                }
                else if (valores[i] == 999) {
                    file.Write("; Erro de Transicao");
                    break;
                }
                if(valores[i] == valores.Last()) {
                    file.Write("; ->");
                    if (valores.Last() < 177 || valores.Last() > 0) {
                        //Console.WriteLine("TESTE -> " + valores.Last());
                        file.Write(estados[valores.Last() - 1]);
                        

                    }
                }

                if (i != (valores.Count - 1)) {
                    file.Write(", ");
                }
            }
            
            file.WriteLine("");
            file.Close();
        }
        

    }
}
