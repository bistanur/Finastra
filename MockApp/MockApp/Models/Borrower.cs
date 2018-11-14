using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockApp.Models
{
    public class Borrower
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string DateOfBirth { get; set; }
        public int SSN { get; set; }
    }
}
