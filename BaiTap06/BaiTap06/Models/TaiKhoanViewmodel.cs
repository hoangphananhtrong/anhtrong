using Microsoft.AspNetCore.Mvc;

namespace BaiTap06.Models
{
    public class TaiKhoanViewmodel : Controller
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
