using MoviesApplication.Db;
using MoviesApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesApplication.Controllers
{
    public class MoviesController : Controller
    {
        MoviesApplicationDb _db = new MoviesApplicationDb();
        //
        // GET: /Movies/

        public ActionResult Index()
        {
            var model = _db.Movies.ToList();
            return View(model);
        }

        //
        // GET: /Movies/Details/5

        public ActionResult Details(int id)
        {
            var model = _db.Movies.Find(id);
            return View(model);
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movies/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Movie movie)
        {
            try
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Movies/Delete/5

        public ActionResult Delete(int id)
        {
            var model = _db.Movies.Find(id);
            return View(model);
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Movie movie)
        {
            try
            {
                _db.Entry(movie).State = EntityState.Deleted;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
