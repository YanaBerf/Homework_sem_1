Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
// int i = 2;
//while (i <= n ){
   
   // Console.Write($"{i}");
    //i = i + 2;//}
for (i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
    Console.Write($"{i+","}");
    }
 }








