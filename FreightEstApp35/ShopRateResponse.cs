﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreightEstApp35
{
    public class ShopRateResponse
    {
        public int ResponseStatusCode { get; set; }
        public String[] Alert { get; set; }
        public UPSService[] UPSServices { get; set; }
    }
}
