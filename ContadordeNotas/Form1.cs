using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadordeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int[] Notas = {100,50,20,10,5,2,1};

        private void btnContarNotas_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtInput.Text);
            ContarNotas(valor);
            txtOutput.AppendText("\r\n");
        }

        private void ContarNotas(int valor)
        {
            List<int> pilha = new List<int>();
            ContadordeNotas(valor, pilha, 0);
        }
        private void ContadordeNotas(int valor, List<int> pilha, int i)
        {
            do
            {
                pilha.Add(Notas[i]);
                if(pilha.Sum() < valor)
                {
                    ContadordeNotas(valor, pilha, i);
                    pilha.RemoveAt(pilha.Count() - 1);
                }
                else if(pilha.Sum() > valor)
                {
                    pilha.RemoveAt(pilha.Count() - 1);
                    
                }
                else if(pilha.Sum() == valor)
                {
                    printPilha(pilha);
                    pilha.RemoveAt(pilha.Count() - 1);
                    
                }
                i++;
            } while (i < Notas.Count());
        }
        private void printPilha(List<int> pilha)
        {
            int[] somaNotas = new int[Notas.Count()];
            for(int i = 0; i < pilha.Count(); i++)
            {
                for (int j = 0; j < Notas.Count(); j++)
                {
                    if (pilha[i] == Notas[j])
                        somaNotas[j] += 1;
                }
            }

            
            for(int i = 0; i < Notas.Count(); i++)
            {
                if (somaNotas[i] != 0)
                {
                    txtOutput.AppendText(somaNotas[i] + " notas de R$ " + Notas[i] + ",  ");
                }

            }
            txtOutput.AppendText("\r\n");
            lvwNotas.Items.Add(somaNotas.Sum().ToString());
            for(int j = 0; j < Notas.Count(); j++)
            {
                lvwNotas.Items[lvwNotas.Items.Count - 1].SubItems.Add(somaNotas[j].ToString());
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            lvwNotas.Items.Clear();
        }
    }
}
