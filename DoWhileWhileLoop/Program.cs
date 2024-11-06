bool validRole = false;
string[] roles = new string[] { "administrator", "manager", "user" };

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
  string? userInput = Console.ReadLine();

  if (userInput != null)
  {
    validRole = roles.Contains(userInput.Trim().ToLower());

    if (validRole)
    {
      Console.WriteLine($"Your input value ({userInput.Trim()}) has been accepted.");
    }
    else
    {
      Console.WriteLine($"The role name that you entered, \"{userInput.Trim()}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }
  }
} while (validRole == false);