using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{

    static int GetMinDist(int[] powers)
    {
        Array.Sort(powers);
        int minDist = powers[1] - powers[0];
        
        for (int i = 1; i < powers.Count() - 1; i++)
        {
            int dist = powers[i + 1] - powers[i];
            if (dist < minDist)
                minDist = dist;
        }
        return minDist;
    }
    
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] powers = new int[N];
        
        for (int i = 0; i < N; i++)
        {
            powers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(GetMinDist(powers));
    }
}