Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 1)
{
    Console.WriteLine("Not a prime number.");
    return;
}

bool isPrime = true;

for (int i = 2; i <= Math.Sqrt(num); i++)
{
    if (num % i == 0)
    {
        isPrime = false;
        break;
    }
}

if (isPrime)
    Console.WriteLine(num + " is a Prime Number");
else
    Console.WriteLine(num + " is NOT a Prime Number");