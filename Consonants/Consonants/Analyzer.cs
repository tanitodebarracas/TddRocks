﻿namespace Consonants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Analyzer
    {
        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public IList<int> GetConsonantPositions(string text, int length)
        {
            IList<int> positions = new List<int>();
            int l = text.Length;
            Console.WriteLine("Text length " + l);
            int k;

            for (k = 0; k < l; k++)
                if (!vowels.Contains(text[k]))
                    break;

            Console.WriteLine("First consonant at " + k);

            for (; k + length <= l; k++)
            {
                int counter = 0;

                for (int j = 0; counter == j && j < length; j++)
                    if (!vowels.Contains(text[k + j]))
                        counter++;

                if (counter == length)
                    positions.Add(k);
            }

            Console.WriteLine("Count of Positions " + positions.Count);

            return positions;
        }

        public int Count(string text, int length)
        {
            var positions = this.GetConsonantPositions(text, length);
            int tlength = text.Length;

            int counter = 0;
            int initial = 0;

            foreach (int position in positions)
            {
                int first = position - initial;
                int rest = tlength - position - length;
                counter += (first + 1) * (rest + 1);

                //if (rest > 0 && first > 0)
                //    counter--;

                initial = position + 1;
            }

            return counter;
        }
    }
}
