﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ConfigurationEntity
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
