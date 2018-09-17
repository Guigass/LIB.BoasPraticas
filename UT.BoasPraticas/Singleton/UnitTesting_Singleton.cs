using Microsoft.VisualStudio.TestTools.UnitTesting;
using Padrao.Singleton;

namespace UT.BoasPraticas.Singleton
{
    [TestClass]
    class UnitTesting_Singleton
    {
        [TestMethod]
        public void Teste_Singleton_1()
        {
            //Singleton1 instancia = new Singleton1();

            Singleton1.Metodo();
        }

        [TestMethod]
        public void Teste_Singleton_2()
        {
            Singleton2 instancia_a = Singleton2.CriarInstancia();
            Singleton2 instancia_b = Singleton2.CriarInstancia();

            Assert.AreSame(instancia_a, instancia_b);
        }

        [TestMethod]
        public void Teste_Singleton_3()
        {
            Singleton3 instancia_a = Singleton3.CriarInstancia();
            Singleton3.Metodo();

            Singleton3 instancia_b = Singleton3.CriarInstancia();

            Assert.AreSame(instancia_a, instancia_b);
        }

        [TestMethod]
        public void Teste_Singleton_4()
        {
            Singleton4.Metodo();

            Singleton4 instancia_a = Singleton4.Instancia;
            Singleton4 instancia_b = Singleton4.Instancia;

            Assert.AreSame(instancia_a, instancia_b);
        }

        [TestMethod]
        public void Teste_Singleton_5()
        {
            Singleton5.Metodo();

            Singleton5 instancia_a = Singleton5.Instancia;
            Singleton5 instancia_b = Singleton5.Instancia;

            Assert.AreSame(instancia_a, instancia_b);
        }
    }
}
