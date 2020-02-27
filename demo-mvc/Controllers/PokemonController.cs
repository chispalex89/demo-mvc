using demo_mvc.Helpers;
using demo_mvc.Models;
using System;
using System.Web;
using System.Web.Mvc;

namespace demo_mvc.Controllers
{
    public class PokemonController : Controller
    {
        //
        // GET: /Pokemon/
        public ActionResult Index()
        {

            return View(Storage.Instance.pokemonList);
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            var name = collection["search"];
            return View(PokemonModel.Filter(name));
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

                if (pokemon.Save())
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(pokemon);
                }
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
