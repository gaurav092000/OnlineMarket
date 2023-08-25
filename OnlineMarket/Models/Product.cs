using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class Product
    {
        [Key]
         public int Pro_Id { get; set; }

        [Required]
        public string Pro_Name { get; set; }

        [Required]
        public string Pro_Image { get; set; }

        [Required]
        public int Pro_Price { get; set;}

        [Required]
        public string Pro_Description { get; set;}

        public 




    }
}