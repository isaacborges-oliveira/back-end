using System.Threading.Tasks.Dataflow;

Console.WriteLine(@"
+---------------------------------+
|          Bem Vindo!             |
+---------------------------------+
|  Faça seu cadastro logo abixo   |
+---------------------------------+
");

Console.WriteLine($"Nome:");
string nome = Console.ReadLine()!;

Console.WriteLine($"Olá {nome}, qual é o seu sobrenome?");
string sobrenome = Console.ReadLine()!;

Console.Write("Data de nascimento (dd/MM/yyyy): ");
DateTime dtnascimento = DateTime.Parse(Console.ReadLine());

Console.WriteLine($"Seu Email:");
string email = Console.ReadLine()!;

Console.WriteLine($"Telefone:");
Int128 Telefone = Int128.Parse(Console.ReadLine()!) ;

Console.WriteLine($"Cpf:");
string Cpf = Console.ReadLine()!;

Console.WriteLine($"Endereço:");
string Endereco = Console.ReadLine()!;


Console.WriteLine($"Estato civil:");

string ecivil = Console.ReadLine()!;


int idade = CalcularIdade(dtnascimento);



static int CalcularIdade(DateTime dataNascimento)
{
    DateTime dataAtual = DateTime.Now;
    int idade = dataAtual.Year - dataNascimento.Year;


    if (dataAtual < dataNascimento.AddYears(idade))
    {
        idade--;
    }

    return idade;
}

Console.WriteLine($@"Nome Completo: {nome}{sobrenome}
+---------------------------------+
| DtNascimento:{dtnascimento}     |
|---------------------------------|
| Email:{email}                   |
|---------------------------------|
| Telefone:{Telefone}             |
|---------------------------------|
| CPF: {Cpf}                      |
|---------------------------------|
| Endereco: {Endereco}            |
|---------------------------------|
| IDADE: {idade}                  |
|---------------------------------|
| ESTATOD CIVIL: {ecivil}         |
+*********************************+");