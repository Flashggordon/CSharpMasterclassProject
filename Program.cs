//  https://aka.ms/new-console-template for more information




// int num1 = 0;
// int clientAge = 0;


// Console.WriteLine("Please enter a whole number");

// int userNumber = int.Parse(Console.ReadLine());

// if (userNumber == num1){
//     Console.WriteLine("SAME NUMBER YEEEEEESSSS you get a prize if you over 18");
// }
// else
//  {
//     Console.WriteLine("Your numbers were not the so no prize ");
// return; 
// }

// Console.WriteLine("How old are you?");
//  clientAge = int.Parse(Console.ReadLine());

// if (clientAge >= 18)
// {
//     Console.WriteLine("Your old enought for a prize  please enter your address: ");
// }

// else
//  {
//     Console.WriteLine("Too young for a prize"); 
//     return; 
// }
// Console.WriteLine("Input me your address so i can send you your prize ");
// string address = "";
// address = (Console.ReadLine());
// Console.WriteLine($"Prize sent to {address}");




// switch (month) 
// {
//     case 1: 
//         monthName = "January";
//         break; 
//         case 2: 
//             monthName = "Febuary"; 
//             break; 
//             case 3: 
//                 monthName: "March"; 
//                 break; 
//                 default:
//                 monthName: "Unknown"; 
// }



// string question1 = "Caplital of england?";
// string answer1 = "London";
// string question2 = "Best cocktail in the world";
// string answer2 = "Last word"; 
// string userAnswer = "";
// string userAnswer2 = ""; 
// int score = 0; 

// Console.WriteLine(question1);

//  userAnswer = Console.ReadLine();
// if (userAnswer == answer1){
//     Console.WriteLine("You are correct"); 
//     score = score + 1;  
// }
// else {
//     Console.WriteLine("Wrong answer");
// }
// Console.WriteLine(question2);
// userAnswer2 = Console.ReadLine();
// if (userAnswer2 == answer2){
//     Console.WriteLine("Yes Mate");
//         score = score + 1;  

// }

// else {
//     Console.WriteLine("Sorry mate");
// }
// Console.WriteLine($"Your final score is {score}/2");

// using System.Formats.Asn1;
// using System.Runtime.Intrinsics.Arm;


// int userFirstNumber = 0; 
// int userSecondNumber = 0; 






//             Console.WriteLine("Enter the first number:");
//              userFirstNumber = int.Parse(Console.ReadLine());

//              Console.WriteLine("Enter the second number:");
//              userSecondNumber = int.Parse(Console.ReadLine());



//             Console.WriteLine("Choose an operation: +, -, *, /");
//             string userArithmetic = Console.ReadLine();



//             if (userArithmetic == "+" )
//             {
//                 int addNumbers = userFirstNumber + userSecondNumber; 
//            System.Console.WriteLine($"Your two number added up to {addNumbers} "); 

//             }

//             else if (userArithmetic == "-" )
//             {
//                          int subtractNumbers = userFirstNumber - userSecondNumber; 
//          System.Console.WriteLine($"Your two number subtracted to {subtractNumbers} ");
//              }


//            else if (userArithmetic == "*" )
//            {
//                         int multiplyNumbers = userFirstNumber * userSecondNumber; 
//            System.Console.WriteLine($"Your two number multiplied to {multiplyNumbers}");
//            }


//          else if (userArithmetic == "/" ) {
//           try
//           {
//             int divideNumbers = userFirstNumber / userSecondNumber; 
//               System.Console.WriteLine($"Your two number divide to {divideNumbers}");
//           }  
//           catch (DivideByZeroException)
//           {
//             System.Console.WriteLine("Error: Division by zero is not allowed.");
//           }
//          }
//           else 
//            {
//              System.Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
//             };



// string rocket = "   /\\\n  /  \\\n /____\\\n |    |\n |    |\n |____|\n  /  \\\n  ||||\n  ||||";

//       for (int count = 10; count >= 0; count--){
//                Console.Clear(); 
//         System.Console.WriteLine("Counter is " + count);
//  System.Console.WriteLine(rocket);
//         rocket = "\r\n" + rocket;
//         Thread.Sleep(1000); 

//       }

// using System.Runtime.Intrinsics.Arm;


// System.Console.WriteLine("Taxi driver askes do you want to go or wait");
// // System.Console.ReadLine();
// string userChoice = Console.ReadLine(); 

// while (userChoice == "Go")
//  {
// System.Console.WriteLine("ok i will keep going..");
// System.Console.WriteLine("you sure to keep going???");
// userChoice = Console.ReadLine(); 
// };


// System.Console.WriteLine("Taxi driver askes do you want to go or wait");
// string userChoice = Console.ReadLine(); 

// while (userChoice == "Go")
// {
//     System.Console.WriteLine("ok i will keep going..");
//     System.Console.WriteLine("you sure to keep going???");
//     userChoice = Console.ReadLine(); 
// };


// using System.Linq.Expressions;
// using System.Net;

// int computerNumber = 69; 
// int usersGuess = 0; 
// int counter = 0; 

// System.Console.WriteLine("Guess what number the computer is thinking of between 1-69:");
// usersGuess = int.Parse(Console.ReadLine());


// while (usersGuess != computerNumber ){

//     if (usersGuess < computerNumber)
//     {
//         System.Console.WriteLine("your number was too low \r\n");
//     }
//     else if (usersGuess > computerNumber)
//     {
//         System.Console.WriteLine("your number was too high");
//     }  
// System.Console.WriteLine("sorry you will have to guess again");
// counter ++; 
// System.Console.WriteLine($"That was your {counter} guess");

// usersGuess = int.Parse(Console.ReadLine());


// }
// System.Console.WriteLine($"Yes you got it!! huraay you guessed {counter} times");







using System.Linq.Expressions;

System.Console.WriteLine("Welcome to NIGHT OUT ADVENTURE!\r\n");

System.Console.WriteLine("What is your character's name");
string characterName = Console.ReadLine();

System.Console.WriteLine($" {characterName}, you're on a night out. Everything’s great until someone chats up your girlfriend.");
System.Console.WriteLine("Do you choose to FIGHT or FLEE? (Type: fight / flee)");
string usersChoise = Console.ReadLine(); 


if (usersChoise == "flee")
{
System.Console.WriteLine("You wisely walk away. Your girlfriend smiles at your maturity.You both head home and watch Netflix in peace.  THE END.");
}

else if (usersChoise == "fight")
{
    System.Console.WriteLine("You step up to fight! Prepare yourself...");

  System.Console.WriteLine("Fight begins in ... 3");
System.Threading.Thread.Sleep(1000);

System.Console.WriteLine("Fight begins in ... 2");
System.Threading.Thread.Sleep(1000);

System.Console.WriteLine("Fight begins in ... 1");
System.Threading.Thread.Sleep(1000);


System.Console.WriteLine( "(ง •̀_•́)ง" + "Lets do this\r\n");
System.Threading.Thread.Sleep(1000);

System.Console.WriteLine("(ง •̀_•́)ง" +  "You're going down!\r\n");
System.Threading.Thread.Sleep(1000);

System.Console.WriteLine("(╯°□°）╯︵ ┻━┻" + "POW\r\n");
System.Threading.Thread.Sleep(1000);

System.Console.WriteLine(" ᕦ(ò_óˇ)ᕤ " + "SMASH");
System.Threading.Thread.Sleep(1000);


Random randomNumber = new Random();
int luck = randomNumber.Next(1, 11);

if (luck > 5)
{
  System.Console.WriteLine($"You KO’d the guy! Your girlfriend swoons.\r\nWell done {characterName}.\r\nYou and your girlfriend find a Delirium Tremens beer on the floor.\r\nYou drink it. It's weirdly cold... but amazing.\r\nThe night becomes a blur of dancing, laughter, and kebabs.\r\nWhat a night!\r\nTHE END.");

}


    else 
    {
        System.Console.WriteLine($"You got knocked out cold, {characterName} \r\n Maybe next time don't pick fights in nightclubs.");
        
    }


}


