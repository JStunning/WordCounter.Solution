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

    public void SetWord(string word)
    {
      Word = word.ToLower();
    }

    public void SetSentence(string sentence)
    {
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