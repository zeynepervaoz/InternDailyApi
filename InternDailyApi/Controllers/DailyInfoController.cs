using Microsoft.AspNetCore.Mvc;
using InternDailyApi.Models;

namespace InternDailyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DailyInfoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DailyInfoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Dailyinfo> GetAll()
        {
            return _context.Dailyinfos.ToList();
        }

        [HttpPost]
        public string Add(Dailyinfo info)
        {
            info.Date = DateTime.Now;
            _context.Dailyinfos.Add(info);
            _context.SaveChanges();
            return "Günlük bilgi eklendi";
        }
    }
}
