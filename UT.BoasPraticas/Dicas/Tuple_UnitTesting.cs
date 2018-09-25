using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    class Tuple_UnitTesting
    {
        [TestMethod]
        public void Simples_Tuble()
        {
            var tupleUmElemento = new Tuple<int>(1);

            var tupleDoisElementos = new Tuple<int, string>(1, ".NET Core");

            var tupleCincoElementos = new Tuple<int, int, string, int, decimal>(1, 2, "C#", 4, 5m);

            // Static Create methods
            var tubleDinamico = Tuple.Create(50, "FIAP", DateTime.Now);
        }

        [TestMethod]
        public void Tuble_Recuperando_Valores()
        {
            var tuple = Tuple.Create(10, "MBA .NET");

            int valor = tuple.Item1;
            string texto = tuple.Item2;

            // tuple.Item1 = 10; -- Erro de compilação
        }
    }

}
