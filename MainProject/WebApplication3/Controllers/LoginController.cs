using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "Admin" && userModel.Password == "1234")
            {
                return View("LogInSucess", userModel);
            } else
            {
                return View("LogInFailure", userModel);
            }
        }
    }
}
