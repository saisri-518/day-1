using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class DboTableuser
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Usermail { get; set; }
        public string Password { get; set; }
    }
}
