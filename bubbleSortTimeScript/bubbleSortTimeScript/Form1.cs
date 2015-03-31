using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubbleSortScript
{
    public partial class Form1 : Form
    {
        int sizeOfArray;
        int[] lista;
        List<int> listaElementosBubbleSort = new List<int>();
        List<double> listaTempo = new List<double>();
        Random r = new Random();
        BubbleSort b = new BubbleSort();
        KeyEventArgs k;

        public Form1()
        {
            InitializeComponent();
        }

        //botão que inicia tudo
        private void buttonInit_Click(object sender, EventArgs e)
        {
            DateTime time1 = DateTime.Now;

            this.sizeOfArray = int.Parse(textBox1.Text);
            this.lista = new int[this.sizeOfArray];
            this.listaElementosBubbleSort.Add(int.Parse(textBox1.Text));
            this.sorteio();
            listaValues.Items.Clear();

            for (int i = 0; i < lista.Length; i++)
            {
                listaValues.Items.Add(lista[i]);
            }

            DateTime time2 = DateTime.Now;

            TimeSpan time3 = time2.Subtract(time1);

            double timer = time3.TotalSeconds;

            tempoBubbleSort.Items.Add("tempo para processar bubbleSort de " + this.sizeOfArray + " elementos foi de: " + timer);

            listaTempo.Add(timer);
        }

        //sorteio dos valores da lista
        private void sorteio()
        {            
            //random dos valores da lista
            for (int i = 0; i < lista.Length; i++)
            {
                this.lista[i] = r.Next(100);
            }

            //BubbleSort
            b.Sortear(lista);
        }

        //Botão de ordenar tempo
        private void ordenarTempo_Click(object sender, EventArgs e)
        {
            tempoBubbleSort.Items.Clear();

            double[] timeOrder = listaTempo.ToArray();
            int[] sizeElementsOrder = listaElementosBubbleSort.ToArray();

            b.Sortear(timeOrder);
            b.Sortear(sizeElementsOrder);

            for (int i = 0; i < timeOrder.Length; i++)
            {
                tempoBubbleSort.Items.Add("tempo para processar bubbleSort de " + sizeElementsOrder[i] + " elementos foi de: " + timeOrder[i]);
            }
        }

        //Botão para zerar os BubbleSorts feitos até agora
        private void zerarTudo_Click(object sender, EventArgs e)
        {
            listaValues.Items.Clear();
            tempoBubbleSort.Items.Clear();
            listaTempo.Clear();
            listaElementosBubbleSort.Clear();

            textBox1.Text = "";
        }


    }
}
