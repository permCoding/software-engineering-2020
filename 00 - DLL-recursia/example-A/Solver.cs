using System;
using System.Linq;

namespace LibRec
{
    public class Solver
    {
        public static int BinToDec(string bin)
        {
            if (bin == "")
            {
                return 0;
            }
            else
            {
                return int.Parse(bin[0].ToString()) * (int)Math.Pow(2, bin.Length - 1) + BinToDec(bin.Substring(1));
            }
        }
        private static int ToInt(char ch)
        {
            return ch == '1' ? 1 : 0;
            //Convert.ToInt32(bin[0]) - 48;
        }
        public static int BinToDec_(string bin)
        {
            if (bin.Length == 1)
            {
                return ToInt(bin[0]);
            }
            else
            {
                return BinToDec_(bin.Substring(0, bin.Length - 1)) * 2 + ToInt(bin[bin.Length - 1]);
            }
        }
        public static string GetReverseString(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
        public static int BinToDec__(string bin)
        {
            if (bin.Length == 0)
            {
                return 0;
            }
            else
            {
                return ToInt(bin[0]) + 2 * BinToDec__(bin.Substring(1));
            }
        }
    }
}
