using Module03Testing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module03Testing.Utilities
{
    public class BubbleSort : ISort
    {
        public string Sort(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return null;

            var orderedChars = inputString.GroupBy(c => c)
                .OrderBy(e => e.Key)
                .Select(x => x.Key);

            return new string(orderedChars.ToArray());
        }
    }
}
