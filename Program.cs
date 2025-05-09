// ✅ Guessing Game
int computerNumber = 69; 
int usersGuess = 0; 
int counter = 0; 

Console.WriteLine("Guess what number the computer is thinking of between 1-69:");
usersGuess = int.Parse(Console.ReadLine());

while (usersGuess != computerNumber)
{
    if (usersGuess < computerNumber)
        Console.WriteLine("Your number was too low\n");
    else
        Console.WriteLine("Your number was too high");

    Console.WriteLine("Sorry, guess again");
    counter++;
    Console.WriteLine($"That was your {counter} guess");
    usersGuess = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Yes you got it!! Hurrah, you guessed in {counter} tries.");

// ✅ Simple Quiz
string question1 = "Capital of England?";
string answer1 = "London";
string question2 = "Best cocktail in the world";
string answer2 = "Last word";
string userAnswer;
int score = 0;

Console.WriteLine(question1);
userAnswer = Console.ReadLine();
if (userAnswer == answer1) { Console.WriteLine("Correct!"); score++; } else { Console.WriteLine("Wrong"); }

Console.WriteLine(question2);
userAnswer = Console.ReadLine();
if (userAnswer == answer2) { Console.WriteLine("Yes mate!"); score++; } else { Console.WriteLine("Sorry mate"); }

Console.WriteLine($"Final score: {score}/2");

// ✅ Rocket Countdown
string rocket = "   /\\\n  /  \\\n /____\\\n |    |\n |    |\n |____|\n  /  \\\n  ||||\n  ||||";
for (int count = 10; count >= 0; count--)
{
    Console.Clear();
    Console.WriteLine("Counter is " + count);
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}

// ✅ Basic Calculator
Console.WriteLine("Enter the first number:");
int userFirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int userSecondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Choose an operation: +, -, *, /");
string operation = Console.ReadLine();

if (operation == "+")
    Console.WriteLine($"Result: {userFirstNumber + userSecondNumber}");
else if (operation == "-")
    Console.WriteLine($"Result: {userFirstNumber - userSecondNumber}");
else if (operation == "*")
    Console.WriteLine($"Result: {userFirstNumber * userSecondNumber}");
else if (operation == "/")
{
    try { Console.WriteLine($"Result: {userFirstNumber / userSecondNumber}"); }
    catch (DivideByZeroException) { Console.WriteLine("Cannot divide by zero"); }
}
else Console.WriteLine("Invalid operation.");

// ✅ Top-Level Prize Eligibility Check
Console.WriteLine("Please enter a whole number");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber == 0)
{
    Console.WriteLine("Same number! Prize check starting...");
    Console.WriteLine("How old are you?");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("You’re old enough. Enter your address:");
        string address = Console.ReadLine();
        Console.WriteLine($"Prize sent to {address}");
    }
    else Console.WriteLine("Too young for a prize.");
}
else Console.WriteLine("Wrong number — no prize.");

// ✅ 2D Array Row Sum
int[,] numbers = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
for (int row = 0; row < numbers.GetLength(0); row++)
{
    int rowSum = 0;
    for (int col = 0; col < numbers.GetLength(1); col++)
        rowSum += numbers[row, col];
    Console.WriteLine($"Sum of row {row + 1}: {rowSum}");
}

// ✅ Adventure Game
Console.WriteLine("Welcome to NIGHT OUT ADVENTURE!");
Console.WriteLine("What is your character's name?");
string characterName = Console.ReadLine();
Console.WriteLine($"{characterName}, you're on a night out...");
Console.WriteLine("Do you FIGHT or FLEE?");
string choice = Console.ReadLine();

if (choice == "flee")
    Console.WriteLine("You walk away wisely. THE END.");
else if (choice == "fight")
{
    Console.WriteLine("Prepare for battle...");
    Thread.Sleep(1000);
    Console.WriteLine("(ง •̀_•́)ง Let's go!");
    Thread.Sleep(1000);
    Random rng = new Random();
    int outcome = rng.Next(1, 11);
    if (outcome > 5)
        Console.WriteLine("You KO’d the guy! What a night!");
    else
        Console.WriteLine("You got knocked out. Oops.");
}

// ✅ Static Method Sample (for structure comparison)
namespace Oldstyle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World from classic Main()");
        }
    }
}
