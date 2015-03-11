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
            this.sizeOfArray = int.Parse(textBox1.Text);
            this.lista = new int[this.sizeOfArray];
            this.sorteio();
            listaValues.Items.Clear();
            for (int i = 0; i < lista.Length; i++)
            {
                listaValues.Items.Add(lista[i]);
            }
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

            //printa no console a lista em ordem
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
