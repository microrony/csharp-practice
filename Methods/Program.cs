Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
  PlayGame();
}

bool ShouldPlay()
{
  string input = "";

  do
  {
    string? userInput = Console.ReadLine();
    if (userInput != null)
    {
      input = userInput.ToLower();
    }
  } while (input != "y" && input != "n");

  return input == "y";
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = random.Next(1, 6);
    var roll = random.Next(1, 6);

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(target, roll));
    Console.WriteLine("\nPlay again? (Y/N)");

    play = ShouldPlay();
  }
}

string WinOrLose(int target, int roll)
{
  return roll > target ? "You won!" : "You lose!";
}