// Source : https://leetcode.com/problems/powx-n/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:21:24 PM 

/**********************************************************************************
*
* Implement pow(x, n).
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution050 
    {
        public static double MyPow(double x, int n) 
        {
            if(n == 0) return 1.0;
            if(n < 0) return 1.0 / MyPow(x, -n);

            return x * MyPow(x, n-1);
        }

        public static double MyPow2(double x, int n)
        {
            if(n == 0) return 1.0;
            if(n<0) return 1.0/MyPow2(x, -n);
            double half = MyPow2(x, n>>1);
            if(n%2 == 0)
            {
                return half * half;
            }   
            else
            {
                return half * half * x;
            }  
        }
    }
}

