using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryApi.Models;

namespace LibraryApi.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<LoanedBook> LoanedBooks { get; set; }
        public int SumOfOverdueFees { get; set; }
        public string Name { get; set; }
        public List<DateTime> Duedates { get; set; }
    }
}