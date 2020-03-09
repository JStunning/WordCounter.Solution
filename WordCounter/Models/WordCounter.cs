using System;
using System.Linq;
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
    public void AllSymbolRemover()
    {
      WordSymbolRemover();
      SentenceSymbolRemover();
    }

    public void WordSymbolRemover()
    {
      string newWord = Word;
      char comma = char.Parse(",");
      char period = char.Parse(".");
      int removeIndex = 0;
      for (int i = 0; i < newWord.Length; i++)
      {
        if (newWord[i] == comma){
          removeIndex = i;
        }
        else if (newWord[i] == period){
          removeIndex = i;
        }
      }
      if (removeIndex > 0)
      {
        Word = newWord.Remove(removeIndex);
      }
      else 
      {
        Word = newWord;
      }
      
    }

    public void SentenceSymbolRemover()
    {
      string newSentence = Sentence;
      char comma = char.Parse(",");
      char period = char.Parse(".");
      int removeIndex = 0;
      for (int i = 0; i < newSentence.Length; i++)
      {
        Console.WriteLine("newSentence i " + newSentence[i]);
        if (newSentence[i] == comma){
          removeIndex = i;
        }
        else if (newSentence[i] == period){
          removeIndex = i;
        }
      }
      if (removeIndex > 0)
      {
        Sentence = newSentence.Remove(removeIndex);
      }
      else 
      {
        Sentence = newSentence;
      }
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