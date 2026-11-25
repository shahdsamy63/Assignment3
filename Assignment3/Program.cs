using System.Text;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q01
            string title = "clean code", upperTitle= title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            //Q02
            string str1 = "clean code", str2 = "clean code";
            Console.WriteLine(object.ReferenceEquals(str1,str2));

            //Q03
            StringBuilder st = new StringBuilder("");
            st.Append("Book List");
            st.Append("-Updated");
            Console.WriteLine(st);

            //Q04
            st.Replace("Book List", "Library");
            Console.WriteLine(st);

            //Q05
            string title1 = "Clean Code";
             int pages = 464;
            Console.WriteLine("Book: "+title1+",Pages: "+pages);

            //Q06
            Console.WriteLine($"Book: { title1},Pages: {pages} ");

            //Q07
            Console.WriteLine(string.Format("Book: {0},Pages: {1}", title1,pages));

            //Q08
            int ipages = 464;
            if (pages > 300)
                Console.WriteLine("Long Book");
            else Console.WriteLine("Short Book");

            //Q09
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");


            //Q10
            string rtitle = "Refactoring";
            switch (rtitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                                            Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }


            //Q11
            string sizeLabel = (ipages > 300 ? "Long Book" : "Short Book");

            //Q12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; ++i)
            {
                Console.WriteLine($"{i+1}. {books[i]}");

            }

            //Q13
            int j = 0;
            while (j < books.Length)
            {

                Console.WriteLine($"{j + 1}. {books[j]}");
                if (j == books.Length) break;
                ++j;
            }

            //Q14
            int cnt = 0;
            do { Console.WriteLine("Checking book..."); ++cnt; }
            while (cnt <= 2);
               

            //Q15
            foreach (string book in books)
            {
                Console.WriteLine(book);

            }

            //Q16
            for (int i = 0; i < books.Length; ++i)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
                if (books[i] == "Refactoring") break;

            }

            //Q17

            for (int i = 0; i < books.Length; ++i)
            {
                if (books[i] == "The Pragmatic Programmer") continue;
                Console.WriteLine($"{i + 1}. {books[i]}");

            }

            //Q18
             string PrintFirstBook(string[] books){
                if (books.Length == 0) return"";
                    //Console.WriteLine(books[0]);
                return "";
            }
            PrintFirstBook(books);










        }

    }
}
