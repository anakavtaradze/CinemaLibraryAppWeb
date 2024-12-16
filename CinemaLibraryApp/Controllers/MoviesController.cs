using Microsoft.AspNetCore.Mvc;
using CinemaLibraryApp.Models;
using CinemaLibraryApp.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CinemaLibraryApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Movies> movieList = this._context.Movies;
            return View(movieList);
        }
        public IActionResult Movie(int id)
        {
            
            return View(this._context.Movies.Include(e=>e.Director).Include(e=>e.Genre).Include(e=>e.Actors).Where(e=>e.Id==id).FirstOrDefault());
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
