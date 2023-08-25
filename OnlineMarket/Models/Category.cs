using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required]
        public string catName { get; set; }

        [Required]
        public string CatImage { get; set; }

        public int ad_Id { get; set; }

        [ForeignKey("ad_id")]
        public  virtual Category category { get; set; }
    }
}