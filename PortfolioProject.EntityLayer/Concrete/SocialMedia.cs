﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public bool Status { get; set; }
    }
}
