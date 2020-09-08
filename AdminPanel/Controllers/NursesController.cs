using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Ajouter les Réferences Suivants :
using Microsoft.AspNetCore.Mvc; 
using AdminPanel.Models;
using RoleBasedAuthorization.Models;

namespace AdminstrationPlatform.Controllers
{
    public class NursesController : Controller
    {
        // Injection de la base de donnée "PlatformDbContext" a l'aide de la fonction d'injection de dépendances 

        private readonly MyDbContext pdc;

        public NursesController(MyDbContext pdc)

        {
            this.pdc = pdc;

        }  

        public IActionResult Index()
        {
            return View(pdc.Nurses.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        // Exécution de la fonctionnalité CREATE Nurses


        // La version [ HttpPost ] de l'action Créer un nouvel Nurses dans la base de données.
        // Il utilise Entity Framework Core pour créer l'enregistrement.
        [HttpPost]
        public IActionResult CreateNurses(Nurses nurses)
        {
            if (ModelState.IsValid)
            {
                //  Les 2 lignes fait l'insertion de l'enregistrement dans la base de données.
                pdc.Nurses.Add(nurses);
                pdc.SaveChanges();
                return RedirectToAction("Index","Nurses");
            }
            else
                return View(); 
        }

        // Exécution de la fonctionnalité Update Nurses

        public IActionResult Update(int id)
        {
            //La version HttpGet de la méthode d'action Update prend l'id des enregistrements inférmier 
            // Récupère l'enregistrement de la base de données en utilisant EF Core comme
            return View(pdc.Nurses.Where(a => a.Id == id).First());
        }

        /* La version HttpPost de la méthode d'action Update prend la classe Nurses dans son paramètre 
         * qui est lié aux valeurs mises à jour de la vue Update 
         * Les valeurs mises à jour sont enregistrées dans la table de base de données par EF core 
         */

        [HttpPost]
        public IActionResult UpdateNurses (Nurses nurses)
        {
            Nurses n = pdc.Nurses.Where(s => s.Id == nurses.Id).First();
            n.FullName = nurses.FullName;
            n.Email = nurses.Email;
            n.Phone = nurses.Phone;
            pdc.SaveChanges();
            return RedirectToAction("Index", "Nurses");

        }

        // Exécution de la fonctionnalité Delete Nurses : 

      /*  [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Nurses nurses = pdc.Nurses.Where(s => s.Id == id).First();
                pdc.Nurses.Remove(nurses);
                pdc.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }  */


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var nurses = pdc.Nurses.SingleOrDefault(m => m.Id == id);
            if (nurses == null)
            {
                return NotFound();
            }

            return View(nurses);
        }
        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var nurses = pdc.Nurses.SingleOrDefault(m => m.Id == id);
            pdc.Nurses.Remove(nurses);
            pdc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool NursesExists(int id)
        {
            return pdc.Nurses.Any(e => e.Id == id);
        }

    }
}