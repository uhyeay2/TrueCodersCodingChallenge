namespace TrueCodersCodingChallenge._1_February_2024
{
    /// <summary>
    /// Week One Challenge:
    /// Write a function to calculate the factorial of a given number. 
    /// The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
    /// </summary>
    public class Week1_Factorial
    {
        public int Challenge(int input)
        {
            if (input <= 0)
            {
                return 0;
            }

            return Enumerable.Range(1, input).Aggregate((a, b) => a * b);
        }
    }
}
