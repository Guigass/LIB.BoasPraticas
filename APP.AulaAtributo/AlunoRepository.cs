using APP.AulaAtributo.Atributos;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using static System.Console;

namespace APP.AulaAtributo
{
    public class AlunoRepository
    {
        StringBuilder output;
        ConsoleColor _corOrignal;

        private readonly Aluno _aluno;
        public AlunoRepository(Aluno aluno)
        {
            _aluno = aluno;
            output = new StringBuilder();
            output.Clear();
        }

        //[Obsolete("O metodo será removido na versão .NET Core 3")]
        public void GetDisplayAluno()
        {
            GetAluno();
            GetCursoPorAluno();

            GetDebuggingInformation();
            GetFiapInformation();
        }

        [Conditional("FIAP")]
        private void GetFiapInformation()
        {
            WriteLine("**** MODO DE COMPILAÇÂO - RELEASE FIAP");
        }

        [Conditional("DEBUG")]
        private void GetDebuggingInformation()
        {
            WriteLine("**** MODO DE COMPILAÇÂO - DEPURAÇÂO");
        }

        private void GetAluno()
        {
            PropertyInfo nomeProperty = typeof(Aluno).GetProperty(nameof(Aluno.Nome));
            PropertyInfo matriculaProperty = typeof(Aluno).GetProperty(nameof(Aluno.Matricula));

            EtiquetaAttribute nomeetiqueAttribute = (EtiquetaAttribute)Attribute.GetCustomAttribute(nomeProperty, typeof(EtiquetaAttribute));
            EtiquetaAttribute matriculaetiqueAttribute = (EtiquetaAttribute)Attribute.GetCustomAttribute(matriculaProperty, typeof(EtiquetaAttribute));

            SetCor(true);

            if (nomeetiqueAttribute != null)
            {
                ForegroundColor = nomeetiqueAttribute.Cor;
                output.Append(nomeetiqueAttribute.Descricao);
            }
            output.AppendLine(_aluno.Nome);

            if (matriculaetiqueAttribute != null)
            {
                ForegroundColor = matriculaetiqueAttribute.Cor;
                output.Append(matriculaetiqueAttribute.Descricao);
            }
            output.AppendLine(_aluno.Matricula.ToString());
            WriteLine(output);

            SetCor(false);
        }

        private void SetCor(bool original)
        {
            if (original)
            {
                _corOrignal = ForegroundColor;
            }
            else
            {
                ForegroundColor = _corOrignal;
            }
        }

        private void GetCursoPorAluno()
        {
            output.Clear();
            SetCor(true);
            Attribute[] cursoattrs = Attribute.GetCustomAttributes(typeof(Curso));
            foreach (Attribute item in cursoattrs)
            {
                if (item is IndentarAttribute) output.Append(new string(' ', 5));
            }
            output.AppendLine(_aluno.Curso.Descricao);

            Attribute[] disciplinaattrs = Attribute.GetCustomAttributes(typeof(Disciplina));
            int indentarCount = 0;
            foreach (Attribute item in disciplinaattrs)
            {
                if (item is IndentarAttribute) indentarCount++;
            }
            foreach (var disciplina in _aluno.Curso.Disciplinas)
            {
                for (int index = 0; index < indentarCount; index++)
                {
                    output.Append(new string(' ', 5));
                }
                output.AppendLine($"Disciplina: {disciplina.Titulo} - Nota: {disciplina.Nota.ToString()} : {disciplina.Situacao}");
            }

            WriteLine(output);

            SetCor(false);
        }
    }
}
