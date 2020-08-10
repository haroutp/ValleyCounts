using System;
using System.Collections.Generic;
using System.Collections;

namespace CountingValleys
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(countingValleys(8, "UDDDUDUU"));

        }

        static int countingValleys(int n, string s)
        {
            
            Dictionary<char, int> hike = new Dictionary<char, int>()
            {
                {'D', -1},
                {'U', 1}
            };
            
            int valleyCount = 0;
            int level = valleyCount;

            foreach (char item in s)
            {
                level += hike[item];
                if(level == 0 && item == 'U')
                    valleyCount += 1;
            }

            return valleyCount;
            // return the number of valley's gary went through, 
            // a valley is a trip below sea level
        }
    }
}
