using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(GetMenuItems());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        private List<MenuItem> GetMenuItems()
        {
            return
            [
                new()
                {
                    Name = "Human Resources",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-users",
                    Link = "#"
                },
                new()
                {
                    Name = "Programmes & Projects",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-project-diagram",
                    Link = "#"
                },
                new()
                {
                    Name = "Tender",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-file-signature",
                    Link = "#"
                },
                new()
                {
                    Name = "Contracts",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-handshake",
                    Link = "#"
                },
                new()
                {
                    Name = "Payments",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-money-bill-wave",
                    Link = "#"
                },
                new()
                {
                    Name = "Variation Order",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-exchange-alt",
                    Link = "#"
                },
                new()
                {
                    Name = "Accounts & Audits",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-calculator",
                    Link = "#"
                },
                new()
                {
                    Name = "Reports",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-chart-bar",
                    Link = "#"
                },
                new()
                {
                    Name = "Administration",
                    Count = 10,
                    Description = "Assigned to you",
                    Icon = "fas fa-cog",
                    Link = Url.Action("Index", "Home", new { area = "Setups" }),
                    HasCount = false
                }
            ];
        }
    }
}