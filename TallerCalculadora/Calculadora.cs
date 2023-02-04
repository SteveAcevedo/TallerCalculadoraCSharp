using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCalculadora
{
    internal class Calculadora
    {
         double numero1;
         double numero2;

        public double GetNumero1()
        {
            return numero1;
        }

        public void SetNumero2(double numero2)
        {
            this.numero2 = numero2;
        }
        public double GetNumero2()
        {
            return numero2;
        }

        public void SetNumero1(double numero1)
        {
            this.numero1 = numero1;
        }


        public Calculadora()
        {

        }

        public double sumar()
        {
            return numero1 + numero2;

        }
        public double restar()
        {
            return numero1 - numero2;

        }
        public double dividir()
        {
            return numero1 / numero2;

        }
        public double multiplicacion()
        {

            return numero1 * numero2;

        }

        public Boolean validar(double a, double b)
        {
            if(a==0 | b ==0)
            {
                return false;
            }

            return true;
        }
    }
}
