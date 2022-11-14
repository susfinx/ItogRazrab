// See https://aka.ms/new-console-template for more information

Console.WriteLine("Zadayte dlinnu massiva!");
int DlnnaMassiva = Convert.ToInt32(Console.ReadLine());

string [] getarray1 (int DlnnaMassiva)
{
    string[] array1= new string [DlnnaMassiva];
    for (int i = 0; i < DlnnaMassiva; i++)
    {
        Console.WriteLine("vvedite strokovoe znachenie cherez (,) v covychkah ");
        array1[i] = Console.ReadLine();
    }

    return array1;
}

string [] array1 = getarray1 (DlnnaMassiva);
Console.WriteLine(array1);