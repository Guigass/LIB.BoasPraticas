﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Debugger.Dicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Debugger
{
    [TestClass]
    class UnitTesting_DebuggerDisplay
    {
        [TestMethod]
        public void TesteAluno()
        {
            var aluno = new Aluno
            {
                Email = "teste@teste.com",
                Endereco = "Rua iae numero 8",
                Nome = "Teste teste Silva"
            };
        }
    }
}
