using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConvertFromString
    {

        public static int ToInt(string input)
        {
            int returnint = 0;
            int counter   = 0;
            if (input==null|| input.Length == 0) throw new ArgumentNullException();
            bool IsPositive = true;

            switch (input[0])
            {
                case '-':
                    if (input.Length==1) throw new ArgumentException();
                    counter = 1;
                    IsPositive = false;
                    break;
                case '+':
                    if (input.Length == 1) throw new ArgumentException();
                    counter = 1;
                    break;
            }

            for (int i = counter;i<input.Length;i++)
            {
                if ((input[i] < '0') || (input[i] > '9')) throw new ArgumentException();
                returnint = checked(returnint * 10 + CharToInt(input[i]));
            }

            return (IsPositive) ? returnint : -returnint;
        }

        private static int CharToInt(char c)
        {
            return c - '0';
        }

    }
}
