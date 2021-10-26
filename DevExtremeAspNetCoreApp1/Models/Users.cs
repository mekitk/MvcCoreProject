﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
