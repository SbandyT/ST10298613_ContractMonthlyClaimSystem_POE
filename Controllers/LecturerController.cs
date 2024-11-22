using Microsoft.AspNetCore.Mvc;

using ST10298613_ContractMonthlyClaimSystem.Data;
using ST10298613_ContractMonthlyClaimSystem.Models;

namespace ST10298613_ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LecturerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitClaim(Claim claim, IFormFile documentPath)
        {
            if (ModelState.IsValid)
            {
                claim.Status = "Pending";
                claim.DocumentPath = await SaveFileAsync(documentPath);
                _context.Claims.Add(claim);
                await _context.SaveChangesAsync();
                return RedirectToAction("ClaimStatus");
            }
            return View(claim);
        }

        private async Task<string> SaveFileAsync(IFormFile file)
        {
            if (file == null) return null;
            var filePath = Path.Combine("wwwroot/uploads", file.FileName);
            using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);
            return $"/uploads/{file.FileName}";
        }
        public async Task<IActionResult> Status(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null) return NotFound();

            return View(claim);
        }
    }
}
