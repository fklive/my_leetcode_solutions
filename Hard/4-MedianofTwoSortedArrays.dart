/*
4. Median of Two Sorted Arrays

Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

 */

class Solution {
  double findMedianSortedArrays(List<int> nums1, List<int> nums2) {

      List<int> mergedList = [];
      int median = 0;
      bool isListOdd = false;
      mergedList = nums1 + nums2;
      mergedList.sort();

      isListOdd = (mergedList.length % 2 != 0) ? true : false;
      median = isListOdd ? (mergedList.length / 2).floor() + 1
             : (mergedList.length / 2).floor();

         return isListOdd ? (mergedList[median-1].toDouble()) :
                (mergedList[median-1] + mergedList[median]) / 2;

       
  }
}