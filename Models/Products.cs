﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryid { get; set; }
        public string categoryname { get; set; }
    }
}