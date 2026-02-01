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

            string ageCategory;
            if ( difference < 17)
            {
                Console.WriteLine("Readines Category: Child");
            }
            else if ( difference >= 18 && difference <= 20)
            {
                Console.WriteLine("Readiness Catergory: Young Adult");
            }
            else
            {
                Console.WriteLine("Readiness Category: Adult");
            }
        }
    }
}
