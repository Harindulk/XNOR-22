using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
            Console.WriteLine(new String('*', i + 1).PadRight(N, ' '));

    }
}
