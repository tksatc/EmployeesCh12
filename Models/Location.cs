﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeesCh12.Models
{
    public enum Type
    {
        Sales, Headquarters, Satellite, Plant, Warehouse
    }
    public class Location
    {
        [Key]
        public int ID { get; set; }

        [DisplayFormat(NullDisplayText = "Sales")]
        public Type? Type { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }

        // Navigation property
        public ICollection<DepartmentLocation> DepartmentLocations { get; set; }
    }
}