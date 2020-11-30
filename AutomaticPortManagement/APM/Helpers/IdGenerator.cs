using System;
using System.Text;

namespace APM
{
    public static class IdGenerator
    {
        public static StringBuilder RandomLetters(int length)
        {
            StringBuilder randomLetters = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                randomLetters.Append(letter);
            }

            return randomLetters;
        }
    }
}