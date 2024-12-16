using Microsoft.AspNetCore.Mvc;
using CinemaLibraryApp.Models;
using CinemaLibraryApp.Data;
using System;
using System.Collections.Generic;

namespace CinemaLibraryApp.Controllers
{
    public class DirectorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectorsController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Director> directorList = this._context.Directors;
            return View(directorList);
        }
        public IActionResult Director(int id)
        {
            foreach (var director in this._context.Actors)
            {
                if (director.Id == id)
                    return View(director);
            }
            return View();
        }
    }
}
