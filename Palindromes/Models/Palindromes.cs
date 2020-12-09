using System;
using System.Collections.Generic;

namespace Palindromes

{
  public class FlipItAndReverseIt
    
  {
    public static string ReverseString (string myStr)
    {
      char[] myArr = myStr.ToCharArray();
      Array.Reverse(myArr);
      return new string(myArr);
    }
  }

  public class CheckIfPalindrome
  {
    public static bool IsPalindrome(string myArr)
    {
      if (myArr == myStr)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }

  public class myProgram
  {
    public void Main()
    {
      Console.WriteLine("Type in a word to see if it's a palindrome!");
      string myStr = FlipItAndReverseIt.ReverseString(Console.ReadLine());
      Console.WriteLine(myStr);
    }
  }
}

      // Console.WriteLine( "Enter a word, phrase, or number to see if it is a Palindrome" );
      // string userInput = Console.ReadLine();
      // string[] userArr =  userInput.Split("") ;

      // foreach (var sub in userArr)
      // {
      //   Console.WriteLine($"Substring: {sub}");
      // }

      // Console.WriteLine ( userArr );