using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Translator.WebUI.Models;

namespace Translator.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Languages()
        {
            return View();
        }

        #region UserManage

        public async Task<ActionResult> Users()
        {
            return View(await _userManager.Users.ToListAsync());
        }


        #endregion

    }
}