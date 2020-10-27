using System;
using System.Linq;

namespace SpinWordsKata
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            return string.Join(' ', sentence.Split(' ').Select(x => x.Count() >= 5 ? new string(x.Reverse().ToArray()) : x).ToArray());
        }
    }
}
