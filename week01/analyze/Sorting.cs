public static class Sorting
{
    public static void Run()
    {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data)
    {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--)
        {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos)
            {
                if (data[swapPos] > data[swapPos + 1])
                {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}
//sortPos 6 5 4 3 2 1 0
//swapPos (0, 1, 2, 3, 4, 5) (0, 1, 2, 3, 4) (0, 1, 2, 3) (0, 1, 2) (0, 1) (0) -> o(n^2) n(n+1)/2

// 3, 2, 1, 6, 4, 9, 8 
// 2, 3, 1, 6, 4, 9, 8
// 2, 1, 3, 6, 4, 9, 8
// ... 