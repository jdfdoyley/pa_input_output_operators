/*******************************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 7, 2022
 * Performance Assessment: IO & Operators
 *
 * Main application (program) class.
 * Write an application to demonstrate the use of input, output and operators.
 * The application must:
 * - Print a line that states "Your Name - Week 1 PA IO & Operators"
 * - Demonstrate integer-based operations
 *    - Retrieve 2 integer values from the user
 *    - Display the sum of those two values
 *    - Display the comparison results of value 1 to value 2, including:
 *      - Equality - whether the values are equal or not equal
 *      - Size - whether value 1 is greater than or less than value 2
 *      - Size with equality - whether value 1 is greater than or equal to or
 *        less than or equal to value 2
 * - Demonstrate floating point-based operations
 * - Retrieve 2 floating point values from the user
 * - Display floating point values to 4-decimal point precision
 * - Display the sum of those two values
 * - Display the comparison results of value 1 to value 2, including:
 *    - Equality - whether the values are equal or not equal
 *    - Size - whether value 1 is greater than or less than value 2
 *    - Size with equality - whether value 1 is greater than or equal to or
 *      less than or equal to value 2
 */

public class InputOutputOperator
{
    static void Main(string[] args)
    {
        // Print a line that states "Your Name - Week 1 PA IO & Operators"
        Console.WriteLine("Jason D'Oyley - Week 1 PA IO & Operators\n");

        // INTEGER
        // Demonstrate integer-based operations

        // Retrieve 2 integer values from the user
        Console.Write("Enter an integer value: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a second integer value: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        // Display the sum of those two values
        Console.WriteLine($"The sum of {n1} and {n2} is {n1 + n2}.");

        // Display the comparison results of value 1 to value 2, including:

        // Equality - whether the values are equal or not equal
        if (n1 == n2)
        {
            Console.WriteLine($"{n1} is equal to {n2}.");
        }
        else
        {
            Console.WriteLine($"{n1} is not equal to {n2}.");
        }

        // Size - whether value 1 is greater than or less than value 2
        if (n1 > n2)
        {
            Console.WriteLine($"{n1} is greater than {n2}.");
        }
        else
        {
            Console.WriteLine($"{n1} is less than {n2}.");
        }

        // Size with equality - whether value 1 is greater than or equal to
        // or less than or equal to value 2
        if (n1 >= n2)
        {
            Console.WriteLine($"{n1} is greater than or equal to {n2}.");
        }
        else
        {
            Console.WriteLine($"{n1} is less than or equal to {n2}.");
        }

        Console.WriteLine();

        // FLOATING-POINT
        // Demonstrate floating point-based operations

        // Retrieve 2 floating point values from the user
        Console.Write("Enter a floating point value: ");
        double f1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a second floating point value: ");
        double f2 = Convert.ToDouble(Console.ReadLine());

        // Display floating point values to 4-decimal point precision
        // Display the sum of those two values
        Console.WriteLine(
            "The sum of {0:F4} and {1:F4} is {2:F4}.",
            f1, f2, (f1 + f2)
        );

        // Display the comparison results of value 1 to value 2, including:
        // Equality - whether the values are equal or not equal
        if (f1 == f2)
        {
            Console.WriteLine("{0:F4} is equal to {1:F4}.", f1, f2);
        }
        else
        {
            Console.WriteLine("{0:F4} is not equal to {1:F4}.", f1, f2);
        }

        // Size - whether value 1 is greater than or less than value 2
        if (f1 > f2)
        {
            Console.WriteLine("{0:F4} is greater than {1:F4}.", f1, f2);
        }
        else
        {
            Console.WriteLine("{0:F4} is less than {1:F4}.", f1, f2);
        }

        // Size with equality - whether value 1 is greater than or equal to or
        // less than or equal to value 2
    }
}