bool solution(int[] sequence) 
{
    int count = 0;
    for (int i = 1; i < sequence.Length; i++)
    {
        if (sequence[i] <= sequence[i-1])
        {
            count++;
            if (count > 1 || (i > 1 && sequence[i] <= sequence[i-2] && i < sequence.Length - 1 && sequence[i+1] <= sequence[i-1]))
            {
                return false;
            }
        }
    }

    return true;
}
