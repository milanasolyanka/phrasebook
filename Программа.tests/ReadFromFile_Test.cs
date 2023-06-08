using Microsoft.VisualStudio.TestTools.UnitTesting;
using Программа;

namespace Программа.tests
{
    [TestClass]
    public class ReadFromFile_Test
    {
        //всё нормально
        [TestMethod]
        public void ReadFromFile_ValidFile_ReturnsCorrectWordList()
        {
            // Arrange
            string fileName = "testFile.txt";
            string fileContent = "apple:яблоко\norange:апельсин\nbanana:банан";
            File.WriteAllText(fileName, fileContent);
            FileHandler fileHandler = new FileHandler();

            // Act
            List<Word> result = fileHandler.ReadFromFile(fileName);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("apple", result[0].WordText);
            Assert.AreEqual("яблоко", result[0].Translation);
            Assert.AreEqual("orange", result[1].WordText);
            Assert.AreEqual("апельсин", result[1].Translation);
            Assert.AreEqual("banana", result[2].WordText);
            Assert.AreEqual("банан", result[2].Translation);

            // Clean up
            File.Delete(fileName);
        }

        //файл пустой
        [TestMethod]
        public void ReadFromFile_EmptyFile_ReturnsEmptyWordList()
        {
            // Arrange
            string fileName = "emptyFile.txt";
            File.WriteAllText(fileName, string.Empty);
            FileHandler fileHandler = new FileHandler();

            // Act
            List<Word> result = fileHandler.ReadFromFile(fileName);

            // Assert
            Assert.AreEqual(0, result.Count);

            // Clean up
            File.Delete(fileName);
        }

        //слова в файле без разделителя
        [TestMethod]
        public void ReadFromFile_InvalidLines_ReturnsValidWordList()
        {
            // Arrange
            string fileName = "invalidFile.txt";
            string fileContent = "apple\norange\nbanana";
            File.WriteAllText(fileName, fileContent);
            FileHandler fileHandler = new FileHandler();

            // Act
            List<Word> result = fileHandler.ReadFromFile(fileName);

            // Assert
            Assert.AreEqual(0, result.Count);

            // Clean up
            File.Delete(fileName);
        }

    }
}