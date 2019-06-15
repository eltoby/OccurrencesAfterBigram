using System;
using System.Collections;
using System.Collections.Generic;

namespace Occurrences_After_Bigram
{
    public class Solution
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var pWord = "";
            var ppWord = "";

            var result = new List<string>();

            foreach (var word in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                if (ppWord == first && pWord == second)
                    result.Add(word);

                ppWord = pWord;
                pWord = word;
            }

            return result.ToArray();
        }
    }
}
