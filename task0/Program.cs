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

string[] findLessThenThreeSimbols(string[] someArray , int j)
{
    string[] array = new string[j];
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i].Length <= 3)
        {
            for (int n = 0; n < j; n++)
            {
                array[n] = someArray[i];   
            }
        }
    }
    return array;
}

string[] array = { "hello", "2", "world", ";-)"};
int length = findLengthOfNewArray(array);
string[] result = findLessThenThreeSimbols(array, length);
foreach (var value in  result) {
    Console.Write(value + " ");
}
//Console.WriteLine(length);
