using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTest.Model
{
    public class TokenRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
