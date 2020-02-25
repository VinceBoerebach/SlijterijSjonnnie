using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SlijterijApp.Models
{
    public class WhiskeyModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public double AlcoholPercentage { get; set; }
        public string Type { get; set; }
        public byte[] Label { get; set; }
        public int AvalableAmount { get; set; }
    }
}