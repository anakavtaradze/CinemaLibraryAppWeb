using Microsoft.AspNetCore.Mvc;
using CinemaLibraryApp.Models;
using CinemaLibraryApp.Data;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CinemaLibraryApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActorsController(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Actor> actorList = this._context.Actors;
            return View(actorList);
        }
        public IActionResult Actor(int id)
        {
            return View(this._context.Actors.Include(e => e.Movies).Where(e => e.Id == id).FirstOrDefault());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Actor actor)
        {
            this._context.Actors.Add(actor);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit()
        {
            return View();
        }
        [HttpPatch]
        public IActionResult Edit(Actor actor)
        {
            this._context.Actors.Update(actor);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            this._context.Actors.Add(actor);
            this._context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
