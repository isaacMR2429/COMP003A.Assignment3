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

            int ageDifference = currentYear - birthYear;
            Console.WriteLine($"\nCalculated age: {ageDifference}");

            string ageCategory;
            if ( ageDifference < 17)
            {
               ageCategory = "child";
               Console.WriteLine("Readiness Category: Child");
            }
            else if ( ageDifference >= 18 && ageDifference <= 20)
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

            string readinessStatus;
            if (validID && ageCategory == "Adult" && completedOrientation)
            {
                readinessStatus = "Ready";
                Console.WriteLine("\nReadiness Status: Ready");
            }
            else if (validID && ageCategory == "Adult" && !completedOrientation)
            {
                readinessStatus = "Conditionally Ready";
                Console.WriteLine("\nReadiness Status: Conditionally Ready");
            }
            else
            {
                readinessStatus = "Not Ready";
                Console.WriteLine("\nReadiness Status: Not Ready");
            }

            Console.WriteLine("\nSelect a Guidance Option: ");
            Console.WriteLine("1 - Academic Plannig");
            Console.WriteLine("2 - Personal Planning");
            Console.WriteLine("3 - Carrer Planning");
        }
    }
}
