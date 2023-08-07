using ex1.models;

Pessoa p1 = new()
{
    Nome = "Gui",
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

Curso BachareladoCienciaDaComputacao = new()
{
    Nome = "Ciência da computação",
    Alunos = new List<Pessoa>()
};

Curso BachareladoEnfermagem = new()
{
    Nome = "Enfermagem",
    Alunos = new List<Pessoa>()
};

p1.ApresentarPessoa();
p2.ApresentarPessoa();
p3.ApresentarPessoa(); 

BachareladoCienciaDaComputacao.AdicionarAluno(p1);
BachareladoCienciaDaComputacao.AdicionarAluno(p2);
BachareladoCienciaDaComputacao.ListarAlunos();

BachareladoEnfermagem.AdicionarAluno(p3);
BachareladoEnfermagem.ListarAlunos();
