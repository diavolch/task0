/*
Программа, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3.
*/

int findLengthOfNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}
string[] findLessThenThreeSimbols(string[] someArray, int j)
{
    string[] array = new string[j];
    int n = 0;
        for (int i = 0; i < someArray.Length; i++)
        {
            if (someArray[i].Length <= 3)
            {
                array[n] = someArray[i];
                Console.WriteLine(n + " " + someArray[i]);
                n++;
            }
        }
    return array;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] array = { "hello", "2", "world", ";-)" };
int length = findLengthOfNewArray(array);
string[] result = findLessThenThreeSimbols(array, length);
printArray(result);
