using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {

    public int Count { get; set; }
    public string Word { get; set; }
    public string Sentence { get; set; }

    public RepeatCounter()
    {
      Count = 0;
      Word = "";
      Sentence = "";
    }

    // Need check for comma or period method
    public void WordSymbolRemover()
    {
      string[] splitWord = Word.Split("");
      string newWord = Word;
      for (int i = 0; i < splitWord.Length; i++)
      {
        Console.WriteLine($"newWord i: {newWord[i]}");
        if (splitWord[i] == ",")
        {
          newWord.Remove(i);
          Word = newWord;
        }
        else if (splitWord[i] == ".")
        {
          newWord.Remove(i);
          Word = newWord;
        }
      }
      Console.WriteLine($"newWord: {newWord}");
    }

    public void SentenceSymbolRemover()
    {
      string[] splitSentence = Sentence.Split("");
      string newSentence = Sentence;
      for (int i = 0; i < splitSentence.Length; i++)
      {
        Console.WriteLine($"newSentence i: {newSentence[i]}");
        if (splitSentence[i] == ",")
        {
          newSentence.Remove(i);
          Sentence = newSentence;
        }
        else if (splitSentence[i] == ".")
        {
          newSentence.Remove(i);
          Sentence = newSentence;
        }
      }
      Console.WriteLine($"newSentence: {newSentence}");
    }

    public void SetWordAndSentence(string word, string sentence)
    {
      Word = word.ToLower();
      Sentence = sentence.ToLower();
    }

    public void FindMatch()
    {
      string[] splitSentence = Sentence.Split(" ");
      for(int i = 0; i < splitSentence.Length; i++)
      {
        if(splitSentence[i] == Word)
        {
          IncrementCount();
        }
      }
    }

    public void IncrementCount()
    {
      Count++;
    }

  }
}