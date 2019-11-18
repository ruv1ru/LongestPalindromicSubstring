using System;
using System.Collections.Generic;
using System.Linq;


namespace palindromicstring.functions
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            //GetLongestPalindromicSubstring("DADY");
            //var result = GetLongestPalindromicSubstring("SchoolCode");
            var result = GetLongestPalindromicSubstring("BOBHANNAHDAD");
            //var result = GetLongestPalindromicSubstring("dgfdgfdgfdgfdgfdgfdgfdhgfhjrtyertregfdgwerweBOBfdgfdgfdgfHANNAfdgfdgHDAD");
            //var result = GetLongestPalindromicSubstring("dfdgwerweBOBfdgfdgfdgfHANNAfdgfdgHDAD");
            System.Console.WriteLine(result);
        }

        public static string GetLongestPalindromicSubstring(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
                return String.Empty;

            if(IsPalindrom(input))
                return input;

            if(input.Length < 4)  
                return string.Empty;
                          
            var palindroms = new Dictionary<int, string>();

            var left = 0;
            var subStringLength = 3;

            while(subStringLength <= input.Length -1)
            { 
                if(input.Length - left >= subStringLength)
                {
                    var subString3 = input.Substring(left, subStringLength);
                    System.Console.WriteLine(subString3);
                    
                    if(subString3.Length > 2 && IsPalindrom(subString3) && !palindroms.ContainsKey(subString3.Length))
                    {
                        palindroms.Add(subString3.Length, subString3);
                    }
                    left++;
                }
                else
                {
                    left = 0;
                    subStringLength++;
                }
                
            }


            if(palindroms.Count > 0)
                return palindroms[palindroms.Keys.Max()];

            return String.Empty;
                    
                
        }

        private static bool IsPalindrom(string subString)
        {
            var left = 0;
            var right = subString.Length - 1;

            while(left < right)
            {
                if(subString[left] == subString[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }

            }

            return true;
        }
    }
}
