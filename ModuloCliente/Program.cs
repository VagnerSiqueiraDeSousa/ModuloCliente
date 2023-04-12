using ModuloCliente;

clientes cliente = new clientes();
cliente.Nome = "Vagner Sousa";
cliente.Cpf = "321.654.987-01";
cliente.Email = "aulaAlura@alura.com";
cliente.Idade = 39;

Console.WriteLine(cliente.Nome);
Console.WriteLine(cliente.Cpf);
Console.WriteLine(cliente.Idade);

Console.WriteLine(cliente.ToString());

