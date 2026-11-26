using System.Text;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQ1:");
            #region Q01
            //String  is immutable
            string title = "Clean Code";
            string upperTitle = title.ToUpper();

            Console.WriteLine("Title  is  "+ title);
            Console.WriteLine("Upper Ttile is , "+ upperTitle);

            #endregion
            Console.WriteLine("\nQ2:");
            #region Q02 
            //string bool , string Interning 
            string s1 = "Clean Code";
            string s2 = "Clean Code";

            Console.WriteLine($"s1 ==s2  => {s1==s2}" );
            Console.WriteLine($"ReferenceEquals(s1,s2) => {ReferenceEquals(s1, s2)} ");      
            Console.WriteLine($"s1.equals(s2) =>  {s1.Equals(s2)}");

            #endregion
            Console.WriteLine("\nQ3:");
            #region Q3
            //string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("_ Updated");
            Console.WriteLine("String Builder is : " + sb);

            #endregion
            Console.WriteLine("\nQ4:");
            #region Q4
            //string builder
            sb.Replace("Book List", "Library");
            Console.WriteLine("String Builder is : " + sb);

            #endregion
            Console.WriteLine("\nQ5:");
            #region Q5
            //Concatenation 
            int pages = 464;
            Console.WriteLine("Book: " + title + " , Pages: " + pages);

            #endregion
            Console.WriteLine("\nQ6:");
            #region Q6
            //Concatenation 
            Console.WriteLine($"Book:  {title} , Pages: {pages}"  );


            #endregion
            Console.WriteLine("\nQ7:");
            #region Q7
            //Concatenation 
            Console.WriteLine(string.Format("Book:  {0} , Pages: {1}", title,pages) );


            #endregion
            Console.WriteLine("\nQ8:");
            #region Q8     
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }


            #endregion
            Console.WriteLine("\nQ9:");
            #region Q9   
            bool isAvailable = true;

            if (pages > 300 && isAvailable )
                Console.WriteLine("Long Book , You can Borrow It ");

            #endregion
            Console.WriteLine("\nQ10:");
            #region Q10   
            title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break; 
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;          
               default:
                    Console.WriteLine("Never heard of it");
                    break;

            }


            #endregion
            Console.WriteLine("\nQ11:");
            #region Q11  
            //ternary operator
            string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
            Console.WriteLine("Size Label : " + sizeLabel);

            #endregion
            Console.WriteLine("\nQ12:");
            #region Q12  
            //forloop
            string[] books = ["Clean Code", "The Pragmatic Program","Refactoring"];
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {books[i]}");
            }

            #endregion
            Console.WriteLine("\nQ13:");
            #region Q13  
            //while loop
            int index = 0;
            while(index < books.Length)
            {
                Console.WriteLine($"{index + 1} : {books[index]}");
                index++;
            }

            #endregion
            Console.WriteLine("\nQ14:");
            #region Q14  
            //Do while loop
            int iter = 0;
            do
            {
           
                Console.WriteLine("Checking Book ...");
                iter++;
            } while (iter < 3);
            #endregion
            Console.WriteLine("\nQ15:");
            #region Q15  
            //foreach

            foreach (var book in books)
            {
                Console.WriteLine("Book title : " + book);
            }
            #endregion
            Console.WriteLine("\nQ16:");
            #region Q16  
            //foreach+Jump 

            foreach (var book in books)
            {
                if (book.Equals("Refactoring"))
                {
                    break;
                }
                Console.WriteLine("Book title : " + book);

            }
            #endregion
            Console.WriteLine("\nQ17:");
            #region Q17  
            //foreach+Jump 

            foreach (var book in books)
            {
                if (book.Equals("The Pragmatic Program"))
                {
                    continue;
                }
                Console.WriteLine("Book title : " + book);

            }
            #endregion
            Console.WriteLine("\nQ18:");
            #region Q18  
            //method

            void printFirstBook(string[] booksArr)
            {
                if (books.Length <= 0)
                {
                    return;
                }
                Console.WriteLine("First book is : "+ booksArr[0]);
            }
            printFirstBook(books);
            #endregion
             
        }
    }
}
