using System;
using System.Globalization;

namespace ex2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double X)
        {
            SalarioBruto += SalarioBruto*X/100;
        }
        public override string ToString()
        {
            return  Nome
                    + ", R$ "
                    + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
