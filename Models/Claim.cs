namespace ST10298613_ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public required string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public string DocumentPath { get; set; }
        public decimal TotalPayment => HoursWorked * HourlyRate; // Computed property

    }
}
