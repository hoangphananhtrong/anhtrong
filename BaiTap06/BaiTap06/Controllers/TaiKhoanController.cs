﻿using BaiTap06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap06.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKi(TaiKhoanViewmodel taiKhoan)
        {
            //if (taiKhoan == null && taiKhoan.Password)
        {
             //taiKhoan.Password = taiKhoan.Password + "_chuoi_ma_hoa";
        }
            return View(taiKhoan);
        }
    }
}
