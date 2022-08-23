using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
Console.WriteLine();

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "Renan Ribeiro";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 26;
//conta1.nome_agencia = "Agencia Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Vanessa Maluf";
//conta2.conta = "10122-x";
//conta2.numero_agencia = 26;
//conta2.nome_agencia = "Agencia Central";
//conta2.saldo = 100;

//Console.WriteLine($"Saldo Renan: {conta1.saldo}");

//bool sacar = conta1.Sacar(500);

//if (sacar)
//{
//    Console.WriteLine("Saque Realizado com sucesso!");
//}
//else { Console.WriteLine("Saque não pode ser realizado."); }

//Console.WriteLine($"Saldo Renan após saque: {conta1.saldo}");
//Console.WriteLine($"Saldo Vanessa: {conta2.saldo}");
//Console.WriteLine("Depositando na conta Vanessa");
//conta2.Depositar(50);
//Console.WriteLine($"Saldo Vanessa: {conta2.saldo}");
//Console.WriteLine($"Tranferindo de Vanessa para Renan");
//conta2.Transferir(30, conta1);
//Console.WriteLine($"Saldo Renan: {conta1.saldo} | Saldo Vanessa: {conta2.saldo}");
//conta2.ExibeInformacao();

//Cliente cliente = new Cliente();
//cliente.nome = "Renan Ribeiro";
//cliente.cpf = "123456";
//cliente.profissao = "Analista";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = cliente;
//conta3.conta = 12334;
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);

Cliente vanessa = new Cliente("Vanessa", "123456", "Engenheira");
Cliente vanessa2 = new Cliente("Vanessa", "123456", "Engenheira");
Cliente vanessa3 = new Cliente("Vanessa", "123456", "Engenheira");
Cliente vanessa4 = new Cliente("Vanessa", "123456", "Engenheira");

ContaCorrente conta4 = new ContaCorrente(123, "123456");
conta4.Saldo = 150;
conta4.Titular = vanessa;
Console.WriteLine($"Seu saldo é: {conta4.Saldo}");
Console.WriteLine($"Seu numero de agencia é: {conta4.Numero_agencia}");
Console.WriteLine($"Sua conta é: {conta4.Conta}");

ContaCorrente conta5 = new ContaCorrente(123, "12333");
ContaCorrente conta6 = new ContaCorrente(123, "123331");

Console.WriteLine($"Número de contas criadas: {ContaCorrente.TotalDeContasCriadas} ");
Console.WriteLine($"Numero de clientes cadastrados: {Cliente.TotaldeClientes} ");

Console.WriteLine();
