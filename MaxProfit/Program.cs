namespace MaxProfit;
class Program
{
    static void Main(string[] args)
    {

        int[] A = { 23171, 21011, 21123, 21366, 21013, 21367 };        
        
        Console.WriteLine(solution(A));
    }

    public static int solution(int[] A) {
        // Implement your solution here

        int maxVal = 0;
        int maxprofit = 0;

        for(int i = 0; i < A.Length; i++){
            int sum = 0;
            if(i != A.Length - 1){
                sum = (A[i] - A[i+1]) *-1;

            }
            
            maxVal = Math.Max(0,maxVal + sum);
            maxprofit= Math.Max(maxprofit ,maxVal);
        }

        return maxprofit;
    }
}
