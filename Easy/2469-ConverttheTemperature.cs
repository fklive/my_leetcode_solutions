/*
You are given a non-negative floating point number rounded to two decimal places celsius, that denotes the temperature in Celsius.

You should convert Celsius into Kelvin and Fahrenheit and return it as an array ans = [kelvin, fahrenheit].

Return the array ans. Answers within 10-5 of the actual answer will be accepted.

Note that:

Kelvin = Celsius + 273.15
Fahrenheit = Celsius * 1.80 + 32.00 

Example 1:

Input: celsius = 36.50
Output: [309.65000,97.70000]
Explanation: Temperature at 36.50 Celsius converted in Kelvin is 309.65 and converted in Fahrenheit is 97.70.
Example 2:

Input: celsius = 122.11
Output: [395.26000,251.79800]
Explanation: Temperature at 122.11 Celsius converted in Kelvin is 395.26 and converted in Fahrenheit is 251.798.

Constraints:

0 <= celsius <= 1000
*/
public class Solution {
    public double[] ConvertTemperature(double celsius) {

        const double KELVIN_CONSTANT = 273.15;
        const double FAHRENHEIT_CONSTANT = 32.00;
        const double FAHRENHEIT_COEFFICIENT = 1.80;
    
        double[] convertedTemperatures = new double[2];

        convertedTemperatures[0] = celsius + KELVIN_CONSTANT;
        convertedTemperatures[1] = (celsius * FAHRENHEIT_COEFFICIENT) + FAHRENHEIT_CONSTANT;

        return convertedTemperatures;
    }
}