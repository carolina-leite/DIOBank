using System;

namespace DIO.Bank
{
    public class Conta
    {

        private TipoConta { get; set; }


    public Conta(double saldo, double credito, string nome)
    {
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;

    }
    private double Saldo { get; set; }

    private double Credito { get; set; }

    public string Nome { get; set; }

    public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;

    }

    public bool Sacar(double valorSaque)
    {
        //Validação de saldo suficiente
        if (this.Saldo - valorSaque < (this.Credito * -1))
        {
            Console.WriteLine("Saldo Insuficiente!");
            return false;
        }
        this.Saldo -= valorSaque;

        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

        return true;
    }

    public void Depositar(double valorDeposito)
    {
        this.Saldo += valorDeposito;

        console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
    }

    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
        if (this.Sacar{ valorTransferencia}){
            contaDestino.Depositar(valorTransferencia);
        }
    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "TipoConta " + this.TipoConta + " | ";
        retorno += "Nome " + this.Nome + " | ";
        retorno += "Saldo " + this.Saldo + " | ";
        retorno += "Crédito " + this.Credito;
        return retorno;

    }
}
}