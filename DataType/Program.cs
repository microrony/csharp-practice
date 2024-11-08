/*
This loop separate the numeric values 
and string values from the arrays values.
Also this adds those values together and 
output the result on Console.
*/
string message = "";
decimal total = 0;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

foreach (string value in values)
{
  decimal number = 0;

  if (decimal.TryParse(value, out number))
  {
    total += number;
  }
  else
  {
    message += value;
  }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");