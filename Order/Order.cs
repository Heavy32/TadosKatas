using System;
using System.Linq;

namespace Order
{
    public class Order
    {
        static public string OrderText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            string[] output = new string[9];

            var words = text.Split(' ');

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (char.IsDigit(c))
                    {
                        int position = (int)Char.GetNumericValue(c);
                        output[position - 1] = word;
                    }
                    continue;
                }
            }
            return MakeStringFromArray(output);
        }

        static private string MakeStringFromArray(string[] arr)
        {
            string str = "";

            foreach (var item in arr.Where(w => w != null))
            {
                str += item + ' ';
            }

            return str.Remove(str.Length - 1);
        }
    }
}
