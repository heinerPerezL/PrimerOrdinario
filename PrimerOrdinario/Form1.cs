using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerOrdinario.clases;


namespace PrimerOrdinario
{
    public partial class Form1 : Form
    { // Variables globales
        int Fl, Cl, j, i;
        int[,] mtx = new int[100, 100];

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Inicio evento Click para programa de división
        private void btnLDV_Click(object sender, EventArgs e)
        {
            try {
                int dividendo = 0;
                int divisor = 0;
                String resultado = "";
                int validarDv;
                
                dividendo = Convert.ToInt32(nDividendo.Text);
                divisor = Convert.ToInt32(nDivisor.Text);
                validarDv = dividendo / divisor; // División para validar el try-catch

                Division division = new Division(divisor, dividendo);
                resultado = Convert.ToString(division.Resultado);
                nResultado.Text = resultado;
            }
            catch(DivideByZeroException)
            {   
                    MessageBox.Show(" No se puede dividir entre cero");
            }
            catch(Exception)
            {
                MessageBox.Show(" No se permiten espacios en blanco ni letras");
            }

        }


        private void btnSDV_Click(object sender, EventArgs e)// Evento que limpia los textbox
        {
            nDividendo.Text = "";
            nDivisor.Text = "";
            nResultado.Text = "";
        }


        private void btnSPro_Click(object sender, EventArgs e) // Evento Click cerrar
        {
            this.Dispose();
        }

        //fin del código operación división

        //Inicio de código de Matriz
        private void btnLimpiar_Click(object sender, EventArgs e) // Evento que limpia los
        {                                                         //objetos de Matriz
            nFilas.Text = "";
            nColumnas.Text = "";
            dgMtx.Rows.Clear();
        }
        
        private void btnImprimir_Click(object sender, EventArgs e)// Evento llenar y mostras matriz
        {
            asignar(nFilas, nColumnas);
            muestra(dgMtx);
        }

        public void asignar(TextBox nFilas, TextBox nColumnas) // método que llena la matriz
        { try {
                Fl = int.Parse(nFilas.Text);
                Cl = int.Parse(nColumnas.Text);
            }
            catch(Exception)
            {
                
            }

            for (i = 0; i < Fl; i++)
            {
                for (j = 0; j < Cl; j++)
                {
                    if (i == j)
                        mtx[i, j] = 1;
                    else
                        mtx[i, j] = 0;
                }
            }
        }

        public void muestra(DataGridView dgMtx)//método que asigna el valor de Columnas-Filas
        {
            try
            {
                dgMtx.ColumnCount = Cl;
                dgMtx.RowCount = Fl;
            }
            catch
            {
                if (Fl == 0 || Cl == 0)
                {
                    MessageBox.Show("Solo se permiten números enteros y además distintos de Cero");
                }

            }

            for (i = 0; i < Fl; i++)
            {
                for (j = 0; j < Cl; j++)
                {
                    dgMtx.Rows[i].Cells[j].Value = mtx[i, j].ToString();
                }
            }

        }

        }
    }

