﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class Admin
    {
        [Key]
        public  int ad_id { get; set; }

        [Required]
       public  string ad_name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
       public  string ad_password { get; set; }




    }
}