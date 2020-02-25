using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public class Palindrome
{
  public string UserPalindrome;
  public string ReversePalindrome;

  public Palindrome(string userPalindrome, string reversePalindrome)
  {

    UserPalindrome = userPalindrome;
    ReversePalindrome = reversePalindrome;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a string! I'll tell you if it is a palindrome:");
    string userInput = Console.ReadLine().ToLower();
    string userInputForwards = Regex.Replace(userInput, @"[^0-9a-zA-Z]+", "");
    Console.WriteLine(userInputForwards);
    string userInputBackwards = ReverseString(userInputForwards);
    Console.WriteLine(userInputBackwards);

  Palindrome userInputPalindrome = new Palindrome(userInputForwards, userInputBackwards);

    if (userInputPalindrome.UserPalindrome == userInputPalindrome.ReversePalindrome)
    {
      Console.WriteLine("You made a palindrome!");
    }
    else 
    {
      Console.WriteLine("You did NOT make a palindrome!");
    }


  }

  public static string ReverseString(string userInputForwards)
  {
    char[] charArr = userInputForwards.ToCharArray();
    Array.Reverse(charArr);
    string userInputBackwards = new string (charArr);
    return new string (charArr);
  }
}

    


