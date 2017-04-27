using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisador_Lexico_cSharp {
    public partial class UI : Form {
        private String nomeArquivo;
        private String caminho;

        
        public UI() {
            InitializeComponent();
            richTextBox1.Text = "Selecione um arquivo com a linguagem válida, logo após o termino do programa será gerado os arquivos de analise_lexica e.txt reconhecimento_lexico.txt";
            richTextBox1.ReadOnly = true;
        }
        public String getNome() {
            return this.nomeArquivo;
        }
        public String getCaminho() {
            return this.caminho;
        }
        private void button1_Click(object sender, EventArgs e) {
            OpenFileDialog filebrowser = new OpenFileDialog();
            filebrowser.Filter = "|*txt";
            if (filebrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                System.IO.FileInfo fInfo = new System.IO.FileInfo(filebrowser.FileName);
                this.nomeArquivo = fInfo.Name;
                this.caminho = fInfo.DirectoryName + "\\";
                this.Close();
            }
        }


        
    }
}
