namespace Task_23_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Cinayet ve Ceza", 25.00, "Dram");
            Book book2 = new Book(2, "Anna Karenina", 20.50, "Klassika");
            Book book3 = new Book(3, "Kor qlazoktan baxir", 17.00, "Komediya");
            Book book4 = new Book(4, "Kecel qizin horukleri", 21.30, "Tragikomediya");
            Book book5 = new Book(5, "Skeletlerin muskulu", 7.00, "Dram");
            Book book6 = new Book(6, "Yoxluq ozude bir varliq mi?", 30.00, "Felsefi");

            Library corat = new Library();
            corat.AddBook(book1);
            corat.AddBook(book2);
            corat.AddBook(book3);
            corat.AddBook(book4);
            corat.AddBook(book5);
            corat.AddBook(book6);


           foreach (var book in corat.GetBookById(6))
            {
                Console.WriteLine($"Id: {book.Id}, \nName: {book.Name}, \nPrice: {book.Price}; \nGenre: {book.Genre}\n\n");
            }

            foreach (var book in corat.GetBookByName("Kecel qizin horukleri"))
            {
                Console.WriteLine($"Name: {book.Name}, \nId: {book.Id}, \nPrice: {book.Price}; \nGenre: {book.Genre}\n\n");
            }

            foreach (var book in corat.GetFilteredBooksGenre("Dram"))
            {
                Console.WriteLine($"Genre: {book.Genre} \nId: {book.Id}, \nName: {book.Name}, \nPrice: {book.Price}; \n\n");
            }

            foreach (var book in corat.GetFilteredBooksPrice(15,27))
            {
                Console.WriteLine($"Price: {book.Price}; \nId: {book.Id}, \nName: {book.Name}, \nGenre: {book.Genre} \n\n");
            }
        }
    }
}
