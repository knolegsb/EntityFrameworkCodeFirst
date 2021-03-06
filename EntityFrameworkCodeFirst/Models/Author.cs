﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [MaxLength(35)]
        public string FirstName { get; set; }
        [MaxLength(35)]
        public string LastName { get; set; }
        [MaxLength]
        public string Biography { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}