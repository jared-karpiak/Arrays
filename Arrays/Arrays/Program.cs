using System.Runtime.InteropServices;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An array is a way for a program to store collections of information that are the same type and have a similar purpose
            // An array is stored in a computer's memory as a single block, so if an array has a capacity for 8 bytes of space, 8 bytes of 
            // space will be reserved for the entire array.

            // There are five main parts that make up an array:
            //  1. The name of the array (the same as a variable name)
            //  2. The elements, or content, inside the array.
            //  3. Indexes, which are integers that represent the position of each element in an array
            //  4. The length of the array (the number of items it is capable of holding).
            //  5. The type of array (int, string, char, etc.)

            // The syntax to create a new array is:

            // <type>[] <name> = new <type>[length];

            // The square brackets [] are one of the definitive features of arrays. We use them after the data type
            // to tell the compiler that this is not a single variable, but an array.
            
            // When creating a new array, we have to specify the size of the array (the number of elements it is allowed to hold)
            // Arrays have a FIXED SIZE, which means they cannot have more elements inside of them than have been allocated. We
            // Cannot put 6 items in array that was set to only hold 5.



            // To declare an array that is capable of holding up to 5 integers, we declared the following:

            // type  name        length
            // |      |            |
            // |      |            |
            // V      V            V
            int[] myInts = new int[5];

            // With the above definition, we are creating an array that can hold up to 5 ints. We haven't actually added any values to
            // the array, so the default value of the data type is used, in this case 0.

            // The array myInts contains a collection of 5 integers, each with the value 0.

            // Just like with variables, we cannot put any items into the array that do not match the data type. We could not put
            // a string into the myInts array.

            // If we wanted, we could initialize the contents of an array when we declare it in a couple ways.
            
            // here we declare our new array as before, but in curly braces we list the values we want it to have.
            // This array will hold 5 integers, each with the values that we listed in order.
            int[] myInts2 = new int[5] { 7, 2, 7, 3, 10 };

            // The second way to declare initialize the elements:
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            // In this second way, we don't even need the "new string[7]" part. Because of the contents we put in, the compiler
            // performs the "new string[7]" operation without us having to explicitly tell it to do so. Not all programming or
            // scripting languages have this functionality though.

            /***** Accessing Elements in an Array *****/

            // The elements of an array are accessed by their index, which is an integer that represents the position of that
            // particular element in the array.
            // Arrays in C# are zero-indexed, meaning that the first item in the array has an index of 0, the second an index of 1,
            // the third an index of 2, and so on and so forth.

            // for loops are very often used to iterate through each item in an array (look at each item one at a time) because
            // the counter (i) can be used as the index.

            // Let's see how we can access all of the days of the week using a for loop

            // Instead of using a constant value, like 7, in the logical condition, we use the Length property that is available
            // on all arrays. This will help us avoid the nasty IndexOutOfRange exception.

            Console.WriteLine($"These are the days of the week:\n");
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                // in order to access a specific value in an array, we type the name of the array, followed by the element's index
                // in square brackets.
                Console.WriteLine($"Day {i} is \"{daysOfWeek[i]}.\"");
            }
            Console.WriteLine("------------------");
            // If we pass in an index that is outside of the range, we will get the dreaded IndexOutOfRange exception, which is
            // a blight on a developer's career.
            // For example:
            // string eleventhDay = daysOfWeek[10].

            // The above statement will throw an IndexOutOfRange error, because there are not 11 items in the array, there are only 7.

            // We can do more than print out values of arrays using indexes. We can change the value of that element.

            Console.WriteLine($"The value of myInts2[0] is '{myInts2[0]}'.");

            myInts2[0] += 5;

            Console.WriteLine($"The value of myInts2[0] is now '{myInts2[0]}'.");
            Console.WriteLine("------------------");
            /***** Sorting Arrays *****/
            // Very often we will get arrays that are unsorted, the order of the index might not be
            // the alphabetical order for example.


            // At this point in the code, the array myInts2 is structured like this:

            // Index : Value
            //   0   :   12
            //   1   :   2
            //   2   :   7
            //   3   :   3
            //   4   :   10

            Console.WriteLine("Unsorted Array:\n");
            for (int i = 0; i < myInts2.Length; i++)
                Console.WriteLine($"Index {i} : {myInts2[i]}");

            // This array is not yet sorted. If it were sorted, then the first index would have the lowest
            // number, the second index the second lowest number, etc.
            // C# provides us with a simple way to sort an array, using the Array.Sort() method.

            //      array to sort
            //            |
            //            |
            //            V
            Array.Sort(myInts2);

            // After the Array.Sort() method is executed, the array myInts2 will now look like this:

            // Index : Value
            //   0   :   2
            //   1   :   3
            //   2   :   7
            //   3   :   10
            //   4   :   12
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Array:\n");
            for (int i = 0; i < myInts2.Length; i++)
                Console.WriteLine($"Index {i} : {myInts2[i]}");

            Console.WriteLine("------------------");

            /***** Random Number Generation *****/
            // Whenever we want to generate a random number in C#, we need to use a class called Random.
            // We need to create a new "object" that will perform the random number generation for us
            Random rand = new Random();

            // After we create the Random object, we call the method Next(), where we specify a range of
            // values to select a random number from.
            // We must provide the minimum value, which is inclusive (ie. included in the results)
            // and we must provide the maximum value, which is exclusive (not included)

            //             min (inclusive)  max (exclusive)
            //                           |  |
            //                           |  |
            //                           V  V
            int randomNumber = rand.Next(1, 11);

            //The above code will return a number from 1 to 10, but will never return 11.

            /***** Multi-dimensional Arrays *****/
            // So far we have just looked at one-dimensional arrays, just a collection of single items.
            // Imagine it has just been the x-axis of a grid.

            // However, with arrays we can have introduce more dimension, arrays within arrays in away.
            // For example, we could create a two dimensional array, which would resemble a spreadsheet
            // or a table in a database. We would have rows and we would have columns.

            // To declare another dimension to an array, we simply add commas whenever we want to add a new dimension
            // indicate that we want to add another dimension.
            // With two-dimensional arrays, the first set of indexes is usually called a "row"
            // and the second set a "column"

            // The following will create a two dimentional int array that holds 3 "rows" of 5 "columns" 

            const int ROW_SIZE = 3;
            const int COL_SIZE = 5;
            // comma           size1(rows)         size2(columns)
            //  |                        |           |
            //  |                        |           |
            //  V                        V           V
            int[,] myMultiInts = new int[ROW_SIZE, COL_SIZE];

            // We could create 3 dimensional arrays by adding another comma, or even 4 dimensional arrays (mind blown)

            // Let's populate this multi-dimensional array with some random numbers.

            for (int row = 0; row < ROW_SIZE; row++)
            {
                for (int col = 0; col < COL_SIZE; col++)
                {
                    // to access the element at the specific location we have to make sure we specify
                    // both the row and the column (think excel spreadsheet)
                    myMultiInts[row, col] = rand.Next(1, 100);
                }
            }

            // Now let's visualize what the multidimensional array looks like.
            Console.WriteLine("------------------");

            for (int row = 0; row < ROW_SIZE; row++)
            {
                Console.Write($"Row {row}|   ");
                for (int col = 0; col < COL_SIZE ; col++)
                {
                    Console.Write($"  {myMultiInts[row, col]}  |");
                }
                
                Console.WriteLine(); // create a new line.
            }
        }
    }
}
