

namespace Task_23_05
{
    public class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook (Book book)
        {
            Array.Resize (ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetBookById (int idNum)
        {
            Book[] bookById = Array.Empty<Book> (); 
            foreach (Book book in Books)
            {
                
                if (book.Id == idNum)
                {
                    Array.Resize (ref bookById, bookById.Length + 1);
                    bookById[bookById.Length - 1] =book;
                }
                
            }
            return bookById;
        }

        public Book[] GetBookByName(string byName)
        {
            Book[] bookByName = Array.Empty<Book>();
            foreach (Book book in Books)
            {

                if (book.Name == byName)
                {
                    Array.Resize(ref bookByName, bookByName.Length + 1);
                    bookByName[bookByName.Length - 1] = book;
                }

            }
            return bookByName;
        }
       

        public Book[] GetFilteredBooksGenre (string byGenre)
        {
            Book[] filteredBooksGenre = Array.Empty<Book>();
            foreach (Book book in Books)
            {

                if (book.Genre == byGenre)
                {
                    Array.Resize(ref filteredBooksGenre, filteredBooksGenre.Length + 1);
                    filteredBooksGenre[filteredBooksGenre.Length - 1] = book;
                }

            }
            return filteredBooksGenre;
        }

        public Book[] GetFilteredBooksPrice(double minPrice, double maxPrice)
        {
            Book[] filteredBooksPrice = Array.Empty<Book>();
            foreach (Book book in Books)
            {

                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref filteredBooksPrice, filteredBooksPrice.Length + 1);
                    filteredBooksPrice[filteredBooksPrice.Length - 1] = book;
                }

            }
            return filteredBooksPrice;
        }
    }
}
