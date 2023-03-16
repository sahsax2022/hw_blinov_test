// HW Итоги блока. Выбор специализации. IT-специалист
//Программа, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна 3 символов

string[] CrArray(int size)
{
    string[] NewArray = new string[size];
    return NewArray;
}

string[] EnterArrayElements(string[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.WriteLine($"Input {i + 1} array element: "); 
        thisArray[i] = Convert.ToString(Console.ReadLine());
    }
    return thisArray;
}

void ShowArrayLes3LengthElements(string[] thisArray, string[] thisArray2) 
{  
    int len = 3;
    int iter = 0;
    for(int i = 0; i < thisArray.Length ; i++)
    {
        if(thisArray[i].Length <= len)
        {
            thisArray2[iter] = thisArray[i];
            iter++; 
        }          
    }

    //Красиво выведем массив
    Console.Write("[");
    for(int i = 0; i < thisArray2.Length ; i++)
    {
        if(thisArray2[i] != null)
        {
            if(i != 0)
                Console.Write(", ");
            Console.Write(thisArray2[i]);                 
        } 
    }
    Console.Write("]");    
}

Console.WriteLine("Input array size: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
string[] MyArray = CrArray(ArSize);
string[] MyArray2 = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowArrayLes3LengthElements(MyArray, MyArray2);
