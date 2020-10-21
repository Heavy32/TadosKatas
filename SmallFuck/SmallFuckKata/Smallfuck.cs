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
                { '[', () => Jump( 1, tapeArray, positionInTape, code, ref positionInCode) },
                { ']', () => Jump(-1, tapeArray, positionInTape, code, ref positionInCode) }
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

        private static void Jump(int direction, char[] tapeArray, int positionInTape, string code, ref int positionInCode)
        {
            char ignoredChar = direction == 1 ? '1' : '0';

            if (tapeArray[positionInTape] != ignoredChar)
            {
                var loopCount = 1;
                while (loopCount != 0)
                {
                    positionInCode += direction;
                    if (code[positionInCode] == ']')
                        loopCount -= direction;
                    else if (code[positionInCode] == '[')
                        loopCount += direction;
                }
            }
        }
    }
}
