namespace CyclicRotation;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] A = new int[] {3, 8, 9, 7, 6};
        int K = 3;

        int[] solution = Solution(A,K);

        Console.WriteLine("[{0}]", string.Join(", ", solution));
    }


    private static int[] Solution(int[] A, int K) {
        // Implement your solution here

        for(int r = 0; r < K; r++)
        {
            int arrLength = A.Length;

            if(arrLength <= 1)
                return A;
                
            int toShiftNext = A[0];
            int store = A[1];
            int i = 0;
            while(i< arrLength-1)
            {
                            
                //store
                store = A[i+1];

                //replace
                A[i+1] = toShiftNext;

                //to shiftnext
                toShiftNext = store;

                i++;
                //check for last
                if(i==arrLength-1)
                {
                    A[0] = toShiftNext;
                }

            }
        }

        return A;
    }

}
