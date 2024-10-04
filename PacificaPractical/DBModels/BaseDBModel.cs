namespace PacificaPractical.DBModels
{
    public class BaseDBModel
    {
        public int Id { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
