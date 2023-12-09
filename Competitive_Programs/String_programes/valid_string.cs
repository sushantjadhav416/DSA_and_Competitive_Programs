using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class valid_string
    {
        public static void validarting(string str)
        {
            List<char> openbr  = new List<char>() {'{','[','('};
            List<char> closebr = new List<char>() {'}',']',')'};

            List<char> l = new List<char>();
            List<int> n = new List<int>();

            for(int i = 0; i < str.Length; i++)
            {
                if (openbr.Contains(str[i]))
                {
                    l.Add(str[i]);
                    n.Add(openbr.IndexOf(str[i]));

                }
                else if (closebr.Contains(str[i]))
                {
                    if (l.Count == 0)
                    {
                        l.Add(str[i]);
                        break;
                    }
                    else
                    {
                        if (i == closebr[n[l.Count-1]])
                        {
                            l.RemoveAt(0);
                            n.RemoveAt(0);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else { continue; }

            }

            if (l.Count == 0)
            {
                Console.WriteLine("Valid string - True");
            }
            else
            {
                Console.WriteLine("Invalid string!");
            }
        }

        public static void val_Main(string[] args) 
        { 
           string s = Console.ReadLine();

            validarting(s);
        }
    }
}
