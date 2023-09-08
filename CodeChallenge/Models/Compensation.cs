using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace CodeChallenge.Models
{
    public class Compensation
    {
        [Key]
        public String employee { get; set; }

        public double salary { get; set; }

        public DateTime effectiveDate { get; set; }

        public Compensation()
        {
            effectiveDate = DateTime.Now;
        }
    }
}
