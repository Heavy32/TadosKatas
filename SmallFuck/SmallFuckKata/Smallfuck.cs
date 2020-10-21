using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallFuck
{
    public class Smallfuck
    {
        static public string Interpreter(string code, string tape)
        {
            int positionInCode = 0;
            int positionInTape = 0;

            var tapeArray = tape.ToArray();

            Dictionary<char, Action> commands = new Dictionary<char, Action>
            {
                { '>', () => positionInTape++ },
                { '<', () => positionInTape-- },

                { '*', () => tapeArray[positionInTape] = tapeArray[positionInTape] == '1' ? '0' : '1' },
                { '[', () =>
                    {
                        if (tapeArray[positionInTape] == '0')
                        {
                            var loopCount = 1;
                            while (loopCount != 0)
                            {
                                positionInCode++;
                                if (code[positionInCode] == ']')
                                    loopCount--;
                                else if (code[positionInCode] == '[')
                                    loopCount++;
                            }
                        }
                    }
                },

                {']', () =>
                    {
                        if (tapeArray[positionInTape] == '1')
                        {
                            var loopCount = 1;
                            while (loopCount != 0)
                            {
                                positionInCode--;
                                if (code[positionInCode] == ']')
                                    loopCount++;
                                else if (code[positionInCode] == '[')
                                    loopCount--;
                            }
                        }
                    }
                }
            };

            while (positionInCode >= 0 && positionInCode < code.Length
                && positionInTape >= 0 && positionInTape < tape.Length)
            {
                if (commands.TryGetValue(code[positionInCode], out Action command))
                    command.Invoke();

                positionInCode++;
            }
           
            return new string(tapeArray);
        }
    }
}
