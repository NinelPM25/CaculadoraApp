using System;
using System.Collections.Generic;
using System.Text;

namespace CaculadoraApp.Clases
{
    internal class Ordenamiento
    {
        int [] arreglo;
        public int[] Burbuja(int[] arreglo)
        {
            try
            {
                this.arreglo = arreglo;
                int aux;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    for (int j = 0; j < arreglo.Length; j++)
                    {
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            aux = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = aux;
                        }
                    }
                }
                return arreglo;
            }
            catch (Exception Ex)
            {
                return null;
                throw;
                

            }
        }
    }
}
