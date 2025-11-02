using BookSManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSManagement.Data
{
    public class BookContext:DbContext
    {
      
        public BookContext():base(nameOrConnectionString: Properties.Settings.Default.DefaultConnectionString)
        {
           
            
        
        }    
        public DbSet<Book> Books { get; set; }

    }
}
