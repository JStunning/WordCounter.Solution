using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    
    public int Count { get; set; }
    public string Word { get; set; }
    public string Sentence { get; set; }

    public Counter()
    {
      Count = 0;
      Word = "";
      Sentence = "";
    }

    public void SetWord(string word)
    {
      Word = word;
    }

    public void SetSentence(string sentence)
    {
      Sentence = sentence;
    }

  }
}