/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int value = 5;

ChangeValue(value);

Console.WriteLine(value);

void ChangeValue(int value)
{
  value = 10;
}