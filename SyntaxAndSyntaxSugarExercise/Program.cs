namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        { //inferred typing
          //string interpolation
          //and the ternary operator

            var answer = 5;
            string response = (answer < 9) ? ($"{answer} is less than nine"):($"{answer} is greater than or equal to nine");

            Console.WriteLine(response);
           
        }
    }
}
