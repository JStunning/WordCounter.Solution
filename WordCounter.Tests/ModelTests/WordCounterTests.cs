using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterTests
  {

    [TestMethod]
    public void Counter_CounterConstructor_NewCounter()
    {
      // Arrange
      Counter newCounter = new Counter();
      // Act
      int resultCount = newCounter.Count;
      string resultWord = newCounter.Word;
      string resultSentence = newCounter.Sentence;
      // Assert
      Assert.AreEqual(resultCount, 0);
      Assert.AreEqual(resultWord, "");
      Assert.AreEqual(resultSentence, "");
    }

    [TestMethod]
    public void Counter_SetWord_Hello()
    {
      // Arrange
      Counter newCounter = new Counter();
      // Act
      newCounter.SetWord("Hello");
      string result = newCounter.Word;
      // Assert
      Assert.AreEqual(result, "Hello");
    }

    [TestMethod]
    public void Counter_SetSentence_HelloWorld()
    {
      // Arrange
      Counter newCounter = new Counter();
      // Act
      newCounter.SetSentence("Hello World");
      string result = newCounter.Sentence;
      // Assert
      Assert.AreEqual(result, "Hello World");
    }
  }
}