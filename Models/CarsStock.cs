﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CarsStock
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarPrice { get; set; }
        public string CarColor { get; set; }

        public string Name { get; set; }
    }
}