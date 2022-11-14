// See https://aka.ms/new-console-template for more information

string [] getarray1 (int DlnnaMassiva)
{
    string[] array1= new string [DlnnaMassiva];
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine("vvedite strokovoe znachenie");
        array1[i] = Console.ReadLine();
    }

    return array1;
}

string [] getarray2 (string [] array1)
{
    
    string [] array2 = new string [array1.Length];
    int j =0;
    int k = 3;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=k)
        {
            array2[j]=array1[i];
            j++;
        }
    } 

    return array2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}

Console.WriteLine("Zadayte dlinnu massiva!");
int DlnnaMassiva = Convert.ToInt32(Console.ReadLine());
string [] array1 = getarray1 (DlnnaMassiva);
string [] array2 = getarray2 (array1);
Console.WriteLine();
Console.WriteLine ("Vvedenyi Massiv");
PrintArray (array1);
Console.WriteLine();
Console.WriteLine("massiv po usloviyam zadachi");
PrintArray (array2);