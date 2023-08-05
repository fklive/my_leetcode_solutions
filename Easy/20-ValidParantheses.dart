/*
20. Valid Parentheses

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

1.Open brackets must be closed by the same type of brackets.
2.Open brackets must be closed in the correct order.
3.Every close bracket has a corresponding open bracket of the same type.

 */


class Solution {

  static const String classicBrackets = '()';
  static const String fancyBrackets = '{}';
  static const String cornerBrackets = '[]';

  bool isValid(String s) {
    
  if(s.length.isOdd)
    return false;

  while(!s.isEmpty)
  {
    if(s.contains(classicBrackets))
      s = s.replaceAll(classicBrackets, '');
    
    else if(s.contains(fancyBrackets))
      s = s.replaceAll(fancyBrackets, '');

    else if(s.contains(cornerBrackets))
      s = s.replaceAll(cornerBrackets, '');  

    else 
      return false;
  }
      return true;
  
  }
}