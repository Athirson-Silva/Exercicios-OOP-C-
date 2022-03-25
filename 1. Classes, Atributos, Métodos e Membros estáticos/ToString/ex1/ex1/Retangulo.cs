using System;
using System.Globalization;

namespace ex1
{
    internal class Retangulo
    {
        public double Base;
        public double Altura;

        public double Area()
        {
            return Base * Altura;
        }

        public double Perimetro()
        {
            return (Base + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Base * Base + Altura * Altura);
        }

        public override string ToString()
        {
            return    "Area = "
                    + Area().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nPERÍMETRO = "
                    + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nDiagonal = "
                    + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
