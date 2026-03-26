# WeatherAdvisor

## Kodehode: C# Basic Oppgave 1: Programflyt

A console app that gives weather advice based on temperature and condition (snow/rain/sun).
Either clothing advice or something funny based on the combination.

## Technology

- C# / .NET console application: 10.0 +

## How to Run

```
dotnet run
```

## Planning

Do While loop until user exits with "x".  
Switch statements for weather conditions and temperatures.  
Methods used for better readability.  
Error handling for invalid input.

- Snow, Rain and Sun each have their own method with temperature ranges and a default case.

## Test Values

| Condition | Values tested               |
| --------- | --------------------------- |
| Snow      | -35, -15, -5, 5, 15         |
| Rain      | -35, -15, -5, 5, 15, 25, 35 |
| Sun       | -35, -15, -5, 5, 15, 25, 35 |
