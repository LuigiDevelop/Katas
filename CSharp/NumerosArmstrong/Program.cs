using System;
using System.Linq;

namespace NumerosArmstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDesde, iHasta;



            Console.Write("Inserte número inicial: ");
            if (!int.TryParse(Console.ReadLine(), out iDesde))
            {
                Console.WriteLine("No se ha insertado un número entero. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }

            Console.Write("Inserte número final: ");
            if (!int.TryParse(Console.ReadLine(), out iHasta))
            {
                Console.WriteLine("No se ha insertado un número entero. Pulse una tecla para salir.");
                Console.ReadKey();
                return;
            }

            Armstrong armstrong = new Armstrong(iDesde, iHasta);

            armstrong.muestraNumerosArmstrong();
            Console.ReadKey();
        }
    }

    class Armstrong
    {
        private int iInicio;
        private int iFinal;
        private int cantidad;



        public Armstrong(int iDesde, int iHasta)
        {
            iInicio = iDesde;
            iFinal = iHasta;
            this.cantidad = 0;

        }

        public void muestraNumerosArmstrong()
        {
            for (int i = iInicio; i <= iFinal; i++)
            {
                if (EsAarmstrong(i))
                {
                    Console.WriteLine(i + " es un número Armstrong");
                    cantidad++;
                }
            }

            Console.WriteLine("Cantidad de números Armstrong entre " + iInicio + " y " + iFinal + ": " + cantidad);
        }

        private bool EsAarmstrong(int numero)
        {          
            double resultado = 0;

            foreach (var element in numero.ToString())
            {
                resultado += Math.Pow(double.Parse(element.ToString()), numero.ToString().Length);
            }

            return (resultado == numero);
        }        
    }
}