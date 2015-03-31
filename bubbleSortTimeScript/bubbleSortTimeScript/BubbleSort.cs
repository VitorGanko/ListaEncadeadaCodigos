using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSortScript
{
    class BubbleSort
    {
        public void Sortear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                { 
                    if(array[i] > array[j])
                    {
                        int temporario = array[i];
                        array[i] = array[j];
                        array[j] = temporario;
                    }
                }
            }
        }


        public void Sortear(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        double temporario = array[i];
                        array[i] = array[j];
                        array[j] = temporario;
                    }
                }
            }
        }


    }
}
