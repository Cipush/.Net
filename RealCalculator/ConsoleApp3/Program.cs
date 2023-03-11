
    // Exercise 1

      double num1, num2;

      Console.Write("Enter the first number: ");
      num1 = double.Parse(Console.ReadLine());

      Console.Write("Enter the second number: ");
      num2 = double.Parse(Console.ReadLine());

      Console.Write("Enter the operation (+, -, *, /): ");
      string operation = Console.ReadLine();

      double result = 0;

      switch (operation)
         {
            case "+":
             result = num1 + num2;

               break;

            case "-":
            result = num1 - num2;

               break;

            case "*":
            result = num1 * num2;

               break;

            case "/":
            result = num1 / num2;

               break;

                default:
                    Console.WriteLine("Invalid operation selected.");

                    break;
            }

            Console.WriteLine($"The result of the operation is {result}");

