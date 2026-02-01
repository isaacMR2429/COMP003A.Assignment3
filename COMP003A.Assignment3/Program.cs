namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academic & Personal Readiness Evaluator");

            int currentYear = DateTime.Now.Year;
            Console.WriteLine($"\nCurrent Year: {currentYear}");
            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            int difference = currentYear - birthYear;
            Console.WriteLine($"\nCalculated age: {difference}");

        }
    }
}
