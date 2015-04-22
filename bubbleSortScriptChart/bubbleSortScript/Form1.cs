using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace bubbleSortScript
{
    public partial class Form1 : Form 
    {        
        int sizeOfArray, currentCicle, elementsPerCicle, maxToRandom;
        int[] lista, lista2;
        Random r = new Random();
        BubbleSort b = new BubbleSort();
        KeyEventArgs k;
        double[] processTimerArray;
        string[] lt = new string[] { "Pontos", "Colunas", "Area", "Bar" };

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < lt.Length; i++)
                this.listTabelas.Items.Add(lt[i]);

            resizer();

            timer1.Tick += new EventHandler(ChartType);
            timer1.Start();
            
        }

        //botão que inicia tudo
        private void buttonInit_Click(object sender, EventArgs e)
        {
            this.currentCicle = 0;

            if (textBox3.Text.Equals("")) this.maxToRandom = 100;
            else { this.maxToRandom = int.Parse(textBox3.Text); }

            if (textBox2.Text.Equals("")) this.elementsPerCicle = 5;
            else { this.elementsPerCicle = int.Parse(textBox2.Text); }

            if (textBox1.Text.Equals("")) this.sizeOfArray = 5;
            else { this.sizeOfArray = int.Parse(textBox1.Text); }

            listaValues.Items.Clear();
            this.sorteio();
        }

        //sorteio dos valores da lista
        private void sorteio()
        {

            List<int> l = new List<int>();
            List<double> t = new List<double>();

             while(this.currentCicle++ < this.sizeOfArray)
             {
                 int listaSize = (this.elementsPerCicle * this.currentCicle);

                 this.lista = new int[listaSize];

                 this.listaValues.Items.Add("fazendo bubbleSort de " + listaSize + "...");

                 l.Add(listaSize);

                 Stopwatch timer = new Stopwatch();

                 timer.Start();

                 for (int i = 0; i < lista.Length; i++)
                 {
                     this.lista[i] = r.Next(this.maxToRandom);
                 }

                 b.Sortear(lista);

                 t.Add(timer.Elapsed.TotalMilliseconds);

                 Console.WriteLine(timer.Elapsed.TotalMilliseconds);
             }

            this.lista2 = l.ToArray();
            this.processTimerArray = t.ToArray();

            for (int i = 0; i < this.lista2.Length; i++)
                this.grafico.Series["BubbleSort/Milliseconds"].Points.AddXY(lista2[i], processTimerArray[i]);

        }       

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.buttonInit.Location = new Point(this.buttonInit.Location.X, this.Height / 2 + this.Height / 3);

            resizer();

            if (WindowState == FormWindowState.Maximized)
            {
                this.grafico.Width = this.Width / 2 + (this.Width / 3 - 70);
                this.grafico.Height = this.Height / 2 + (this.Height / 3 - 70);

                this.listaValues.Height = this.grafico.Height;

                this.buttonInit.Location = new Point(this.buttonInit.Location.X, this.Height - 80);
                this.buttonInit.Width = (this.Width / 2) + (this.Width / 8);

                this.listTabelas.Location = new Point((this.Width / 2) + (this.Width / 5), this.buttonInit.Location.Y);

             }

            else if (WindowState == FormWindowState.Normal)
            {
                this.resizer();
            }
        }


        private void ChartType(object sender, EventArgs e)
        {
            if (this.listTabelas.SelectedItem == null) this.grafico.Series["BubbleSort/Milliseconds"].ChartType = SeriesChartType.Column;
            else if (this.listTabelas.SelectedItem.Equals("Pontos")) this.grafico.Series["BubbleSort/Milliseconds"].ChartType = SeriesChartType.Point;
            else if (this.listTabelas.SelectedItem.Equals("Colunas")) this.grafico.Series["BubbleSort/Milliseconds"].ChartType = SeriesChartType.Column;
            else if (this.listTabelas.SelectedItem.Equals("Area")) this.grafico.Series["BubbleSort/Milliseconds"].ChartType = SeriesChartType.Area;
            else if (this.listTabelas.SelectedItem.Equals("Bar")) this.grafico.Series["BubbleSort/Milliseconds"].ChartType = SeriesChartType.Bar;
        }

        private void resizer()
        {
                this.grafico.Width = (this.Width / 2) + (this.Width / 6);
                this.grafico.Height = this.Height / 2;

                this.listaValues.Height = this.grafico.Height;

                this.buttonInit.Location = new Point(this.buttonInit.Location.X, this.Height / 2 + this.Height / 4);

                this.listTabelas.Location = new Point((this.Width / 2) + (this.Width / 5), this.buttonInit.Location.Y);

                this.buttonInit.Width = (this.Width / 2);
        }



    }

}
