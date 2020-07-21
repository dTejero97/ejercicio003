using CLCalculos;
using System;

namespace Calculos
{
    public abstract class Calculadora : ICalculadora
    {
        public int devolverValor()
        {
            return 42;
        }

        public String devolverCadena(String cadena)
        {
            return cadena.Trim();
        }

        public int Casa()
        {
            return 0;
        }

        public int DevolverValor()
        {
            return 0;
        }
    }
}
