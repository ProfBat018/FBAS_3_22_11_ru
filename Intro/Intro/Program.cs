#region OldVariant
// namespace Intro
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             foreach (var item in args)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
#endregion

#region Output

// Console.WriteLine("Salam");
// Console.WriteLine("Aleykum");

// Console.Write("Hakuna");
// Console.Write("Matata");

#endregion

#region Ref&Out

// void ChangeByRef(ref int num)
// {
//     num = 5;
// }
//
// void ChangeByOut(out int num)
// {
//     num = 10;
// }

// int number = 1;
// ChangeByRef(ref number);
// Console.WriteLine(number);


// int number;
// ChangeByOut(out number);
// Console.WriteLine(number);


#endregion

#region Input

// Console.WriteLine("Enter first number: ");
// int firstNumber = Int32.Parse(Console.ReadLine());
//
// Console.WriteLine("Enter second number: ");
// int secondNumber = Int32.Parse(Console.ReadLine());
//
// Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

// try
// {
    // Console.WriteLine("Enter first number: ");
    // int firstNumber = Int32.Parse(Console.ReadLine());

    // Console.WriteLine("Enter second number: ");
    // int secondNumber = Int32.Parse(Console.ReadLine());

    // Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
// }
// catch (Exception ex)
// {
    // Console.WriteLine(ex.Message);
// }

// int num1, num2;
//
// Console.WriteLine("Enter first number: ");
// bool firstRes = Int32.TryParse(Console.ReadLine(), out num1);
//
// Console.WriteLine("Enter second number: ");
// bool secondRes = Int32.TryParse(Console.ReadLine(), out num2);
//
// if (firstRes && secondRes)
// {
//     Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
// }

#endregion

#region Arrays

// int[] numbers = new int[5];
// Console.WriteLine(numbers[0]);
//
// int[][] jaggedArray = new int[2][]
// {
//     new int[2] {1, 2},
//     new int[3] {3, 4, 5}
// };
//
// int[,] twoDimensionalArray = new int[2, 3]
// {
//     {1, 2, 3},
//     {4, 5, 6}
// };

#endregion


string name = "Elvin. Azimov";

Console.WriteLine(name.IndexOf("."));
name = name.Replace(".", " ");

Console.WriteLine(name);
