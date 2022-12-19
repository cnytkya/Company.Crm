namespace Company.Framework.Entity
{
    public abstract class BaseAuditEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    
}
