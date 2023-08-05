/*

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
 
Constraints:

-231 <= x <= 231 - 1

 */

final int maxIntegerValue = 2147483647;
final int minIntegerValue = -2147483648;
class Solution {
  int reverse(int x) {

   bool isNegative = x < 0 ? true : false;
   int reverseNumber = 0;

   x = isNegative ? (x * -1) : x;
    
    while(x != 0)
    {
    reverseNumber += x % 10;
    reverseNumber = (x ~/ 10 != 0) ? (reverseNumber * 10) : reverseNumber;
    x = x ~/ 10;
    }
    
    if(isNegative)
    return (reverseNumber * -1) > minIntegerValue ? (reverseNumber * -1) : 0;
    else
    return reverseNumber < maxIntegerValue ? reverseNumber : 0;
  }
}