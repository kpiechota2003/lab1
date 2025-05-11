namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(10, 1);
            Console.WriteLine(problem.ToString());

            Result result = problem.Solve(20);
            Console.WriteLine(problem.ToString());

            Console.WriteLine(result.ToString());


        }
    }
}
