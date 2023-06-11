using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_with_cosmosdb.models
{
    public class Employer
    {
        public string? Id { get; set;}
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

         public string? Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

        public string? EmployerPhone { get; set; }

    }
}