using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems {
    public class Solutions {
        public int[] TwoSum_Brute(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int n = 0; n < nums.Length; n++)
                {
                    if (i != n && (target == (nums[i] + nums[n])))
                    {
                        result[0] = n;
                        result[1] = i;
                    }
                }
            }
            return result;
        }
        public int[] TwoSum_SingleHash(int[] nums, int target)
        {
            SortedList<int, int> kvp = new SortedList<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];

                if (kvp.ContainsKey(compliment))
                {
                    return new int[2] { kvp[compliment], i };
                }
                else if (!kvp.ContainsKey(nums[i]))
                {
                    kvp.Add(nums[i], i);
                }
                else
                {
                    continue;
                }
            }
            throw new Exception();
        }

        public int MyAtoi(string str)
        {
            var chunk = str.TrimStart().Split(" ")[0];
            var allowedChars = "+-.";
            string lastTry = string.Empty;

            foreach (char item in chunk)
            {
                if (chunk.IndexOf(item) == 0 && allowedChars.Contains(item))
                {
                    lastTry += item;
                }
                else if (char.IsDigit(item))
                {
                    lastTry += item;
                }
                else if (chunk.IndexOf(item) > 0 && !char.IsDigit(item))
                {
                    break;
                }
            }

            return ParseMyAtoi(lastTry);
        }

        private int ParseMyAtoi(string str)
        {
            bool isIntParsed = int.TryParse(str, out int result);
            if (isIntParsed)
            {
                return result;
            }

            double.TryParse(str, out double thing);
            bool isLong = long.TryParse(thing.ToString(), out long thing2);

            if (isLong)
            {
                switch (Math.Sign(thing2))
                {
                    case 0:
                        return 0;
                    case -1:
                        return int.MinValue;
                    case 1:
                        return int.MaxValue;
                }
            }

            return 0;
        }

        public int Reverse(int x)
        {
            int result = 0;
            if (x.GetType() == typeof(int))
            {
                int sign = Math.Sign(x);
                if (x == int.MinValue)
                {
                    x = int.MinValue;
                }
                else
                {
                    x = Math.Abs(x);
                }
                char[] xString = x.ToString().ToCharArray();
                string xReverse = new string(xString.Reverse().ToArray());
                bool isStillInt = int.TryParse(xReverse, out result);
                if (isStillInt)
                {
                    result = int.Parse(xReverse) * sign;
                }
            }
            return result;
        }
    }
}
