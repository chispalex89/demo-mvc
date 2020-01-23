using demo_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo_mvc.Controllers
{
    public class PokemonController : Controller
    {
        List<PokemonModel> pokemonList = new List<PokemonModel>();
        //
        // GET: /Pokemon/
        public ActionResult Index()
        {
            
            return View(pokemonList);
        }

        //
        // GET: /Pokemon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pokemon/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var pokemon = new PokemonModel
                {
                    Name = collection["Name"],
                    Number = int.Parse(collection["Number"])
                };

                pokemonList.Add(pokemon);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pokemon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pokemon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pokemon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pokemon/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
