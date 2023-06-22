Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0){
    Console.WriteLine($"{n} - четное");
}else{
    Console.WriteLine($"{n} - не является четным");
}