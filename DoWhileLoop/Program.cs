Random random = new Random();
int heroHealthPoints = 10;
int monsterHealthPoints = 10;
string attacker = "hero";

do
{
  int hitPoint = random.Next(1, 11);

  switch (attacker)
  {
    case "hero":
      monsterHealthPoints -= hitPoint;
      Console.WriteLine($"Monster was damaged and lost {hitPoint} health and now has {monsterHealthPoints} health.");
      attacker = "monster";
      break;
    case "monster":
      heroHealthPoints -= hitPoint;
      Console.WriteLine($"Hero was damaged and lost {hitPoint} health and now has {heroHealthPoints} health.");
      attacker = "hero";
      break;
  }

  if (heroHealthPoints > 0 && monsterHealthPoints > 0) continue;

  Console.WriteLine(heroHealthPoints > 0 ? "Hero wins!" : "Monster wins!");

} while (heroHealthPoints > 0 && monsterHealthPoints > 0);
