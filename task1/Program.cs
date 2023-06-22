Console.Clear();
Console.Write("Введите трехзначное число a: ");
int a = int.Parse(Console.ReadLine());
int b = a % 10;
Console.WriteLine(b);