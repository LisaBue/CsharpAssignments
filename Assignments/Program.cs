int a = 5;
int b = 3;
if (a + b > 10)
{
    Console.WriteLine("The answer is greater than 10.");
}

else
{
    Console.WriteLine("The answer is smaller than 10.");
}

int c = 5;
int d = 6;
int e = 4;
if ((c + d + e > 10) && (c == d))
{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second.");
}
else
{
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second.");
}

int f = 3;
int g = 9;
int h = 2;
if ((f + g + h < 12) || (f > h))
{
    Console.WriteLine("The answer is smaller than 12.");
    Console.WriteLine("Or the first number is greater than the last number.");
}

else
{
    Console.WriteLine("The answer is not smaller than 12.");
    Console.WriteLine("Or the first number is not greater than the last nubmer.");
}

int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}

Console.WriteLine($"Let's do it again!");

int counter2 = 0;
do
{
    Console.WriteLine($"Hello world! The counter is {counter2}");
    counter2++;
} while (counter2 < 10);

Console.WriteLine($"And again :')");

for (int counter3 = 0; counter3 < 10; counter3++)
{
    Console.WriteLine($"Hello World! The counter is {counter3}");
}

Console.WriteLine($"Can't get enough :)");

for (int counter4 = 0; counter4 < 5; counter4++)
{
    Console.WriteLine($"Hey! The counter is {counter4}");
}

Console.WriteLine($"Let's play something else");

for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}

Console.WriteLine($"and some other thing");

for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"Hey! The column is {column}");
}

Console.WriteLine($"Something else...");

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"Hey! The cell is ({row}, {column})");
    }
}

Console.WriteLine($"New assignment");

int sum = 0;
for (int getal = 1; getal < 21; getal++)
{
    if (getal % 3 == 0)
    {
        sum = sum + getal;
    }
    else
    {
        Console.WriteLine($"The sum is {sum}");
    }
}
