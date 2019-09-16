using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double num)
        {
            this.numero = num;

        }
        public Numero(string num)
        {
            if (double.TryParse(num, out double nume))
            {
                this.numero = nume;
            }
        }


        public double ValidarNumero(string strNumero)
        {
            if (double.TryParse(strNumero, out double num))
            {
                return num;
            }
            else
            {
                return 0;
            }

        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        public  string DecimalBinario(double num)
        {
            string bin;
            bin = Convert.ToString(Convert.ToByte(num), 2);


            return bin;
        }

        public  string DecimalBinario(string num)
        {
            string bin;
            if (double.TryParse(num, out double dec))
            {
                return bin = DecimalBinario(dec);
            }
            else
            {
                return "error";
            }


        }

        public  string BinarioDecimal(string bin)
        {
            double num;
            string numero;//*/
            num = Convert.ToInt64(bin, 2);
            numero = Convert.ToString(num);
            if(double.TryParse(numero,out double numeros))
            {
                return numero = Convert.ToString(numeros);
            }
            else
            {
                return "error";
            }

        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }


    }
}