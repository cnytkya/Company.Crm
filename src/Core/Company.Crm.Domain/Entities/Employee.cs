﻿using Company.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Crm.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public int UserId { get; set; }
        public string? IdentityNumber { get; set; }
        public int? GenderId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? StatusTypeId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
