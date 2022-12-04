string[] firstArray = new string[] { "hello", "2", "World", ":-)", "1234", "GeekBrains", "edu" };
int n = 3;

int secondLenght = GetNumberSample(firstArray, n);

string[] resultArray = GetResult(firstArray, n, secondLenght);

Console.WriteLine($"[{string.Join(", ", firstArray)}] -> [{string.Join(", ", resultArray)}]");


//--------

int GetNumberSample(string[] firstArray, int lenghtString)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= lenghtString)
            count++;
    }
    return count;
}


string[] GetResult(string[] firstArray, int lenghtString, int secondLenght)
{
    string[] resultArr = new string[secondLenght];
    int i = 0;
    for (int j = 0; j < firstArray.Length; j++)
    {
        if (firstArray[j].Length <= lenghtString)
        {
            resultArr[i] = firstArray[j];
            i++;
        }
    }
    return resultArr;
}
