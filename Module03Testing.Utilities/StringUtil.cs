using Module03Testing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module03Testing.Utilities
{
    public class StringUtil
    {
        ISort _sort;
        public StringUtil()
        {
            _sort = null;
        }

        public StringUtil(ISort sort)
        {
            _sort = sort;
        }

        public int FindOccurences(string inputString, char charToSearch)
        {
            if (string.IsNullOrEmpty(inputString))
                return 0;

            var occurrences = inputString.GroupBy(c => c)
                .Where(e => Char.ToLower(e.Key) == Char.ToLower(charToSearch))
                .Select(x => x);

            return occurrences.Count();
        }

        public string SortInputStringChar(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return null;

            return _sort.Sort(inputString);
        }
    }
}
