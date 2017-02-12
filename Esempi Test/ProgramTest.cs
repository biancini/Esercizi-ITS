using NUnit.Framework;

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
            int sum = program.add(5, 7);

            // then
            Assert.AreEqual(12, sum);
        }
    }
}
