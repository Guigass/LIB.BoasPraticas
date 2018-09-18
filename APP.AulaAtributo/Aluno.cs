using APP.AulaAtributo.Atributos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace APP.AulaAtributo
{
    [DebuggerDisplay("Aluno {Nome} e Matrícula {Matricula}")]
    [DebuggerTypeProxy(typeof(AlunoDebugProxy))]
    [CorPadrao(Cor = ConsoleColor.Magenta)]
    public class Aluno
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Etiqueta("Matrícula: ", ConsoleColor.Green)]
        public int Matricula { get; set; }

        [Etiqueta("Nome: ", ConsoleColor.Green)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string Nome { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public Curso Curso { get; set; }
    }

    [Indentar]
    public class Curso
    {
        public string Descricao { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<Disciplina> Disciplinas { get; set; }
    }

    [DebuggerDisplay("Disciplina {Titulo} - {Situacao}")]
    [Indentar]
    [Indentar]
    public class Disciplina
    {
        public string Titulo { get; set; }
        public int Nota { get; set; }
        public string Situacao
        {
            get
            {
                if (Nota >= 7)
                    return "Aprovado";
                else
                    return "Reprovado";
            }
        }
    }
}
