using Concordance.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Concordance.Tests
{
    [TestClass]
    public class FileTests
    {
        [TestMethod]
        public void FileFromDefaultFolderShouldNotBeNull()
        {
            var file = "sample.txt";
            var createdFile = new MyFile(file);

            createdFile.Should().NotBeNull();
        }

        [TestMethod]
        public void InvalidFileFromDefaultFolderShouldThrowException()
        {
            var invalidFile = "invalid.txt";
            Assert.ThrowsException<FileNotFoundException>(() => new MyFile(invalidFile));
        }

        [TestMethod]
        public void FileFromOtherFolderShouldLoad()
        {
            //var filePath = @"<filepath>"; // change for valid file path
            //var createdFile = new MyFile(filePath);

            //// change filePath before uncommenting next line
            // createdFile.Contents.Should().NotBeNull();
        }

    }
}