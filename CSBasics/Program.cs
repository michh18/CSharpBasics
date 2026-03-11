namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. declaring a variable
            double pi = 3.14;
            // Console.WriteLine(pi);

            // 3. declaring a boolean (true or false)
            bool isLearningCSharp = true;
            // Console.WriteLine(isLearningCSharp);

            // 4. reassigning a variable
            string favouriteFilm = "Spider-Man: Across the Spider-Verse";
            // Console.WriteLine("My favourite film is: " + favouriteFilm);
            favouriteFilm = "High School Musical"; // reassigning the variable to a new value
            // Console.WriteLine("My new favourite film is: " + favouriteFilm);

            // 5. (cont.) calling the method to print Greeting for name "Michelle"
            string firstName = "Michelle";
            printGreeting(firstName); // output Hello, Michelle 

            // 6. (cont.) calling method to subtract 3 from 7 
            subtractNumbers(7, 3); // output 4 

            // 7. (cont.) 
            Console.WriteLine(isStringLonger("Hello", 6)); // output false as length of "Hello" is less than 6

            // 8. (cont.) assigning the return value of a method to a variable
            int additionResult = Sum(10, 5);
            Console.WriteLine(additionResult); // output 15

            // -------------------- New Book Class Implementation --------------------
            
            // 9-13. creating a class called 'Book' with properties and methods (see Book.cs for implementation)
            // Create a new book 
            Book myBook = new Book("The Great Gatsby", 180);

            // Print title and page
            Console.WriteLine($"Book: {myBook.Title}");
            Console.WriteLine($"Current Page: {myBook.CurrentPage}");

            // 14. Attempting to set CurrentPage directly will result in a compile-time error because it has a private setter
            // book.CurrentPage = 50; 

            // Turn page forward by 10 pages
            myBook.TurnPage(10);
            Console.WriteLine($"New Current Page in '{myBook.Title}' is: {myBook.CurrentPage}");
        }

        // 5. method declaration
        private static void printGreeting(string name) // used camelCase as method is private, void return type as it won't return value
        {
            Console.WriteLine("Hello, " + name);
        }

        // 6. 'a tale of two numbers' = method that takes 2 numbers, subtracts one from the other and prints result
        private static int subtractNumbers(int num1, int num2)
        {
            return num1 - num2; 
        }

        // 7. methods with two input types
        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number; // returns true if length of word is greater than number, otherwise false
        }

        // 8. sum method that takes two integers, adds them together and returns the result
        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
