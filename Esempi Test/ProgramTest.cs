using NUnit.Framework;
using NSubstitute;

namespace Esempi_Test
{
    [TestFixture]
    class ProgramTest
    {
        /// <summary>
        /// Testa la somma di due numeri interi positivi.
        /// </summary>
        [Test]
        public void TestSommaDueNumeriInteri()
        {
            // given
            Program program = new Program();

            // when
            int sum = program.Add(5, 7);

            // then
            Assert.AreEqual(12, sum);
        }

        /// <summary>
        /// Test parametrico per la somma di due numeri interi
        /// </summary>
        /// <param name="addend1">Primo addendo</param>
        /// <param name="addend2">Secondo addendo</param>
        /// <returns>Il risultato della somma</returns>
        [TestCase(5, 7, ExpectedResult = 12)]
        [TestCase(5, -7, ExpectedResult = -2)]
        [TestCase(-5, 7, ExpectedResult = 2)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 7, ExpectedResult = 7)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int TestSommaParametrico(int addend1, int addend2)
        {
            // given
            Program program = new Program();

            // when
            int sum = program.Add(addend1, addend2);

            // then
            return sum;
        }

        /// <summary>
        /// Tetsa il metodo che stampa la somma di due numeri.
        /// </summary>
        [TestCase]
        public void TestStampaSommaDueNumeriInteri()
        {
            // given
            Program program = Substitute.For<Program>();
            program.Add(5, 7).Returns(37);

            // when
            string stampa = program.StampaSomma(5, 7);

            // then
            Assert.AreEqual("La somma di 5 e 7 è: 37.", stampa);
        }
    }
}
