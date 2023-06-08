using Microsoft.VisualStudio.TestTools.UnitTesting;
using Программа;

namespace Программа.tests
{
    internal class CountWords_Test
    {
        // в Dictionary нет слов
        [TestMethod]
        public void CountWords_NoWords_ReturnsZero()
        {
            // Arrange
            Dictionary dictionary = new Dictionary();

            // Act
            int result = dictionary.CountWords();

            // Assert
            Assert.AreEqual(0, result);
        }

        // в Dictionary 1 слово
        [TestMethod]
        public void CountWords_SingleWord_ReturnsOne()
        {
            // Arrange
            Dictionary dictionary = new Dictionary();
            string word = "Hello";
            string translation = "Привет";
            dictionary.AddWord(word, translation);

            // Act
            int result = dictionary.CountWords();

            // Assert
            Assert.AreEqual(1, result);
        }

        // в Dictionary 2 слова
        [TestMethod]
        public void CountWords_MultipleWords_ReturnsCorrectCount()
        {
            // Arrange
            Dictionary dictionary = new Dictionary();
            string word1 = "Hello";
            string translation1 = "Привет";
            string word2 = "Goodbye";
            string translation2 = "До свидания";
            dictionary.AddWord(word1, translation1);
            dictionary.AddWord(word2, translation2);

            // Act
            int result = dictionary.CountWords();

            // Assert
            Assert.AreEqual(2, result);
        }

    }
}
