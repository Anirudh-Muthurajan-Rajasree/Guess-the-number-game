//Guess the number game in C#
// This program generates a random number between 1 and 100 and prompts the user to guess it. It then checks if the user's guess is correct and provides feedback accordingly.
//Created by Anirudh MR
//Creating the variable
int num1 = 0;
//Asking the user to guess the number
Console.WriteLine("Guess the number (hint its from 1 to 101)");
//Reading the user's input 
string anirudh = Console.ReadLine();
//Converting the user's input to an integer
int.TryParse(anirudh, out num1);
if  (num1 == new Random().Next(1, 101))//in case the user's guess is correct
{
    Console.WriteLine("You guessed the right number");
}
else
{
    //in case the user's guess is wrong
    Console.WriteLine("You guessed the wrong number kindly try again");
}
//Making sure that the console will not close immediately after the user guesses the number
Console.ReadKey();