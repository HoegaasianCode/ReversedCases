using System;
using System.Collections.Generic;
using System.Text;

namespace ReversedCases
{
    public class CaseReverser
    {
        private readonly string _case;

        public CaseReverser(string case1)
        {
            _case = case1;
        }

        public string InvertCapitalization()
        {
            var sb = new StringBuilder();
            foreach(var c in _case)
            {
                if (Char.IsUpper(c)) sb.Append(c.ToString().ToLower());
                else sb.Append(c.ToString().ToUpper());
            }
            return sb.ToString();
        }
    }
}
