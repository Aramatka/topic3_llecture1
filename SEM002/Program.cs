// программа, которая на вход принимает два числа и проверяет является ли первое квадратом второго
System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber*secondNumber)
{
    System.Console.WriteLine(firstNumber + " является к вадратом от " + secondNumber);
}
else
{
    System.Console.WriteLine(firstNumber + " не является к вадратом от " + secondNumber);
}