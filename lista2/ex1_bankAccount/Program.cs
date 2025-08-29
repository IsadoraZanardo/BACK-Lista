//PRIMEIRO OBJETO
BankAccount conta1 = new BankAccount(1, "Isadora");
//1 é int número da conta
//Isadora é string titular da conta

//SEGUNDO OBJETO
BankAccount conta2 = new BankAccount(2, "Bianca");

//PRINT OBJETOS
Console.WriteLine(conta1);
Console.WriteLine(conta2);


//OPERAÇÕES
conta1.Depositar(1, 238.89);
conta2.Depositar(2, 0.02);
conta2.Sacar(2, 0.01);
conta2.Saldo = -578.72; //só funciona valor NEGATIVO porque o ATRIBUTO é PÚBLICO

//PRINT OPERAÇÕES
Console.WriteLine(conta1);
Console.WriteLine(conta2);