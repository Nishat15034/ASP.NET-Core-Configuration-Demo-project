﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
	public class TitleConfiguration
	{
		public string WelcomeMessage { get; set; }
		public bool ShowWelcomeMessage { get; set; }
		public string Color { get; set; }
		public bool UseRandomTitleColor { get; set; }
	}
}
