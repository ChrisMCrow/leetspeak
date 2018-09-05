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
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (inputArray[i] == 'e' || inputArray[i] == 'E')
        {
          letterList.Add('3');
        }
        else if (inputArray[i] == 'o' || inputArray[i] == 'O')
        {
          letterList.Add('0');
        }
        else if (inputArray[i] == 'I')
        {
          letterList.Add('1');
        }
        else if (inputArray[i] == 't' || inputArray[i] == 'T')
        {
          letterList.Add('7');
        }
        else if ((inputArray[i] == 's' || inputArray[i] == 'S') && i != 0)
        {
          letterList.Add('z');
        }
        else
        {
          letterList.Add(inputArray[i]);
        }
      }
      string result = string.Join("", letterList);
      return result;
    }
  }
}
