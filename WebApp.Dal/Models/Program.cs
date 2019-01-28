using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Dal.Models
{
    public class Program
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset EffectiveDate { get; set; }
        public string BusinessLine { get; set; }
        public int Year { get; set; }
        public string Client { get; set; }
    }
}