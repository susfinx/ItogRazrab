// See https://aka.ms/new-console-template for more information

Console.WriteLine("Zadayte dlinnu massiva!");
int DlnnaMassiva = Convert.ToInt32(Console.ReadLine());

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

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
 }

string [] array1 = getarray1 (DlnnaMassiva);
Console.WriteLine ("Vvedenyi Massiv");
PrintArray (array1);
Console.WriteLine("massiv po usloviyam zadachi");