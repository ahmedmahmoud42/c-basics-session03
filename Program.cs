using System.Text;
using System.Xml;

namespace Assignmrnt2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            // Declare string title = "clean code";. Call title.ToUpper()
            // and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
            string Title = "Clean Code";
            string upperTitle = Title.ToUpper();
            Console.WriteLine(Title);      // Clean Code
            Console.WriteLine(upperTitle); // CLEAN CODE

            #endregion

            #region Question 2
            // Declare two separate string variables, both set to the literal "Clean Code".
            // Use ReferenceEquals to check if they point to the same object in memory.
            string cleanCode1 = "Ahmed";
            string cleanCode2 = "Ahmed";
            Console.WriteLine(Object.ReferenceEquals(cleanCode1,cleanCode2)); // True

            #endregion

            #region Question 3
            // Create a StringBuilder, Append() the text "Book List",
            // then Append() " - Updated" onto the same object.Print the final result.
            StringBuilder sb = new StringBuilder("Book List");
            Console.WriteLine(sb.Append(" - Updated")); // Book List - Updated

            #endregion

            #region Question 4
            // Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            // Then Print the result.
            Console.WriteLine(sb.Replace("Book List","Library")); // Library - Updated
            #endregion

            #region Question 5
            // Given string title = "Clean Code"; and int pages = 464;,
            // build the sentence "Book: Clean Code, Pages: 464" using the + operator.
            string title = "Clean Code";
            int Pages = 464;
            Console.WriteLine("Book:"+" " + title+" , Pages : "+""+Pages); // Book: Clean Code , Pages : 464

            #endregion

            #region Question 6
            // Build the same sentence as above, but using string interpolation ($"...").
            Console.WriteLine($"Book: {title} , Pages : {Pages}"); // Book: Clean Code , Pages : 464

            #endregion

            #region Question 7
            // Build the same sentence again, but using string.Format().
            Console.WriteLine(string.Format("Book: {0} , Pages : {1}",title , Pages)); // Book: Clean Code , Pages : 464
            #endregion

            #region Question 8
            // Given int pages = 464;, write an if / else statement that prints "Long Book"
            // if pages is greater than 300, otherwise prints "Short Book".
            int pages = 464;
            if (pages >300)
                Console.WriteLine("Long Book."); // Will Occur
            else
                Console.WriteLine("Short Nook.");

            #endregion

            #region Question 9
            // Given int pages = 464; and bool isAvailable = true;,
            // print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.
            int page = 464;
            bool isAvailable =  true;
            if (page>300 && isAvailable is true )
                Console.WriteLine("You Can Borrow This Book");  // Will Occur
            #endregion

            #region Question 10
            // Given string title = "Refactoring";,
            // write a switch statement that prints "Great choice!" if the title is"Clean Code",
            // "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else
            string title_ = "Refactoring";
            switch (title_)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!"); // Will Occur
                    break;
                default :
                    Console.WriteLine("Never heard of it");
                    break;

            }

            #endregion

            #region Question 11
            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book"
            // into a variable sizeLabel(same rule as question 8: long if pages > 300).
            int Pages_ = 464;
            string sizeLabel = Pages_ > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel); // Long Book 


            #endregion

            #region Question 12
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            // use a for loop to print each book with its position number, like 1.Clean Code.
            string[] books = { "CleanCode", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
                Console.WriteLine($"{i + 1}. {books[i]}");


            #endregion

            #region Question 13
            // Using the same books array, use a while loop to print every book title
            int j = 0;
            while (j<books.Length)
            {
                Console.WriteLine(books[j]);
                j++;
            }


            #endregion

            #region Question 14
            // Write a do-while loop that prints "Checking book..." exactly 3 times
            int w = 0;
            do
            {

                Console.WriteLine("Checking book...");
                w++;
            }
            while (w <= 2);
            #endregion

            #region Question 15
            // Using the same books array, use a foreach loop to print every book title.
            foreach (string book in books)
                Console.WriteLine(book);
            #endregion


            #region Question 16
            // Using the same books array, loop through it and print each title,
            // but stop completely (break) once you reach "Refactoring".
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                    break;
                Console.WriteLine(books[i]);
            
            }


            #endregion


            #region Question 17
            // Using the same books array,
            // print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(books[i]);

            }


            #endregion

            #region Question 18
            // Write a method PrintFirstBook() that prints the first book in the books array.
            // If the array is empty, use return to exit the method early instead of printing anything.

            Console.Write("Functuin result : ");
            PrintFirstBook(books);
            static void PrintFirstBook(string []Array)
            {
                if (Array.Length==0)
                    return;
                Console.WriteLine(Array[0]);
                return;
            }



            #endregion


        }
    }
}
