using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitive_Programs.String_programes
{
    internal class string_is_rotation
    {


        public static  void  is_rotation(string str1, string str2){
            int c = 0;
            for(int i=0; i<str1.Length; i++)
            {
                if (!str2.Contains(str1[i]))
                {
                  c=1;
                }
            }
            if(c == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool checkString(string s1,string s2,int indxf,int size)
        {
            for (int i = 0; i < size; i++)
            {

                // check whether the character is equal or not
                if (s1[i] != s2[(indxf + i) % size])
                    return false;

                // %Size keeps (indexFound+i) in bounds, since
                // it ensures it's value is always less than
                // Size
            }

            return true;
        }



        public static void ra_Main(string[] args)
        {
           string s1 = Console.ReadLine();
           string s2 = Console.ReadLine();

          // is_rotation(s1,s2);

            if(s1.Length != s2.Length) {
                Console.WriteLine("No");
            }
            else
            {

                int[] indexes = new int[100];
                int j=0; 

                int size  = s1.Length;

                char firstchar = s1[0];
                for(int i =0;i<size;i++)
                {
                    if (s2[i]== firstchar)
                    {
                        indexes[j] = i;
                        j++;
                    }
                }
                bool isRotation = false;

                // check if the strings are rotation of each
                // other for every occurrence of firstChar in s2
                for (int idx = 0; idx < indexes.Length; idx++)
                {
                    isRotation = checkString(s1, s2, idx, size);

                    if (isRotation)
                        break;
                }

                if (isRotation)
                    Console.WriteLine(
                        "Strings are rotations of each other");
                else
                    Console.WriteLine(
                        "Strings are not rotations of each other");
            }


        }

        }


    }

