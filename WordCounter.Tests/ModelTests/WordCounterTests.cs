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
    public void RepeatCounter_SetWordAndSentence_HelloHelloWorld()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWordAndSentence("Hello", "Hello World");
      string resultWord = newRepeatCounter.Word;
      string resultSentence = newRepeatCounter.Sentence;
      // Assert
      Assert.AreEqual(resultWord, "hello");
      Assert.AreEqual(resultSentence, "hello world");
    }

    [TestMethod]
    public void RepeatCounter_SetWordAndSentence_NonLetterChars()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWordAndSentence("!@#$", "!@#$ %^&*");
      string resultWord = newRepeatCounter.Word;
      string resultSentence = newRepeatCounter.Sentence;
      // Assert
      Assert.AreEqual(resultWord, "!@#$");
      Assert.AreEqual(resultSentence, "!@#$ %^&*");
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
      newRepeatCounter.SetWordAndSentence("Hello", "Hello World");
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
      newRepeatCounter.SetWordAndSentence("Hello", "Hello Hello Hello Helloooo, World");
      newRepeatCounter.FindMatch();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 3);
    }

    [TestMethod]
    public void RepeatCounter_WordSymbolRemoverComma_Hello()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWordAndSentence("Hello,", "Hello World");
      newRepeatCounter.WordSymbolRemover();
      newRepeatCounter.FindMatch();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void RepeatCounter_WordSymbolRemoverPeriod_Hello()
    {
      // Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter();
      // Act
      newRepeatCounter.SetWordAndSentence("Hello.", "Hello World");
      newRepeatCounter.WordSymbolRemover();
      newRepeatCounter.FindMatch();
      int result = newRepeatCounter.Count;
      // Assert
      Assert.AreEqual(result, 1);
    }
  }
}