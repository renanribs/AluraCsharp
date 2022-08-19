using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Renan Ribeiro";
conta1.conta = "10123-x";
conta1.numero_agencia = 26;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100;

Console.WriteLine($"Titular: {conta1.titular}");
Console.WriteLine($"Conta: {conta1.conta}");
Console.WriteLine($"Numero da agencia: {conta1.numero_agencia}");
Console.WriteLine($"Nome da agencia: {conta1.nome_agencia}");
Console.WriteLine($"Saldo: {conta1.saldo}");
