# Jokenpo Challenge

This is a repository with the solution for [this problemfrom DojoPuzzles](http://dojopuzzles.com/problemas/exibe/jokenpo/). My solution was made .Net Core 2.1.

## How to run

To run the tests:

1. Access JokenpoTests folder and after on your terminal use the following command:

```bash
dotnet test
```

## How I solved the problem

Jokenpo consist of a game that has at least 3 hand form and which one has it's own rule to win, tie or lose. For this I thought that I must have some way of validation. The validation I wanted was to make it more "generic" and easy to create. Each validation only works for that one had form. To do it, I made an Enum for Hand forms:

```csharp
public enum HandForm
{
        Rock,
        Paper,
        Scissor
}
```

Now the problem is: *How to validate the Enum? How the Enum will have it's own Rule?*

The way I thought of solving was: create an [extension for this enum](Jokenpo/HandForm.cs) that will return the [**Rule Class**](Jokenpo/Rules.cs)

Rule class will implement the [AbstractRule class](Jokenpo/AbstractRules.cs) that will contain an abstract method that returns the result of that play, this means that the Rule class will have the checks for that hand form against the opponent hand form.

```csharp
public abstract GameStatus WinAgainst(Position opponent);
```

Now the Judge of the Jokenpo will have only one line of code:

```csharp
public GameResult ValidateGame(Player player1, Player player2)
{
    return player1.HandForm.ToRule().WinAgainst(player2.HandForm);             
}
```

So, whenever someone call the [Judge class](Jokenpo/Judge.cs) to validate the game, it will only return the result of the game based on the first Player passed as Parameter. 
