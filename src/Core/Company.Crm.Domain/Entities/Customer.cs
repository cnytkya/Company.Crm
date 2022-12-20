﻿using Company.Framework.Entity;

namespace Company.Crm.Domain.Entities
{
    public class Customer : BaseAuditEntity, IEntity
    {
        public int UserId { get; set; }
        public string? IdentityNumber { get; set; }
        public int? GenderId { get; set; }
        public int? TitleId { get; set; }
        public int? CompanyName { get; set; }
        public int? StatusTypeId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
