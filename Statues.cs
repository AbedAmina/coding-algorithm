int solution(int[] statues) 
{
    int n= 0;
 Array.Sort(statues);
 for(int i = 0; i < statues.Length - 1; i++)
 {
     if(statues[i+1] - statues[i]> 1)
     {
         n = n + statues[i+1] - statues[i]-1;
     }
 }
 return n;
}
