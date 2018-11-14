using MockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Borrower> Borrowers { get; set; }
    }
}
