using System;
using System.Linq;

namespace SmallFuck
{
    public class Kata
    {
        static public string Interpreter(string code, string tape)
        {
            int position = 0;

            var way = tape.ToArray();

            try
            {
                for (int i = 0; i < code.Length; i++)
                {
                    switch (code[i])
                    {
                        case '>':
                            if (position < way.Length)
                            {
                                position++;
                            }
                            else
                            {
                                return new string(way);
                            }

                            break;

                        case '<':
                            if (position <= 0)
                            {
                                return new string(way);
                            }
                            else
                            {
                                position--;
                            }

                            break;

                        case '*':
                            way[position] = way[position] == '1' ? '0' : '1';
                            break;

                        case '[':
                            if (way[position] == '0')
                            {
                                while (code[i] != ']')
                                {
                                    i++;
                                    if (i == code.Length)
                                        return new string(way);
                                }
                            }

                            break;

                        case ']':
                            if (way[position] == '1')
                                while (code[i] != '[')
                                {
                                    i--;
                                    if (i <= 0)
                                        return new string(way);
                                }
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return new string(way);
            }

            return new string(way);
        }
    }
}
