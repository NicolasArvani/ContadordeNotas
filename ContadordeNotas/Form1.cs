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
            atualizarNotas(this.Notas);
        }

        //atualizar o listview de notas disponiveis
        private void atualizarNotas(int[] Notas)
        {
            lvwTipoNota.Items.Clear();
            for(int i = 0; i < Notas.Count(); i++)
            {
                lvwTipoNota.Items.Add(Notas[i].ToString());
            }
            lvwNotas.Columns.Clear();
            lvwNotas.Columns.Add("Qtd Notas");
            for (int i = 0; i < Notas.Count(); i++)
            {
                lvwNotas.Columns.Add(Notas[i].ToString());
            }
            
        }


        int[] Notas = {100,50,30,20,10,5,2,1}; //vetor global de notas
        

        private void btnContarNotas_Click(object sender, EventArgs e)
        {
            lvwNotas.Items.Clear();
            int valor = int.Parse(txtInput.Text);
            ContarNotas(valor);
            txtOutput.AppendText("\r\n");
            txtOutput.AppendText("Quantidade de Possibilidades: " + lvwNotas.Items.Count.ToString() + "\r\n");
            if(lvwNotas.Items.Count > 0)
            {
                int menorQtd = int.MaxValue;
                int indiceMenor=0;
                for(int i = 0; i < lvwNotas.Items.Count; i++)
                {
                    if (int.Parse(lvwNotas.Items[i].SubItems[0].Text) < menorQtd)
                    {
                        menorQtd = int.Parse(lvwNotas.Items[i].SubItems[0].Text);
                        indiceMenor = i;
                    }
                }
                txtOutput.AppendText("Menor qtd de Notas: " + menorQtd.ToString() + ", Sendo: \r\n");
                for(int i = 1; i < Notas.Count()+1; i++)
                {
                    if (lvwNotas.Items[indiceMenor].SubItems[i].Text != "0")
                    {
                        txtOutput.AppendText(lvwNotas.Items[indiceMenor].SubItems[i].Text + " nota(s) de R$" + Notas[i - 1] + ", ");
                    }
                }
            
                txtOutput.AppendText("\r\n");
            }
            else
            {
                txtOutput.AppendText("Não há possibilidades de notas para o valor informado");
            }
            
            
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
                pilha.Add(Notas[i]); //adiciona uma nota (atual) na pilha
                if(pilha.Sum() < valor) //se o total for menor que o valor, chama outra funcao p/ adicionar uma nota nova
                {
                    ContadordeNotas(valor, pilha, i);
                    pilha.RemoveAt(pilha.Count() - 1);
                }
                else if(pilha.Sum() > valor) //se for maior o valor, remove a nota da pilha
                {
                    pilha.RemoveAt(pilha.Count() - 1);
                    
                }
                else if(pilha.Sum() == valor) //se for igual ao valor, entao eh uma solucao valida
                {
                    printPilha(pilha); //printa no textbox
                    pilha.RemoveAt(pilha.Count() - 1); //remove a nota da pilha
                    
                }
                i++; //vai para a proxima nota de menor valor
            } while (i < Notas.Count()); //faz o loop enquanto nao chegar na ultima nota
        }
        //metodo pra colocar o resultado encontrado no textbox
        private void printPilha(List<int> pilha) 
        {
            int[] somaNotas = new int[Notas.Count()];
            //loop para ver todas as notas presentes na pilha e somar as iguais
            for(int i = 0; i < pilha.Count(); i++)
            {
                //testa pra ver qual nota que eh
                for (int j = 0; j < Notas.Count(); j++)
                {
                    if (pilha[i] == Notas[j])
                        somaNotas[j] += 1;
                }
            }

            //printa as notas presentes
            for(int i = 0; i < Notas.Count(); i++)
            {
                if (somaNotas[i] != 0)
                {
                    txtOutput.AppendText(somaNotas[i] + " notas de R$ " + Notas[i] + ",  ");
                }

            }
            txtOutput.AppendText("\r\n");
            //adiciona no listview de resultado
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

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (lvwTipoNota.SelectedItems.Count > 0)
            {
                int index = lvwTipoNota.SelectedIndices[0];
                List<int> notas = Notas.ToList();
                notas.RemoveAt(index);
                Notas = notas.ToArray();
                atualizarNotas(Notas);
            }

        }

        private void btnAddNota_Click(object sender, EventArgs e)
        {
            int nota = int.Parse(txtAddNota.Text);
            List<int> notas = Notas.ToList();
            notas.Add(nota);
            Notas = notas.ToArray();
            Array.Sort(Notas);
            Array.Reverse(Notas);
            atualizarNotas(Notas);

        }

        private void resetarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas = new int[] { 100,50,30,20,10,5,2,1};
            atualizarNotas(Notas);
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
