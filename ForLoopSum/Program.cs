

int sum = 0;

for(int i = 1; i < 11; i++) //i-- = i - 1
{
    Console.WriteLine($"i = {i + 1}");
    Console.WriteLine($"Current toal: {sum}");
    sum = sum + i; //sum += i;
}

Console.WriteLine($"Final total {sum}");