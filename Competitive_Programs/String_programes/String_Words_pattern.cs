using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs_and_DSA_Qns.String_programes
{
    //String isomorphic
    //word pattern;
    internal class String_Words_pattern
    {
        public bool wordPattern(string pattern, string s)
        {

            string[] words = s.Split(" ");

            if (words.Length != pattern.Length)
                return false;

            Dictionary<char, int> Hm1 = new Dictionary<char, int>();
            Dictionary<string, int> Hm2 = new Dictionary<string, int>();

            for (int i = 0; i < pattern.Length; ++i)
            {
                if ((Hm1[pattern[i]] == i) != (Hm2[words[i]]==i))
                    return false;
            }
            return true;
        }
    }
}
