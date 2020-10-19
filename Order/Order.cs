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

            foreach (var word in text.Split(' '))
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
            return string.Join(" ", output).TrimEnd();
        }
    }
}
