Console.Write("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write("Число: " + a + " четное");
}
else
{
    Console.Write("Число: " + a + " нечетное");
}