using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        string s, revs = "";
        s = Console.ReadLine();


        for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
        {
            revs += s[i].ToString();
        }
        if (revs == s) // Checking whether string is palindrome or not  
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}