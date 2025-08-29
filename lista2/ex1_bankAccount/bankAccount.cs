public class BankAccount
{
    //ATRIBUTOS
    public int Numero;
    public string Titular;
    public double Saldo;


    //CONSTRUTOR(ES)
    public BankAccount(int numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        Saldo = 0.0;
    }


    //MÉTODOS
    public bool Depositar(int numero, double valor)

    {
        if (Numero != numero || valor <= 0)
            return false;


        Saldo += valor;
        return true;
    }

    public bool Sacar(int numero, double valor)
    {
        if (Numero != numero || valor <= 0 || valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }

    //ToString
    public override string ToString()
    {
        return $"\nConta número: {Numero}, titular {Titular}\nSaldo: {Saldo}";
    }
}