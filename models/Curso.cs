using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int ObterQuantidadeDeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarAlunos1()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public void ListarAlunos2()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            
            for(int contador = 0; contador < Alunos.Count; contador++)
            {
                int contadordeexibicao = contador + 1;
                string listagem2 = $"N° {contadordeexibicao}: {Alunos[contador].NomeCompleto}";
                Console.WriteLine(listagem2);
            }
        }
    }
}