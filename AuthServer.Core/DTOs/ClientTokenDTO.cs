﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.DTOs
{
    public class ClientTokenDTO
    {
        public string AccesToken { get; set; }
        public DateTime AccessTokenExpiration { get; set; }
    }
}
