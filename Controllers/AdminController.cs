using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ST10298613_ContractMonthlyClaimSystem.Data;
using ST10298613_ContractMonthlyClaimSystem.Hubs;
using ST10298613_ContractMonthlyClaimSystem.Models;

namespace ST10298613_ContractMonthlyClaimSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ManageClaims()
        {
            var claims = _context.Claims
                .Select(c => new Claim
                {
                    Id = c.Id,
                    LecturerName = c.LecturerName,
                    Status = c.Status,
                    HoursWorked = c.HoursWorked,
                    HourlyRate = c.HourlyRate,
                    DocumentPath = c.DocumentPath,
                    // TotalPayment is computed in the model
                })
                .ToList();

            return View(claims);
        }


        public async Task<IActionResult> Approve(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim != null)
            {
                claim.Status = "Approved";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("ManageClaims");
        }

        public async Task<IActionResult> Reject(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim != null)
            {
                claim.Status = "Rejected";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("ManageClaims");
        }

    }

}
