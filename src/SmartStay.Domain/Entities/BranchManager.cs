namespace SmartStay.Domain.Entities
{
    public class BranchManager
    {
        public int UserId { get; set; }                                         
        public int BranchId { get; set; }
        public User User { get; set; } 
        public Branch Branch { get; set; } 
    }
}
