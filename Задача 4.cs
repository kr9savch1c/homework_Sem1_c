Console.Write("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");

int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write(a > c ?"max= " + a : "max= " + c);
}
else
{
    Console.Write(b > c ? "max= " + b : "max= " + c);
}