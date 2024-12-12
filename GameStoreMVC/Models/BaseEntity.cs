namespace GameStoreMVC.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTimne { get; set; }
        public bool IsDeleted { get; set; }
    }
}
