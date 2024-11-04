Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string message = "";
string discountMessage = "";

if (daysUntilExpiration > 10) return;

if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
  message = "Your subscription will expire soon. Renew now!";
}
else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
{
  message = $"Your subscription expires in {daysUntilExpiration} days.";
  discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
  message = "Your subscription expires within a day!";
  discountPercentage = 20;
}
else
{
  message = "Your subscription has expired.";
}

if (discountPercentage > 0)
{
  discountMessage = $"Renew now and save {discountPercentage}%.";
}


Console.WriteLine($"{message}\n{discountMessage}");
