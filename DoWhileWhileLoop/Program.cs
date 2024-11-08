using System.Runtime.InteropServices;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodCharacter = 0;

foreach (string str in myStrings)
{
  string myString = str;
  periodCharacter = myString.IndexOf('.');


  while (periodCharacter > 0)
  {
    if (myString.Length > 1)
    {
      string sentence = myString[..periodCharacter];

      Console.WriteLine(sentence);

      myString = myString.Remove(0, periodCharacter).TrimStart('.').Trim();
      periodCharacter = myString.IndexOf('.');
    }
  }

  if (periodCharacter < 0)
  {
    Console.WriteLine(myString);
  }
}