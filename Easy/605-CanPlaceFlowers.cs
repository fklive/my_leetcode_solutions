/*
You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 

Constraints:

1 <= flowerbed.length <= 2 * 104
flowerbed[i] is 0 or 1.
There are no two adjacent flowers in flowerbed.
0 <= n <= flowerbed.length
*/

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
    //çift sayılarda yarısı , teklerde yarısının 1 fazlası
    int emptyPlotCount = 0, fullPlotCount = 0;
    int totalCapacity = (flowerbed.Length %2 == 0) ?
                        (flowerbed.Length) / 2 : (flowerbed.Length / 2) +1 ;
    bool flag = false;

    if(n < 0 || n > flowerbed.Length)
        return false;
    else if(flowerbed.Length == 1 && flowerbed[0] == 0)
        return true;

    foreach(var item in flowerbed)
    {
        emptyPlotCount += (item == 0) ? 1 : 0;
        fullPlotCount += (item == 1) ? 1 : 0; 
    }

    for(int i = 0; i < flowerbed.Length; i++)
    {
        if(i + 1 == flowerbed.Length)
        break;

        else if(flowerbed[i] == 0 && flowerbed[i+1] == 0)
            flag = true;
    }

    if(flag && (flowerbed.Length % 2 != 0) && emptyPlotCount -1 == fullPlotCount)
        totalCapacity -= 1; 
    else if(flowerbed[0] == 0 && flowerbed[flowerbed.Length-1] == 0 
            && emptyPlotCount -1 == fullPlotCount)
            totalCapacity -=1;

    return (totalCapacity - fullPlotCount) >= n ? true : false;

    return false;

    }
}