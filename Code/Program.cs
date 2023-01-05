int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введите размер массива: ");
string [] mas1= new string[size];
string [] mas2= new string[mas1.Length];

for (int i=0; i < mas1.Length; i++)
{
    string x = Console.ReadLine();
    mas1[i]= x; 
}
Console.WriteLine();



void SecondMas(string [] array1,string [] array2)
{
    int count = 0;
    for (int j=0; j<array1.Length;j++)
    {
        if (array1[j].Length<=3)
        {
            array2[count]=array1[j];
            count++;
        }
    }
}

void Print(string[]array)
{
    for (int z = 0;z< array.Length;z++)
    {
        Console.Write($"{array[z]} ");
    }
    Console.WriteLine();
}

SecondMas(mas1,mas2);
Print(mas1);
Print(mas2);