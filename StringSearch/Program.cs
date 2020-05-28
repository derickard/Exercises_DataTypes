using System;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string mySearchStr = myStr.ToLower();
            string searchTerm;
            Console.Write("Enter search term: ");
            searchTerm = Console.ReadLine().ToLower();
            int index = mySearchStr.IndexOf(searchTerm);
            if(index >= 0)
            {
                Console.WriteLine("{0} was found at index {1} and is {2} characters long", searchTerm, index, searchTerm.Length);
                Console.WriteLine("You are now left with the following: \n --------------");
                Console.WriteLine(myStr.Remove(index,myStr[index+searchTerm.Length]==' ' ? searchTerm.Length+1 : searchTerm.Length));

            } else
            {
                Console.WriteLine("{0} was not found.", searchTerm);

            }

        }
    }
}
