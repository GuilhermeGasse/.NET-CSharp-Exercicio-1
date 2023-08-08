using ex1.models;
using Newtonsoft.Json;

// Código feito para fins de treino, praticando recursos da programação e .NET/C#.

// Instancias das pessoas.

Pessoa p1 = new()
{
    Nome = "Guilherme",
    Sobrenome = "Guimarães",
    Idade = 22
};

Pessoa p2 = new()
{
    Nome = "Luiz",
    Sobrenome = "Guimarães",
    Idade = 35
};

Pessoa p3 = new()
{
    Nome = "Zé",
    Sobrenome = "Ninguém",
    Idade = 20
};

// Instâncias dos cursos.

Curso BachareladoCienciaDaComputacao = new()
{
    Nome = "Ciência da computação",
    Alunos = new List<Pessoa>()
};

Curso BachareladoEngenhariaDeSoftware = new()
{
    Nome = "Enfermagem",
    Alunos = new List<Pessoa>()
};

// Saída de dados.

Console.WriteLine("\r");

Console.WriteLine("Sócios fundadores da empresa: ");

Console.WriteLine("\r");

p1.ApresentarPessoa();
p2.ApresentarPessoa();
p3.ApresentarPessoa();

Console.WriteLine("\r");

Console.WriteLine("Formações dos sócios: ");

Console.WriteLine("\r");

BachareladoCienciaDaComputacao.AdicionarAluno(p1);
BachareladoCienciaDaComputacao.AdicionarAluno(p2);
BachareladoCienciaDaComputacao.ListarAlunos2();

Console.WriteLine("\r");

BachareladoEngenhariaDeSoftware.AdicionarAluno(p3);
BachareladoEngenhariaDeSoftware.ListarAlunos2();

Console.WriteLine("\r");

// leitura de um arquivo de texto.

try
{
    string[] linhas1 = File.ReadAllLines("Arquivos/ArquivoDeLeitura.txt");

    foreach (string linha in linhas1)
    {
        Console.WriteLine(linha);
    }
}

// Tratar exceções, de formas especializadas.

catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}

catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

Console.WriteLine("\r\n");

// Incrementando fila.

Console.WriteLine("1 - Equipamentos para a produção do trabalho: ");

Console.WriteLine("\r");

Queue<string> EquipamentosPrincipais = new();

EquipamentosPrincipais.Enqueue("Cadeira antiga de escritório.");
EquipamentosPrincipais.Enqueue("Notebook.");
EquipamentosPrincipais.Enqueue("Mesa de escritório.");
EquipamentosPrincipais.Enqueue("Mouse");
EquipamentosPrincipais.Enqueue("IDE para desenvolvimento.");
EquipamentosPrincipais.Enqueue("Editor de texto para desenvolvimento.");

foreach (string item in EquipamentosPrincipais)
{
    Console.WriteLine(item);
}

Console.WriteLine("\r");

Console.WriteLine($"Removendo o elemento: {EquipamentosPrincipais.Dequeue()}");

Console.WriteLine("\r");

foreach (string item in EquipamentosPrincipais)
{
    Console.WriteLine(item);
}

Console.WriteLine("\r");

// Incrementando pilha.

Console.WriteLine("2 - Pilha das páginas do sistema da empresa: ");

Console.WriteLine("\r");

Stack<int> NavegacaoDePaginasWeb = new();

NavegacaoDePaginasWeb.Push(1);
NavegacaoDePaginasWeb.Push(2);
NavegacaoDePaginasWeb.Push(3);
NavegacaoDePaginasWeb.Push(4);

foreach (int item in NavegacaoDePaginasWeb)
{
    Console.WriteLine(item);
}

Console.WriteLine("\r");

Console.WriteLine($"Removendo o elemento do topo: {NavegacaoDePaginasWeb.Pop()}");

Console.WriteLine("\r");

NavegacaoDePaginasWeb.Push(5);

foreach (int item in NavegacaoDePaginasWeb)
{
    Console.WriteLine(item);
}

// Incrementando dicionário.

Console.WriteLine("\r");

Console.WriteLine("3 - Processo inicial para funcionamento da empresa: ");

Console.WriteLine("\r");

Dictionary<int, string> JornadaDev = new()
{
    { 1, "Elaborar a missão e as metas no papel." },
    { 2, "Projetar o crescimento da ideia."},
    { 3, "Investir em recrutamento e qualificação de talentos." },
    { 4, "Organizar os recursos e os sistemas do escritório." },
    { 5, "Captar e reter potenciais clientes."}
};

foreach (var item in JornadaDev)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("\r");

Console.WriteLine($"Removendo elemento ja concluído: ");

JornadaDev.Remove(1);

Console.WriteLine("\r");

foreach (var item in JornadaDev)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// Acrescentando tuplas.

Console.WriteLine("\r");


Console.WriteLine("4 - Articulando o modelo da empresa e as estratégias organizacionais: ");

Console.WriteLine("\r");

(string nomedaempresa, string nicho, int quantidadedeservicos, decimal objetivodefaturamento) = ("Mobile dynamics", "Consultoria de TI especializada em apps android.", 3, 200M);

Console.WriteLine($"Nome: {nomedaempresa}");
Console.WriteLine($"Nicho profissional: {nicho}");
Console.WriteLine($"Quantidade de serviços oferecidos: {quantidadedeservicos}");
Console.WriteLine($"Objetivo de faturamento mensal: {objetivodefaturamento}");

Console.WriteLine("\r");

// Listando coleção de vendas.

Console.WriteLine("5 - Definindo lista de produtos e serviços oferecidos: ");

Console.WriteLine("\r");

List<Vendas> ListaDeVendasDaEmpresa = new();

// Instanciando a venda de um produto, usando o construtor.

Vendas v1 = new
(1, "Softwares sob medida.", 10000M);
Vendas v2 = new
(2, "Conhecimento técnico.", 3500M);
Vendas v3 = new
(3, "Mão de obra qualificada.", 4000M);

ListaDeVendasDaEmpresa.Add(v1);
ListaDeVendasDaEmpresa.Add(v2);
ListaDeVendasDaEmpresa.Add(v3);

// Instanciado uma serialização e convertento em json.

string _ = JsonConvert.SerializeObject(ListaDeVendasDaEmpresa, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", _);

Console.WriteLine(_);










