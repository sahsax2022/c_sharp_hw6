//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CrArray(int size)
{
    int[] NewArray = new int[size];
    return NewArray;
}

int[] EnterArrayElements(int[] thisArray) 
{  
    Console.WriteLine($"Please, input {thisArray.Length} numbers: "); 
    for(int i = 0; i < thisArray.Length ; i++)        
        thisArray[i] = Convert.ToInt32(Console.ReadLine());
    
    return thisArray;
}

void ShowArraysSumPositiveElements(int[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.Write(thisArray[i]);
        if(i < thisArray.Length - 1 )
            Console.Write(", ");    
    }

    int EvenNumbers = 0;

    for(int i = 0; i < thisArray.Length ; i++)
    {
        if(thisArray[i] > 0)
        EvenNumbers++;        
    }
     if(EvenNumbers > 0)
        Console.Write($"-> {EvenNumbers}");
}

Console.WriteLine("You must input M numbers, first of all input M: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowArraysSumPositiveElements(MyArray);

