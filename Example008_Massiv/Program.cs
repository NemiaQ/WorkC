int[] array = { 9, 10, 0, 8, 5, 3, 1, 0 };
int find = 0;
int i = 0;
//int len = 8;
bool res = false;


while (i < array.Length)
{
    if (find == array[i])
    {
        Console.WriteLine($"Ура! Искомое значение {find} найдено в под индексом {i}!");
        res = true;
    }
    i++;
}

if (res == false) Console.WriteLine("Не нашлось :'(");