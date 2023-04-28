string[] solution(string[] arr)
{
    int maxLength = arr.Max(s => s.Length);
    return arr.Where(s => s.Length == maxLength).ToArray();
}
