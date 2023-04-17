int solution(int[] inputArray) 
{
      int max = inputArray[0] * inputArray[1];
           for (int x = 1; x <= inputArray.Length - 2; x++)
           {
              max = Math.Max(max, inputArray[x] * inputArray[x + 1]);
            }
         return max;
}
