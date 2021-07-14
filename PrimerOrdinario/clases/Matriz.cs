using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PrimerOrdinario.clases
{
    class Matriz
    {
        private int Filas;
        private int Columnas;
        private int i, j;
        int[,] mtx = new int[100, 100];

        public Matriz() { }
        public Matriz(int filas, int columnas, int i, int j, int[,] mtx)
        {
            Filas1 = filas;
            Columnas1 = columnas;
            this.I = i;
            this.J = j;
            this.Mtx = mtx;
        }

        // inicializa Getters y Setters
        public int Filas1 { get => Filas; set => Filas = value; }
        public int Columnas1 { get => Columnas; set => Columnas = value; }
        public int I { get => i; set => i = value; }
        public int J { get => j; set => j = value; }
        public int[,] Mtx { get => mtx; set => mtx = value; }
    }

     
}
