/*
For two strings s and t, we say "t divides s" if and only if s = t + ... + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"
Output: "ABC"
Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"
Output: "AB"
Example 3:

Input: str1 = "LEET", str2 = "CODE"
Output: ""

Constraints:

1 <= str1.length, str2.length <= 1000
str1 and str2 consist of English uppercase letters.
*/
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int str1Length = str1.Length;
        int str2Length = str2.Length;
        string output = "";

        if(str1.Length < 1 && str2.Length > 1000)
            return null;

        if(str1 + str2 == str2 + str1)
        {
            int dividerLength = GreatestCommonDivide(str1Length,str2Length);
            return str1.Substring(0 ,dividerLength); 
        }
        else
            return output;   

    }

    int GreatestCommonDivide(int n1, int n2)
    {
        if(n2 == 0)
            return n1;
        else
            return GreatestCommonDivide(n2, (n1 % n2));
    }
}