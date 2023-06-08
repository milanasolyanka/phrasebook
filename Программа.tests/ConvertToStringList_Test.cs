using Microsoft.VisualStudio.TestTools.UnitTesting;
using Программа;

namespace Программа.tests
{
    [TestClass]
    public class ConvertToStringList_Test
    {
        //при отсутствии слов возвращает пустую строку
        [TestMethod]
        public void ConvertToStringList_NoWords_ReturnsEmptyString()
        {
            // Arrange
            Dictionary dictionary = new Dictionary();

            // Act
            string result = dictionary.ConvertToStringList();

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        //добавляем в Dictionary одно слово, строка должна соответствовать формату с тире
        [TestMethod]
        public void ConvertToStringList_SingleWord_ReturnsCorrectString()
        {
            // Arrange
            Dictionary dictionary = new Dictionary();
            string word = "Hello";
            string translation = "Привет";
            dictionary.AddWord(word, translation);

            // Act
            string result = dictionary.ConvertToStringList();

            // Assert
            Assert.AreEqual("Hello - Привет", result);
        }

        //добавляем в Dictionary несколько слов, строка должна соответствовать формату с тире и переносами
        [TestMethod]
        public void ConvertToStringList_MultipleWords_ReturnsCorrectString()
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
            string result = dictionary.ConvertToStringList();

            // Assert
            string expected = "Hello - Привет" + Environment.NewLine + "Goodbye - До свидания";
            Assert.AreEqual(expected, result);
        }

    }
}
