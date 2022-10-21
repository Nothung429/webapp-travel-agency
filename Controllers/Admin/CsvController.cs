using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using static System.Formats.Asn1.AsnWriter;
using System.Text;
using webapp_travel_agency.Data;

namespace webapp_travel_agency.Controllers.Admin
{
    public class CsvController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CsvController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
