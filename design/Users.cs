using System;
using System.Collections.Generic;
using System.Text;

namespace design
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public long ContactNo { get; set; }
        public string Country { get; set; } = "";
        public string Gender { get; set; } = "";
    }
}
