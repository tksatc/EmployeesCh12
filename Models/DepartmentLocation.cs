using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesCh12.Models
{
    // Linking table for M:M; composite key to be created using Fluent API
    public class DepartmentLocation
    {
        // Composite PK and FK for Department
        public int DepartmentID { get; set; }
        
        //Composite PK and FK for Location
        public int LocationID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
