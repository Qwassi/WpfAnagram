using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Anagram.Util
{
    public class Anagram
    {

        public static bool AnagramStrStr(string str1, string str2)
        {
            bool isAnagram = false;
            string filteredStr1 = str1.Replace(" ", "").ToLower();
            string filteredStr2 = str2.Replace(" ", "").ToLower();
            DoPermutation(filteredStr1.ToCharArray(), filteredStr2, 0, filteredStr1.Length - 1, ref isAnagram);
            return isAnagram;
        }

        private static void DoPermutation(char[] elements, string stringToCompare, int currentLoop, int maxLength, ref bool isAnagram)
        {
            if (currentLoop == maxLength)
            {
                string s = "";

                foreach (var element in elements)
                {
                    s += element;
                }

                if (stringToCompare.Contains(s))
                {
                    isAnagram = true;
                } 
                
                return;
            }

            for (int i = currentLoop; i <= maxLength; i++)
            {
                SwapElements(ref elements[currentLoop], ref elements[i]);
                DoPermutation(elements, stringToCompare, currentLoop + 1, maxLength, ref isAnagram);
                SwapElements(ref elements[currentLoop], ref elements[i]);
            }
        }

        private static void SwapElements(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
