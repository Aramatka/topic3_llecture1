// На вход  число, на выход значения в промежутке от -Н до Н
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);

}
int negativeNumber = number * (-1);
while (negativeNumber <= number)
{
    System.Console.Write(negativeNumber + ", ");
    negativeNumber++;
}
