﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCodeFirst.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}