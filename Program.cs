// Написать программу, которая из имеющегося массива строк 
// формирует массив из cтрок, длина которых 
// меньше либо равна 3 символа.


string[] inputArray = new string[6] {"1", "22", ":-)", "work", "hello", "Dmitriy"};
string[] outputArray = new string[inputArray.Length];
void DmitriyArray(string[] inputArray, string[] outputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; 
    i = i + 1)
    {
    if(inputArray[i].Length <= 3)
        {
        outputArray[count] = inputArray[i];
        count = count + 1;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
DmitriyArray(inputArray, outputArray);
PrintArray(outputArray);