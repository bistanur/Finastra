using MockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockApp.Services
{
    public class InMemoryBorrowerData : IBorrowerData
    {
        public InMemoryBorrowerData()
        {
            _borrowers = new List<Borrower>
            {
                new Borrower { Username = "JDoe", Name = "John Doe", Amount = 500, DateOfBirth = "08/08/1992", SSN=123123123},
                new Borrower { Username = "JaDoe", Name = "Jane Doe", Amount = 100, DateOfBirth = "08/08/1995", SSN=223123123},
                new Borrower { Username = "SK1990", Name = "Simon Kurt", Amount = 1000, DateOfBirth = "08/08/1990", SSN=323123123}
            };
        }
        
        public IEnumerable<Borrower> GetAll()
        {
            return _borrowers.OrderBy(r => r.Name);
        }

        List<Borrower> _borrowers;
    }
}
