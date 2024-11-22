namespace ST10298613_ContractMonthlyClaimSystem.Models
{
    public class Approval
    {
        public int ApprovalId { get; set; }
        public string ApprovedBy { get; set; }
        public string Status { get; set; } // Approved, Rejected
        public string Comments { get; set; }
        public int ClaimId { get; set; }
        public Claim Claim { get; set; }
    }
}
