using System;

namespace Utils
{
    public class Convert
    {
        public string Num_bin { set; get; }
        public int Num_dec { set; get; }

        public Convert()
        {
            this.Num_bin = "0";
            this.Num_dec = 0;
        }
        public Convert(int d) // : this()
        {
            this.Num_dec = d;
            this.Num_bin = ToBin(this.Num_dec);
        }
        public Convert(string b)
        {
            this.Num_bin = b;
            this.Num_dec = ToDec(this.Num_bin);
        }

        private int ToDec(string bin)
        {
            if (bin == "")
            {
                return 0;
            }
            else
            {
                int last = bin.Length - 1;
                return (bin[last] == '1'? 1: 0) + 2 * ToDec(bin.Substring(0,last));
            }
        }

        private string ToBin(int dec)
        {
            if (dec == 0)
            {
                return "0";
            }
            else
            {
                return ToBin(dec >> 1) + (dec & 1).ToString();
            }
        }
    }
}
