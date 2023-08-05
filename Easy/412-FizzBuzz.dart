/*
412. Fizz Buzz


Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.

 */


class Solution {
  List<String> fizzBuzz(int n) {
    List<String> fizzBuzzList = [];

    for(int temp = 1; temp <= n; temp++)
    {
        String toBeAdded = "";
        if(temp % 3 == 0)
        toBeAdded += "Fizz";
        if(temp % 5 == 0)
        toBeAdded += "Buzz";
        if(toBeAdded.isEmpty)
        toBeAdded += temp.toString();
        
        fizzBuzzList.add(toBeAdded);
    }
      return fizzBuzzList;

  }
}