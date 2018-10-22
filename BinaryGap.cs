using System;
// you can also use other imports, for example:
// using System.Collections.Generic;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");
class Solution
{
    public int solution(int N)
    {
        string binaryNumberString = Convert.ToString(N, 2);
        int result = 0;
        int tmpResult = 0;
        bool hasEnd = false;
        if (!binaryNumberString.Contains("0"))
        {
            return result;
        }
        for (int i = 0; i < binaryNumberString.Length; i++)
        {
            if (binaryNumberString[i] == '1')
            {
                for (int j = i + 1; j < binaryNumberString.Length; j)
                {
                    if (binaryNumberString[j] != '1')
                    {
                        tmpResult++;
                    }
                    else if (binaryNumberString[j] == '1')
                    {
                        hasEnd = true;
                        break;
                    }
                }
                if (tmpResult > result && hasEnd)
                {
                    result = tmpResult;
                }
                hasEnd = false;
                tmpResult = 0;
            }
        }
        return result;
    }
}

// TODO: make this a working solution

/* Tests: 
example1
example test n=1041=10000010001_2

example2
example test n=15=1111_2

example3
example test n=32=100000_2

extremes
n=1, n=5=101_2 and n=2147483647=2**31-1

trailing_zeroes
n=6=110_2 and n=328=101001000_2

power_of_2
n=5=101_2, n=16=2**4 and n=1024=2**10

simple1
n=9=1001_2 and n=11=1011_2

simple2
n=19=10011 and n=42=101010_2

simple3
n=1162=10010001010_2 and n=5=101_2

medium1
n=51712=110010100000000_2 and n=20=10100_2

medium2
n=561892=10001001001011100100_2 and
n=9=1001_2

medium3
n=66561=10000010000000001_2

large1
n=6291457=11000000000000000000001_2

large2
n=74901729=100011101101110100011100001

large3
n=805306373=110000000000000000000000000101
_2

large4
n=1376796946=10100100001000001000001000100
10_2

large5
n=1073741825=10000000000000000000000000000
01_2

large6
n=1610612737=11000000000000000000000000000
01_2

 */