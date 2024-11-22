using ST10298613_ContractMonthlyClaimSystem.Data;
using Microsoft.EntityFrameworkCore;
using ST10298613_ContractMonthlyClaimSystem.Models;

namespace ST10298613_ContractMonthlyClaimSystem.Services
{
    public class ClaimService
    {
        private readonly ApplicationDbContext _context;

        public ClaimService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Claim>> GetPendingClaimsAsync()
        {
            return await _context.Claims.Where(c => c.Status == "Pending").ToListAsync();
        }

        public async Task ApproveClaimAsync(int claimId, string approver)
        {
            var claim = await _context.Claims.FindAsync(claimId);
            if (claim != null)
            {
                claim.Status = "Approved";
                _context.SaveChanges();
            }
        }

        public async Task RejectClaimAsync(int claimId, string approver, string comments)
        {
            var claim = await _context.Claims.FindAsync(claimId);
            if (claim != null)
            {
                claim.Status = "Rejected";
                _context.SaveChanges();
            }
        }
    }
}
