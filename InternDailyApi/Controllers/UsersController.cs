using Microsoft.AspNetCore.Mvc;
using InternDailyApi.Models;

namespace InternDailyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public string Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return "Kayıt başarılı";
        }

        [HttpPost("login")]
        public ActionResult<User> Login(User login)
        {
            var user = _context.Users
                .FirstOrDefault(x =>
                    x.Username == login.Username &&
                    x.Password == login.Password &&
                    x.Usertype == login.Usertype
                );

            if (user == null)
                return Unauthorized("Kullanıcı adı veya şifre hatalı");

            return user;
        }

        [HttpGet("interns")]
        public List<string> GetInterns()
        {
            return _context.Users
                .Where(x => x.Usertype == "Stajyer")
                .Select(x => x.Username)
                .ToList();
        }
    }
}
