using System;


namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Asking the user for their age
                Console.Write("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Checking if the age has a zero or negative value
                if (age <= 0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }

                // Calculating the year the user was born
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                // Displaying the year the user was born
                Console.WriteLine($"You were born in the year {birthYear}");
            }
            catch (FormatException)
            {
                // Handling the exception if the user enters a non-integer value
                Console.WriteLine("Error: Please enter a valid number for age.");
            }
            catch (ArgumentException ex)
            {
                // Handling any other exceptions
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handling any other exceptions
                Console.WriteLine($"An error occured: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
