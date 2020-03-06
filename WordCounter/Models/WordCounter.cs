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