using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeDaily
{
    /// <summary>
    /// Daily problem for November 6th, 2022
    /// 
    /// #899 Orderly Queue
    /// </summary>
    public class OrderlyQueue
    {
        /// <summary>
        /// You are given a string s and an integer k. You can choose one of the 
        /// first k letters of s and append it at the end of the string..
        /// 
        /// Return the lexicographically smallest string you could have 
        /// after applying the mentioned step any number of moves.
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string SmallestString(string s, int k)
        {
            if(k >= 2)
            {
                char[] c = s.ToArray();
                Array.Sort(c);
                string newS = new string(c);
                return newS;
            }

            var n = s.Length;
            var best = s;
            string current = "";

            for (int i = 0; i < n; i++)
            {
                current = s.Substring(i, n - i) + s.Substring(0, i);
                if (string.Compare(current, best) < 0)
                    best = current;
            }
            return best;
        }
    }
}
