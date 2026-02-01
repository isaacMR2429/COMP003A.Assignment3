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
               ageCategory = "child";
               Console.WriteLine("Readiness Category: Child");
            }
            else if ( difference >= 18 && difference <= 20)
            {
                ageCategory = "Young Adult";
               Console.WriteLine("Readiness Category: Young Adult");
            }
            else
            {
                ageCategory = "Adult"; 
                Console.WriteLine("Readiness Category: Adult");
            }

            Console.Write("\nDo you have a valid ID? (yes/no): ");
            string idInput = Console.ReadLine();
            bool validID = idInput == "yes";

            Console.Write("Have you completed orientation? (yes/no): ");
            string orientationInput = Console.ReadLine();
            bool completedOrientation = orientationInput == "yes";

        }
    }
}
