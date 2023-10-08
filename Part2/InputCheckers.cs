using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part2
{
    class InputCheckers
    {
        private static Regex nsRegex = new("[A-Za-z]"); 
        
        private static string[] extensions = { ".png", ".jpg", ".jpeg", ".jfif" }; 

        public static bool CheckAll(Person person)
        {
            return IsNameSurnameValid(person.Name, person.Surname) && IsBirthDateValid(person.BirthDate) && IsPicturePathValid(person.ImagePath);
        }

        private static bool IsNameSurnameValid(string name, string surname)
        {
            return nsRegex.IsMatch(name) && nsRegex.IsMatch(surname);
        }
        private static bool IsBirthDateValid(DateTime birthDate)
        {
            return birthDate <= DateTime.Now;
        }

        private static bool IsPicturePathValid(string picturePath)
        {
            return extensions.Contains(picturePath.Substring(picturePath.LastIndexOf('.')));
        }   
    }
}
