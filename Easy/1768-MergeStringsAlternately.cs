/*
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

 

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s 

Constraints:

1 <= word1.length, word2.length <= 100
word1 and word2 consist of lowercase English letters.*/
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string mergedWord = null;
        int maxLenght = (word1.Length >= word2.Length) ? word1.Length : word2.Length;

        if((word1.Length < 1 || word1.Length > 100) || (word2.Length < 1  || word2.Length > 100))
            return null;

        
        return mergedWord;
    }
}