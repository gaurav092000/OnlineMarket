using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class User
    {
        [Key]
        public int U_Id { get; set; }

        [Required]
        public string U_Name { get; set;}

        [Required]
        public string U_Email { get; set;}


        [Required]
        public string U_Phone { get; set;}
        [Required]
        public string U_image { get; set;}
        
        [Required]
        public string U_Password { get; set;}
        

    }
}