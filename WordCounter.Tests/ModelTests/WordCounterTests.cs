using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {

    [TestMethod]
    public void RepeatCounter_RepeatCounterConstructor_NewRepeatCounter()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      int resultCount = newRepeatCounter.Count;
      string resultWord = newRepeatCounter.Word;
      string resultSentence = newRepeatCounter.Sentence;
      // Assert
      Assert.AreEqual(resultCount, 0);
      Assert.AreEqual(resultWord, "");
      Assert.AreEqual(resultSentence, "");
    }

    [TestMethod]
    public void RepeatCounter_SetWord_Hello()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWord("Hello");
      string result = newRepeatCounter.Word;
      // Assert
      Assert.AreEqual(result, "hello");
    }

    [TestMethod]
    public void RepeatCounter_SetSentence_HelloWorld()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetSentence("Hello World");
      string result = newRepeatCounter.Sentence;
      // Assert
      Assert.AreEqual(result, "hello world");
    }

    [TestMethod]
    public void RepeatCounter_IncrementCount_1()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.IncrementCount();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void RepeatCounter_FindMatch_1()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWord("Hello");
      newRepeatCounter.SetSentence("Hello World");
      newRepeatCounter.FindMatch();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void RepeatCounter_FindMatch_3()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWord("Hello");
      newRepeatCounter.SetSentence("Hello Hello Hello Helloooo, World");
      newRepeatCounter.FindMatch();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 3);
    }
  }
}