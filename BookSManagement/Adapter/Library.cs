using BookSManagement.Data;
using BookSManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSManagement.Adapter
{


    public class Library
    {
        private List<Book> _BookS;
        public List<Book> BookS
        {
            get
            {
                FiilBooks();
                return _BookS;
            }
        }
        private void FiilBooks()
        {
            _BookS = context.Books.ToList();
        }
        private BookContext context;
        public Library()
        {
            context = new BookContext();

        }
        private string AddValidation(Book book)
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(book.Title))
                errorMessage += "عنوان کتاب را وارد کنید"+'\n';
            if (string.IsNullOrEmpty(book.Author))
                errorMessage += "نویسنده کتاب را وارد کنید" + '\n';
            if (string.IsNullOrEmpty(book.ISBN))
                errorMessage += "ISBN را وارد کنید"+'\n';
            if (book.YearPublished == 0 || book.YearPublished.ToString().Length < 4)
                errorMessage += "سال انتشار را به درستی وارد کنید";

            return errorMessage;
        }
        public bool AddBook(Book book)
        {
            string validationError = AddValidation(book);

            if (!string.IsNullOrEmpty(validationError))
                throw new Exception(validationError);
            try
            {
                context.Books.Add(book);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool RemoveBook(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
                throw new Exception("لطفا isbn مورد نظر جهت حذف را وارد کنید");

            try
            {
                Book result=GetBookByISBN(isbn);
                if (result != null)
                {
                    context.Books.Remove(result);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("کتاب با شناسه وارد شده وجود ندارد");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        public List<Book> ListBooks()
        {
            return BookS;
        }
        public Book GetBookByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentException("شناسه کتاب نمی تواند خالی باشد", nameof(isbn));
            }

            var result = context.Books.SingleOrDefault(x => x.ISBN == isbn);
            return result;
        }
    }
}
