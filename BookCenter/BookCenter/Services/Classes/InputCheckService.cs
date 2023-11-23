using BookCenter.ViewModels;
using System.Text.RegularExpressions;
using System;
using System.Windows;

namespace BookCenter.Services;

internal class InputCheckService
{
    private static Regex yearRegex = new("(0[1-9]|1[0-2])/([0-9][0-9])");
    private static Regex cvvRegex = new("([0-9]{3})");
    public static bool CheckAll(CardModel card)
    {
        MessageBox.Show(card.CardNum + " " + card.CVV + " " + card.Year);

        bool res1 = IsCardNumValid(card.CardNum);
        bool res2 = IsCVVvalid(card.CVV);
        bool res3 = IsYearValid(card.Year);


        return res1 && res2 && res2         ;
    }

    private static bool IsCardNumValid(string CardNum)
    {
        return CardNum.Length == 19;
    }
    private static bool IsCVVvalid(string CVV)
    {
        if (CVV == null) return false;
        return cvvRegex.IsMatch(CVV);
    }

    private static bool IsYearValid(string Year)
    {
        if (Year == null) return false;

        return true;
        //if (yearRegex.IsMatch(Year))
        //{
        //    if (Year.Substring(3) == (DateTime.Now.Year % 100).ToString())
        //    {
        //        if (Convert.ToInt32(Year.Substring(0, 2)) > DateTime.Now.Month)
        //        {
        //            return true;
        //        }
        //    }
        //    else if (Convert.ToInt32(Year.Substring(3)) > (DateTime.Now.Year % 100))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //return false;
    }
}