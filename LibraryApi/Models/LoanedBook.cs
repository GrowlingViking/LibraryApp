using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApi.Models;

namespace LibraryApi.Models
{
    public class LoanedBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime InDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsOverdue { get; set; }
        public int OverdueFee { get; set; }
    }
}