﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.DTO
{
    public class ConcertDTO
    {
        public string ConcertName { get; set; }
        public string ConcertDescription { get; set; }
        public string ConcertImage {  get; set; }
        public double Rating { get; set; }
    }
}
