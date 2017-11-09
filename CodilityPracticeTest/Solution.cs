using System;

namespace CodilityPracticeTest
{
    class Solution
    {
        public int MySolution()
        {
            int[] A = { 1, 2, 3, 4, 5, 9 };
            int value = 0;
            int answer = 0;
            bool boolTest = true;
            int lastNum = 0;

            Array.Sort(A);

            int i = 0;
            foreach (int num in A)
            {


                if ((num > 0) && (boolTest == true))
                {

                    value = num - lastNum;
                    if (value > 1)
                    {
                        boolTest = false;
                        answer = lastNum;
                    }
                }
                lastNum = num;
                i++;
            }
            return answer;
        }
    }
}


    