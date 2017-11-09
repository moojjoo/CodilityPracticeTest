using System;


//Branch v1.1 change does this work

class Solution
    {
        int[] A =  { 1,2,3,4,5,9};
        public int solution(int[] A)
        {
        A = new int[5];
        A[0] = 1;
        A[1] = 2;
        A[2] = 3;
        A[3] = 4;
        A[4] = 5;

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

