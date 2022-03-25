using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Conta
    {
        private double _taxa = 5.0;
        private int _cont = 0;
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public char OpcaoDeposito { get; private set; }
        public double ValorDepositado { get; private set; } //é privado pois só pode ser mudado através dos métodos da classe
        public double ValorSaque { get;private  set; }

        public Conta() { }
        public Conta(int numeroConta, string nomeTitular, char opcaoDeposito)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            OpcaoDeposito = opcaoDeposito;
        }   
        public Conta(int numeroConta, string nomeTitular, char opcaoDeposito, double valorDepositado) : this(numeroConta, nomeTitular, opcaoDeposito)  //exemplo de sobrecarga
        {
            ValorDepositado = valorDepositado; //Caso a função deposito fosse apenas somar quantia, poderia se reescrever essa linha como "Depositar(valorDepositado);"
        }
        
        public void LeiturDeDados()
        {
            Console.Write("Entre com o número da conta: ");
            NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            this.NomeTitular = Console.ReadLine();  //this só para exemplo, não necessário
            Console.Write("Haverá depósito inicial (s/n)? ");
            OpcaoDeposito = char.Parse(Console.ReadLine());
            if (OpcaoDeposito == 's'  || OpcaoDeposito =='S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                ValorDepositado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //poderiamos iniciar a conta com conta = new Conta (NumeroConta, NomeTitular, OpcaoDeposito, Valor depositado) se estivessemos no programa principal
        }

        public void Depositar()
        {
            Console.WriteLine("Entre um valor para depósito: ");  
            ValorDepositado += double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public void Sacar()
        {
            Console.WriteLine("Entre um valor para saque: ");
            ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorDepositado -= ValorSaque + _taxa;
        }

        public override string ToString()
        {
            string dados = "Dados da conta: ";
            if (_cont == 1)
                dados = "Dados atualizados";
            _cont++;
            return "\n" + dados +
                    "\nConta " + NumeroConta +
                    ", Titular: " + NomeTitular +
                    ", Saldo: $" + ValorDepositado.ToString("F2", CultureInfo.InvariantCulture) +
                    "\n";
            
        }
    }
}
