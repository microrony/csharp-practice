string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(",");

for (int i = 0; i < orderIDs.Length; i++)
{
  if (orderIDs[i].Length != 4)
  {
    Console.WriteLine($"{orderIDs[i]}\t- Error");
  }
  else
  {
    Console.WriteLine(orderIDs[i]);
  }
}