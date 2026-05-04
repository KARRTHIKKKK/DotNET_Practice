Random rand = new Random();
int target = rand.Next(1, 101);
int guess = 0;

Console.WriteLine("Guess a number between 1 and 100");

while (guess != target)
{
    Console.Write("Enter your guess: ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > target)
        Console.WriteLine("Too high!");
    else if (guess < target)
        Console.WriteLine("Too low!");
    else
        Console.WriteLine("Correct! You guessed it.");
}