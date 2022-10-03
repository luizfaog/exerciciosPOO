using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioGetSet

{
     public class Conta
    {
        public int NumDaConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; set; }

        public Conta(int numdaconta, string titular, double saldo)
        {
            NumDaConta = numdaconta;
            Titular = titular;
            Saldo = saldo;
        }

        
        public string GetDadosDaConta()
        {
            return ToString();
        }
        
        public double SetDeposito(double valor) {
            Saldo += valor;
            return Saldo;
        }

        public double SetSaque(double valor)
        {
            Saldo -= valor;
            return Saldo;
        }
        public override string ToString()
        {
            return "conta " + NumDaConta + " titular "+  Titular + " saldo atual " + Saldo;
        }
    }
}
