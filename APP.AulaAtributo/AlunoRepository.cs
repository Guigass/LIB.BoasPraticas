using System;
using static System.Console;

namespace APP.AulaAtributo
{
    public class AlunoRepository
    {
        private readonly Aluno _aluno;
        public AlunoRepository(Aluno aluno)
        {
            _aluno = aluno;
        }

        //[Obsolete("O metodo será removido na versão .NET Core 3")]
        public void GetDisplayAluno()
        {
            GetAluno();
            GetCursoPorAluno();
        }

        private void GetAluno()
        {
            WriteLine(_aluno.Nome);
            WriteLine(_aluno.Matricula);
        }

        private void GetCursoPorAluno()
        {
            WriteLine(_aluno.Curso.Descricao);
            foreach (var item in _aluno.Curso.Disciplinas)
            {
                WriteLine(item.Titulo);
                WriteLine(item.Nota);
                WriteLine(item.Situacao);
            }
        }
    }
}
