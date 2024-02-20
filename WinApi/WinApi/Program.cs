using System.Runtime.CompilerServices;


unsafe
{
    int num = 5;
    int* ptr = &num;

    Console.WriteLine(ptr->ToString());
}



