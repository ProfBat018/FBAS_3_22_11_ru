#region Part1

// float Addition(int num1, int num2)
// {
//     Console.WriteLine("Addition");
//     return num1 + num2;
// }
//
// float Subtraction(int num1, int num2)
// {
//     Console.WriteLine("Subtraction");
//     return num1 - num2;
// }
//
// float Multiplication(int num1, int num2)
// {
//     Console.WriteLine("Multiplication");
//     return num1 * num2;
// }
//
// float Division(int num1, int num2)
// {
//     Console.WriteLine("Division");
//     return num1 / num2;
// }
//
// MathDelegate mathDelegate = Addition;
// mathDelegate += Subtraction;
// mathDelegate += Multiplication;
// mathDelegate += Division;
//
// Console.WriteLine(mathDelegate(10, 5));
//

#endregion


#region Part2

using MulticastDelegate;

var taxService = new TaxService();

taxService.CalculateTax(3000);

#endregion


