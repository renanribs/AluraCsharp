using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Renan Ribeiro";
conta1.conta = "10123-x";
conta1.numero_agencia = 26;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Vanessa Maluf";
conta2.conta = "10122-x";
conta2.numero_agencia = 26;
conta2.nome_agencia = "Agencia Central";
conta2.saldo = 100;

Console.WriteLine($"Saldo Renan: {conta1.saldo}");

bool sacar = conta1.Sacar(500);

if (sacar)
{
    Console.WriteLine("Saque Realizado com sucesso!");
}
else { Console.WriteLine("Saque não pode ser realizado."); }

Console.WriteLine($"Saldo Renan após saque: {conta1.saldo}");
Console.WriteLine($"Saldo Vanessa: {conta2.saldo}");
Console.WriteLine("Depositando na conta Vanessa");
conta2.Depositar(50);
Console.WriteLine($"Saldo Vanessa: {conta2.saldo}");
Console.WriteLine($"Tranferindo de Vanessa para Renan");
conta2.Transferir(30, conta1);
Console.WriteLine($"Saldo Renan: {conta1.saldo} | Saldo Vanessa: {conta2.saldo}");
conta2.ExibeInformacao();

Console.WriteLine();
