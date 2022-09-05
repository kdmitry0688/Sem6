// ЗАДАЧА.
// СОздать массив и развернуть его разными методами

int[] FillingArray(int lengthArray)
{
    System.Random numberGenerator = new System.Random();
    int i = 0;
    int[] outArray = new int[lengthArray];
    while (i < lengthArray)
    {
        outArray[i] = numberGenerator.Next(1, 100);
        i++;
    }
    return outArray;
}

void Print1DArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

int[] ReversNewArray(int[] inputArray)
{
    int[] outArray = new int[inputArray.Length];
    int i = 0;
    while (i < inputArray.Length)
    {
        outArray[inputArray.Length - 1 - i] = inputArray[i];
        i++;
    }
    return outArray;
}

int[] ReversSwapArray(int[] inputArray)
{
    int swapElement = 0;
    for (int i = 0; i < inputArray.Length / 2; i++)
    {
       swapElement = inputArray[i];
       inputArray[i] = inputArray[inputArray.Length-1-i];
       inputArray[inputArray.Length-1-i] = swapElement;
    }
    return inputArray;
}


int[] array = FillingArray(15);
Print1DArray(array);
//int[] bufArray = ReversNewArray(array)
Print1DArray(ReversNewArray(array));
Print1DArray(ReversSwapArray(array));
