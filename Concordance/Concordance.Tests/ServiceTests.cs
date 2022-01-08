using Concordance.Models;
using Concordance.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Concordance.Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void GenerateShouldThrowExceptionWithNullFile()
        {
            var testSample = new MyFile("sample.txt");
            var service = new ConcordanceService();
            var expected = "File is invalid or empty";

            var actual = Assert.ThrowsException<Exception>(() => service.Generate(null));
            Assert.AreEqual(actual.Message, expected);
        }

        [TestMethod]
        public void GenerateShouldThrowExceptionWithNullFileContents()
        {
            var testSample = new MyFile("sample.txt");
            var service = new ConcordanceService();
            testSample.Contents = null;
            var expected = "File is invalid or empty";

            var actual = Assert.ThrowsException<Exception>(() => service.Generate(testSample));
            Assert.AreEqual(actual.Message, expected);
        }

        [TestMethod]
        public void FormatShouldThrowExceptionOnNullConcordance()
        {
            var testSampleFile = new MyFile("sample.txt");
            var service = new ConcordanceService();
            var expected = "Concordance is invalid or empty";

            var actual = Assert.ThrowsException<Exception>(() => service.FormatConcordance(null));
            Assert.AreEqual(actual.Message, expected);
        }

    }
}
