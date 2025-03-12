namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#

            bool validChoice = false;
            int difference = 0;
            int startYear = 0;
            int endYear = 0;
            while (validChoice != true)
            {
                Console.WriteLine("Enter a start year:");
                startYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an end year:");
                endYear = Convert.ToInt32(Console.ReadLine());
                if (startYear < endYear)
                {
                    validChoice = true;
                }
                if (startYear < 2000)
                {
                    validChoice = true;
                }
                else
                {
                    validChoice = false;
                    Console.WriteLine("Start year must be before 2000");
                }
            }
            difference = endYear - startYear;
            Console.WriteLine(difference);
        }
    }
}
