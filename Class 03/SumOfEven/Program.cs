// Task 1


int[] numbers = { 4, 3, 7, 3, 2, 8 };
int sumOfEven = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }
}

Console.WriteLine("The result is: " + sumOfEven);
Console.ReadLine();