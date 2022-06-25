Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int min;
int max;

 if (num1 < num2)
 {
     min = num1;
     max = num2;
 }
 else
 {
     min = num2;
     max = num1;
}
Console.WriteLine("Минимальное число " + min);
Console.WriteLine("Максимальное число " + max);
