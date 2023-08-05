/*
9. Palindrome Number
Given an integer x, return true if x is a 
palindrome, and false otherwise.

*/

import 'dart:math';

class Solution {
  static const int modNumb = 10;
  bool isPalindrome(int x) {
      int number = x;
      int digit = 0, result = 0;
      if(x < 0)
      return false;

      while(number > 0)
      {
        number = (number / 10).floor();
        digit++;
      }

      number = x;
      for(int i = digit-1; i >= 0; i--)
      {
        result += (number % 10) * pow(modNumb,i).floor();
        number = (number / 10).floor();
      }

      return (result == x) ?  true : false;

  }
}