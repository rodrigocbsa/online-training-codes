﻿class Result
{
    /*
    * Complete the 'findMedian' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts INTEGER_ARRAY arr as parameter.
    */
    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        return arr.ElementAt(Math.DivRem(arr.Count, 2, out int remainder));
    }
}
