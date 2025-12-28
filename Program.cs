Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
string textoIdade = Console.ReadLine();

int idade;
while (!int.TryParse(textoIdade, out idade))
{
    Console.Write("Idade inválida, tente novamente: ");
    textoIdade = Console.ReadLine();
}

Console.WriteLine($"Olá, {nome}. Ano que vem você terá {idade + 1} anos.");
