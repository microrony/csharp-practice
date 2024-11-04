string[] fraudulentOrderIDs = {
"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

foreach (string ID in fraudulentOrderIDs)
{
  if (ID.StartsWith("B"))
  {
    Console.WriteLine(ID);
  }
}
