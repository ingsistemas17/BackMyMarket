﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.WebApi.Helper
{
    public class AppSettings
    {
        public string OriginCors { get; set; }
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
