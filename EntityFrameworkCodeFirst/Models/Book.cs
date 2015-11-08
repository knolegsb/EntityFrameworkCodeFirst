using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength]
        public string Description { get; set; }
        [MaxLength(20)]
        public string ISBN { get; set; }
        public DateTime DatePublished { get; set; }
        public Category Category { get; set; }
    }
}