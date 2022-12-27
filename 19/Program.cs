Console.Clear();

Console.WriteLine("Введите число");
int num, temp, reverse = 0, rem;
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while(num > 0)
{
    rem = num % 10;
    reverse = reverse * 10 + rem;
    num = num / 10;
}
if(reverse==temp)
Console.WriteLine("palindrome");
else
Console.WriteLine("no palindrome");