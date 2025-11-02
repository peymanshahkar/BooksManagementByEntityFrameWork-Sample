using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace BookSManagement.Entity
{
    public class Book
    {
        public Book()
        {
           
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Author { get; set; }
        [Required]
        [Index]
        [MaxLength(100)]
        public string ISBN { get; set; }
        [Required]
        public int YearPublished { get; set; }


        public string GetBookInfo()
        {

            string info = $"Id:{Id} Title:{Title} Author:{Author} YearPublished:{YearPublished} ISBN:{ISBN}";
            return info;
        }


       
    }
    

}
