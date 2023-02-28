﻿using lenderBorrower.Data;
using lenderBorrower.Models;
using Microsoft.AspNetCore.Mvc;

namespace lenderBorrower.Controllers
{
    public class itemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public itemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<item> objList = _db.items;
            return View(objList);
        }
    }
}
