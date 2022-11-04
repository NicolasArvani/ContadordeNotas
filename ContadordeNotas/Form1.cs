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
        }


        int[] Notas = {100,50,20,10,5,2,1}; //vetor global de notas

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
    }
}
