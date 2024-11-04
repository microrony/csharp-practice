/*
This code reverse a string and count how much a specific character appear's then prints the result in the console.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";
int letterCount = 0;

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

foreach (char letter in message)
{
  if (letter == 'o')
  {
    letterCount++;
  }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
