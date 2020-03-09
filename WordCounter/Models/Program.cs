using System;
using System.Collections.Generic;
using WordCounter.Models;

class Program
{

  public static RepeatCounter myRepeatCounter;

  static void Main()
  {
    myRepeatCounter = new RepeatCounter();

    Console.WriteLine("Welcome to the WordCount App, it finds how many times a word perfectly occurs in a sentence.");
    Console.WriteLine("Enter a word.");
    string userWord = Console.ReadLine();
    Console.WriteLine("Enter a sentence.");
    string userSentence = Console.ReadLine();
    Console.WriteLine($"Word: {userWord}, Sentence: {userSentence}");
    myRepeatCounter.SetWordAndSentence(userWord, userSentence);
    myRepeatCounter.AllSymbolRemover();
    myRepeatCounter.FindMatch();
    Console.WriteLine($"Your Word: {myRepeatCounter.Word}, Matched {myRepeatCounter.Count} Time(s) in Your Sentence.");
  }
}