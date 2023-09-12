using DemoBiblioteca;

namespace DemoPruebas
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrange
            int numero1 = 5;
            int numero2 = 7;

            // Ejecutamos la prueba -> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            int resultadoEsperado = 12;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta() 
        {
            int numero1 = 5, numero2 = 7;
            int resultado = Calculadora.restar(numero1, numero2);
            Assert.AreEqual(-2, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int numero1 = 5, numero2 = 7;
            int resultado = Calculadora.multiplicar(numero1, numero2);
            Assert.AreEqual(35, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            int numero1 = 10, numero2 = 2;
            decimal resultado = Calculadora.divir(numero1, numero2);
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void TestModuloDivision()
        {
            int numero1 = 7, numero2 = 2;
            int resultado = Calculadora.modulo(numero1, numero2);
            Assert.AreEqual(1, resultado);
        }
    }
}