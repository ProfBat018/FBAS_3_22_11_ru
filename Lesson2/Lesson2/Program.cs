// // /*
// // using System.Globalization;
// //
// // Person p1 = new()
// // {
// //     BirthDate = DateTime.ParseExact("16/11/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture),
// //     Name = "Elvin",
// //     Surname = "Azimov"
// // };
// //
// // Console.WriteLine(p1.BirthDate.DayOfWeek);
// //
// // class Person
// // {
// //     public string Name { get; set; }
// //     public string Surname { get; set; }
// //     public DateTime BirthDate { get; init; }
// //
// //     public int Age
// //     {
// //         get
// //         {
// //             if (DateTime.Now.Month < BirthDate.Month)
// //                 return DateTime.Now.Year - BirthDate.Year - 1;
// //             else if (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)
// //                 return DateTime.Now.Year - BirthDate.Year - 1;
// //             else
// //                 return DateTime.Now.Year - BirthDate.Year;                
// //         }
// //     }
// // }
// // */
// //
// // class Fraction
// // {
// //     private int _numerator;
// //     private int _denominator;
// //
// //     public Fraction(int numerator, int denominator)
// //     {
// //         _numerator = numerator;
// //         _denominator = denominator;
// //     }
// //     
// //     // overloading of operator +
// //     public static Fraction operator +(Fraction f1, Fraction f2)
// //     {
// //         int numerator = f1._numerator * f2._denominator + f2._numerator * f1._denominator;
// //         int denominator = f1._denominator * f2._denominator;
// //         return new Fraction(numerator, denominator);
// //     }
// //     
// //     // overloading of operator -
// //     public static Fraction operator -(Fraction f1, Fraction f2)
// //     {
// //         int numerator = f1._numerator * f2._denominator - f2._numerator * f1._denominator;
// //         int denominator = f1._denominator * f2._denominator;
// //         return new Fraction(numerator, denominator);
// //     }
// //     
// //     // overloading of operator >
// //     public static bool operator >(Fraction f1, Fraction f2)
// //     {
// //         return f1._numerator * f2._denominator > f2._numerator * f1._denominator;
// //     }
// //     
// //     // overloading of operator <
// //     public static bool operator <(Fraction f1, Fraction f2)
// //     {
// //         return f1._numerator * f2._denominator < f2._numerator * f1._denominator;
// //     }
// // }
// //
// //
//
//
// Person p1 = new()
// {
//     Name = "Elvin",
//     Surname = "Azimov"
// };
//
// Console.WriteLine(p1);
//
// class Person
// {
//     public string Name { get; set; }
//     public string Surname { get; set; }
//
//     public override string ToString()
//     {
//         return $"{Name} {Surname}";
//     }
// }



