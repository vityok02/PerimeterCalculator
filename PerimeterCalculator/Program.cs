Console.WriteLine("===Hello, welcome to the polygon perimeter calculator===");

while (true)
{
    Console.WriteLine("Enter count of sides");

    int count = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine($"Enter the number {i}");
        int number = Convert.ToInt32(Console.ReadLine());
        sum += number;
    }

    Console.WriteLine(sum);

    Console.ReadKey();
}