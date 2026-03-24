
int temperature = 0;
do
{
  Console.WriteLine();
  Console.WriteLine("Welcome to WeatherAdvisor! (X) to Exit");

  Console.WriteLine("Enter temperature: e.g. -30, 10, 20");
  string tempInput = Console.ReadLine() ?? "";

  if (tempInput.ToLower() == "x")
  {
    Console.WriteLine("Goodbye!");
    break;
  }

  if (!int.TryParse(tempInput, out temperature))
  {
    Console.WriteLine("Invalid input. Please enter a number.");
    continue;
  }
  
  Console.WriteLine("Enter weather condition (snow/rain/sun)");
  string weatherCondition = Console.ReadLine()?.ToLower() ?? "";

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
      Console.WriteLine("Invalid input please enter: (snow, rain or sun)");
      break;
  }
  Console.ReadKey();

} while (true);


void Snow ()
{
  switch (temperature)
  {
    case <= -30:
      Console.WriteLine("If i was you i would move somewhere else");
      break;
    case <= -10:
      Console.WriteLine("Now is the time to put on your thermal underwear.");
      break;
    case <= 0:
      Console.WriteLine("Heavy winter coat, gloves, and a hat.");
      break;
    case <= 10:
      Console.WriteLine("Light snow, still cold. Layer up.");
      break;
    default:
      Console.WriteLine("I dont believe you!");
      break;
  }

}


void Rain()
{
  switch (temperature)
  {
    case <= -30:
      Console.WriteLine("That's not rain, if you could feel you would know.");
      break;
    case <= -10:
      Console.WriteLine("Ice rain incoming. Waterproof everything and walk slowly.");
      break;
    case <= 0:
      Console.WriteLine("Cold rain. Waterproof coat and warm layers underneath.");
      break;
    case <= 10:
      Console.WriteLine("You must be in Bergen.");
      break;
    case <= 20:
      Console.WriteLine("This is the best condition to go for a run!");
      break;
    case <= 30:
      Console.WriteLine("Warm tropical rain. Refreshing but watch out for flash floods.");
      break;           
    default:
      Console.WriteLine("Dont worry you will dry up in seconds!");
      break;
  }
}


void Sun()
{
  switch (temperature)
  {
    case <= -30:
      Console.WriteLine("Sun is lying to you.");
      break;
    case <= -10:
      Console.WriteLine("Crisp and sunny. Coat, gloves, Maybe go Ski.");
      break;
    case <= 0:
      Console.WriteLine("Cold but pleasant. Jacket and maybe a scarf.");
      break;
    case <= 10:
      Console.WriteLine("Light jacket weather. Nice day!");
      break;
    case <= 20:
      Console.WriteLine("Sunscreen and shades! also can you send me your location?");
      break;
    case <= 30:
      Console.WriteLine("You have done well for yourself.");
      break;
    default:
      Console.WriteLine("Are you in Hell?");
      break;
  }
}

