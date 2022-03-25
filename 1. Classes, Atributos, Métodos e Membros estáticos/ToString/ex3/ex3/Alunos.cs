using System;
using System.Globalization;

namespace ex3
{
    internal class Alunos
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;  
        double NotaFinal;
        string Situacao;
        public string CalcularNotaFinal()
        {
            NotaFinal = N1 + N2 + N3;
            if (NotaFinal > 60)
                Situacao = "Aprovado";
            else
                Situacao = "Reprovado \nFaltaram " + (60 - NotaFinal).ToString("F2", CultureInfo.InvariantCulture) + " pontos";

            return "Nota final = " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture) + "\n" + Situacao;
        }
    }
}
