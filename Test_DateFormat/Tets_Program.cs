using NUnit.Framework;
using System;
using TestDate.src.Library;

namespace Test_DateFormat
{
    [TestFixture]
    public class Tests_Program
    {

        [Test]
        [TestCase("10/11/1977", "1977-11-10")]
        [TestCase("08/06/2021", "2021-06-08")]
        [TestCase("31/12/1946", "1946-12-31")]
        public void ChangeFormat1(String year, String expected)
        {
            Format FormatClass = new Format();
            string result = FormatClass.ChangeFormat1(year);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Utilizo el metodo TDD para agregar el nuevo metodo de formateo de fecha. Inicialmente realize el test
        /// especificado abajo y lo ejecute. Cabe acalar que el test fallo por obvias razones. A partir del test 
        /// realize el codigo correspondiente de una manera corta y rapida. Por ultimo aplique la refactorizacion
        /// y corri el test dando como resultado una prueba exitosa.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase("10/11/1977", "10-11-1977")]
        [TestCase("08/06/2021", "08-06-2021")]
        [TestCase("31/12/1946", "31-12-1946")]
        public void ChangeFormat2(String year, String expected)
        {
            Format FormatClass = new Format();
            string result = FormatClass.ChangeFormat2(year);
            Assert.AreEqual(expected, result);
        }

    }
}