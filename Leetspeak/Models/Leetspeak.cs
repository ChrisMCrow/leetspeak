using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class LeetspeakTranslator
  {
    public string Translate(string input)
    {
      char[] inputArray = input.ToCharArray();
      List<char> letterList = new List<char> {};
      foreach(char inp in inputArray)
      {
        if (inp == 'e' || inp == 'E')
        {
          letterList.Add('3');
        }
        else if (inp == 'o' || inp == 'O')
        {
          letterList.Add('0');
        }
        else
        {
          letterList.Add(inp);
        }
      }
      string result = string.Join("", letterList);
      return result;
    }
  }
}
