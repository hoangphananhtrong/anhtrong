using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Models
{
    public class TaiKhoanViewModel : Controller
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}