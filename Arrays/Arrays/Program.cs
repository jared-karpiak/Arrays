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

            // If we pass in an index that is outside of the range, we will get the dreaded IndexOutOfRange exception, which is
            // a blight on a developer's career.
            // For example:
            // string eleventhDay = daysOfWeek[10].

            // The above statement will throw an IndexOutOfRange error, because there are not 11 items in the array, there are only 7.

            // We can do more than print out values of arrays using indexes. We can change the value of that element.

            Console.WriteLine($"The value of myInts2[0] is '{myInts2[0]}'.");

            myInts2[0] += 5;

            Console.WriteLine($"The value of myInts2[0] is now '{myInts2[0]}'.");

            /***** Multi-dimensional Arrays *****/
            

            /***** Random Number Generation *****/
        }
    }
}
