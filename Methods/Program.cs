string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

DisplayEmailAddress(corporate);
DisplayEmailAddress(external, isCorporate: false, externalDomain);

void DisplayEmailAddress(string[,] employees, bool isCorporate = true, string domainName = "contoso.com")
{
  for (int i = 0; i < employees.GetLength(0); i++)
  {
    string email;
    string username = (employees[i, 0][..2] + employees[i, 1]).ToLower();
    email = $@"{username}@{domainName}";
    Console.WriteLine(email);
  }
}