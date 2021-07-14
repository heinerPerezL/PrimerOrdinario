using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerOrdinario.clases
{ 
    
    class Division
    {
        private int divisor; 
        private int dividendo;
        private double resultado;
        
       
        public Division(int divisor, int dividendo)
        {
            this.divisor = divisor;
            this.dividendo = dividendo;
            this.Resultado = 0;
            Operacion(divisor, dividendo);
        }

        public int Dividendo { get => dividendo; set => dividendo = value; }
        public int Divisor { get => divisor; set => divisor = value; }
        public double Resultado { get => resultado; set => resultado = value; }


        //Método privado que realiza la división
        private void Operacion(int pDivisor, int pDividendo)
        {
         
            this.resultado =  pDivisor/ pDividendo;
           
        }

        


    }
}
