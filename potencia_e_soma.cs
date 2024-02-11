//Complete the square sum function so that it squares each number passed into it and then sums the results together.
//For example, for [1, 2, 2] it should return 9 because 
//sum = 1^2 + 2^2 + 2^2 = 9

using System;
using System.Collections.Generic;
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
      int potencia = numbers[i] * numbers[i]; 
      sum = sum + potencia;
    }
    return sum;
  }
}
