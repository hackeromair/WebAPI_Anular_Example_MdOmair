using System;
using System.Collections.Generic;

namespace WebAPITravel.Models
{
    public partial class Travel
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Destination { get; set; }
        public string Photo { get; set; }
        public string Rating { get; set; }
        public string Besttime { get; set; }
        public string Email { get; set; }
    }
}
