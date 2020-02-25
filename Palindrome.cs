using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public class Palindrome
{
  public string UserPalindrome;

  public Palindrome(string userPalindrome)
  {
    UserPalindrome = UserPalindrome;
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a string! I'll tell you if it is a palindrome:");
    string userInput = Console.ReadLine().ToLower();
    string trimmedInput = userInput.Replace(" ", "");
    char[] charsToTrim = { '*', '-', '/', ' ' };    
    string cleanString = trimmedInput.Trim(charsToTrim);


    Console.WriteLine(cleanString);

  }

  // public void WordChecker()
  // {
  //  if (trimmedInput )
  // }


  // public void CheckReverse()
  // {
  //  if (trimmedInput )
  // }



}