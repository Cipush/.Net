// Exercise 3

Console.Write("Input the First Number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Input the Second Number: ");
int secondNumber = int.Parse(Console.ReadLine());

int temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);
