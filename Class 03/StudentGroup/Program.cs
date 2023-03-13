// Task 2


string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Ana", "Maja", "Ivan", "Marko", "Igor" };

Console.WriteLine("Enter student group (1 or 2):");
int groupNumber = int.Parse(Console.ReadLine());

if (groupNumber == 1)
{
    Console.WriteLine("The students in G1 are:");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (groupNumber == 2)
{
    Console.WriteLine("The students in G2 are:");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid group number.");
}

Console.ReadLine(); 
        
    


