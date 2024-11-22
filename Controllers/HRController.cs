using Microsoft.AspNetCore.Mvc;
using ST10298613_ContractMonthlyClaimSystem.Data;

namespace ST10298613_ContractMonthlyClaimSystem.Controllers
{
    public class HRController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult ManageLecturers()
        {
            var lecturers = _context.Lecturers.ToList();
            return View(lecturers);
        }
    }

}
