// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt()
{
    Console.Write("Введите количество чисел: ");
    int limit =int.Parse(Console.ReadLine());
    return limit;
}

int[] Input(int[] number)
{
    for(int i=0; i<number.Length; i++)
    {
        number[i]=int.Parse(Console.ReadLine());
    }
    return number;
}
void Find(int[] number)
{
    int kolichestvo=0;
    for(int i=0; i<number.Length; i++)
    {
        if(number[i]>0)
            kolichestvo++;
    }
    Console.Write($"Количество чисел больше 0: {kolichestvo}");
}
int count=Prompt();
int[] number=new int[count];
Console.WriteLine("Введите числа");
number=Input(number);
Find(number);