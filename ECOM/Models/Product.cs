﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECOM.Models
{
    public class Product
    {
        public int Id
        { 
            get; set; 
        }
        public string Name
        { 
            get; set; 
        }
        public int Price
        {
            get;set;
        }
        public int CategoryId
        {
            get;set;
        }
    }
}