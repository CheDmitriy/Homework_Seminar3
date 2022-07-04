/*int PalNumber(int n) // Задача №19
{
    int num1 = n / 10000;
    int num2 = n % 10;

    int num3 = n / 1000;
    int num4 = num3 % 10;

    int num5 = n % 100;
    int num6 = num5 / 10;

    if(num1 == num2 && num4 == num6) Console.WriteLine("Yes");
    else Console.WriteLine("No");
    return n;

    
}

Console.WriteLine("Введите пятизначное число : ");
int n = Convert.ToInt32(Console.ReadLine());

int num = PalNumber(n);*/


void Quad(int x)               // Задача №23
{
    int current = 1;
    while (current <= x)
    {
        int quad = current * current * current;
        Console.WriteLine(quad + " ");
        current++;
    }
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Quad(n);