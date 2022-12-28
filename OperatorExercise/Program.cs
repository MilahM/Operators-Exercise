namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1
            int a = 17;
            int b = 4;

            int sum = a + b;
            Console.WriteLine($" Sum: {sum}");

            int diff = a - b;
            Console.WriteLine($" Difference: {diff}");

            int product = a * b;
            Console.WriteLine($"Product: {product}");

            int quotient = a / b;

            int remainder = a % b;
            Console.WriteLine($" a divided by b is {quotient} remainder {remainder}");


            //EXERCISE 2
            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine($" The are of your cirlce is {radius}");

            //THOUGHT EXERCISE: k = 16
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
    }
}
