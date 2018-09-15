using Console_teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Console_teste
{
    [TestClass]
    public class operadoresTests
    {


        [TestInitialize]
        public void TestInitialize()
        {

        }


        private operadores Createoperadores()
        {
            return new operadores();
        }

        [TestMethod]
        public void adicao_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = Createoperadores();
            int x = 2;// TODO;
            int y = 2;//TODO;

            // Act
            var result = unitUnderTest.adicao(
                x,
                y);

            
        }

        [TestMethod]
        public void substracao_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = Createoperadores();
            int x = 2; //TODO;
            int y = 2; //TODO;

            // Act
            var result = unitUnderTest.substracao(
                x,
                y);

           
        }
    }
}
