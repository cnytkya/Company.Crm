namespace Company.Framework.Entity
{
    public abstract class BaseAuditEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? DeletedAt { get; set; }
    }
    
}
