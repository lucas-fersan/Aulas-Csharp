using System;


namespace Consoleaula1
{
    internal class conta_corrente
    {
        public string titular;
        public int Numero;
        public double Saldo;

        public conta_corrente(string Titular, int numero, double saldo)
        {
            titular = Titular;
            Numero = numero;
            Saldo = saldo;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor;
        }
        public void Transferencia(double valor, conta_corrente conta)
        {
            Saldo -= valor;
            conta.Saldo += valor;
        }
        public string GetdetailAccount()
        {
            return $"Nome: {titular} , Numero: {Numero} , Saldo: {Saldo}  ";
        }
    }
}
