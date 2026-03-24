
Console.WriteLine("Welcome to WeatherAdvisor!");
Console.WriteLine("Enter temperature: e.g. -30, -20, -10, 0, 10, 20, 30");
string tempInput = Console.ReadLine();
int temperature = int.Parse(tempInput);

Console.WriteLine("Enter weather condition (snow/rain/sun)");
string weatherCondition = Console.ReadLine().ToLower();



switch (weatherCondition)
{
  case  "snow":
    Snow();
    break;
  case "rain":
    Rain();
    break;
  case "sun":
    Sun();
    break;
  default:
    Console.WriteLine("Invalid input");
    break;
}
Console.ReadKey();

void Snow ()
{
  if (temperature <= -30)
    {
      Console.WriteLine("If i was you i would move somewhere else");
    }

  else if (temperature <= -10)
    {
      Console.WriteLine("Now is the time to put on your thermal underwear.");
    }
  else if (temperature <= 0)
    {
      Console.WriteLine("Heavy winter coat, gloves, and a hat.");
    }
  else if (temperature <= 10)
    {
      Console.WriteLine("Light snow, still cold. Layer up.");
    }
  else
    {
      Console.WriteLine("I dont believe you!");
    }

}


void Rain()
{
    if (temperature <= -30)
    {
      Console.WriteLine("That's not rain, if you could feel you would know.");
    }
    else if (temperature <= -10)
    {
      Console.WriteLine("Ice rain incoming. Waterproof everything and walk slowly.");
    }
    else if (temperature <= 0)
    {
      Console.WriteLine("Cold rain. Waterproof coat and warm layers underneath.");
    }
    else if (temperature <= 10)
    {
      Console.WriteLine("You must be in Bergen.");
    }
    else
    {
      Console.WriteLine("This is the best condition to go for a run!");
    }
}


void Sun()
{
    if (temperature <= -30)
    {
        Console.WriteLine("Sun is lying to you.");
    }
    else if (temperature <= -10)
    {
        Console.WriteLine("Crisp and sunny. Coat, gloves, Maybe go Ski.");
    }
    else if (temperature <= 0)
    {
        Console.WriteLine("Cold but pleasant. Jacket and maybe a scarf.");
    }
    else if (temperature <= 10)
    {
        Console.WriteLine("Light jacket weather. Nice day!");
    }
    else
    {
        Console.WriteLine("Sunscreen and shades! also can you send me your location?");
    }
}

