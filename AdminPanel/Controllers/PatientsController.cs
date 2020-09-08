using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Models;
using RoleBasedAuthorization.Models;


namespace AdminPanel.Controllers
{
    public class PatientsController : Controller
    {
        private readonly MyDbContext pdc; 
        public PatientsController (MyDbContext pdc )
        {
            this.pdc = pdc; 
        }

        public IActionResult Index()
        {
            return View(pdc.Patients.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePatients(Patients patient) 
        {
            pdc.Patients.Add(patient);
            pdc.SaveChanges();
            return RedirectToAction("Index", "Patients");

        }
         
        public IActionResult Update (int id )
        {
            return View(pdc.Patients.Where(a => a.Id == id).First());

        }


        [HttpPost]
        public IActionResult UpdatePatients (Patients patient)
        {
            Patients p = pdc.Patients.Where(s => s.Id == patient.Id).First();
            p.FirstName = patient.FirstName;
            p.LastName = patient.LastName;
            p.Phone = patient.Phone;
            p.HealthCondition = patient.HealthCondition;
            pdc.SaveChanges();
            return RedirectToAction("Index", "Patients");
        }

        /* [HttpPost]
              public bool Delete (int id ){
              try {
                  Patients patient = pdc.Patients.Where(s => s.Id == id).First();
                  pdc.Patients.Remove(patient);
                  pdc.SaveChanges();
                  return true;
                 }
              catch (System.Exception)
              {
                  return false;
              }

          } */

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var patients = pdc.Patients.SingleOrDefault(m => m.Id == id);
            if (patients == null)
            {
                return NotFound();
            }

            return View(patients);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var patients = pdc.Patients.SingleOrDefault(m => m.Id == id);
            pdc.Patients.Remove(patients);
            pdc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientsExists(int id)
        {
            return pdc.Patients.Any(e => e.Id == id);
        }

    }

}