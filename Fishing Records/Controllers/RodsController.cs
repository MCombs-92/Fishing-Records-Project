using Fishing_Records.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Fishing_Records.Controllers {

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

    public class RodsController : ApiController {

        private FRDBContext db = new FRDBContext();

        [HttpGet]
        [ActionName("List")]
        public IEnumerable<Rod> List() {
            return db.Rods.ToList();
        }

        [HttpGet]
        [ActionName("Get")]
        public Rod Get(int? Id) {
            if (Id == null) {
                return null;
            }
            return db.Rods.Find(Id);
        }

        [HttpPost]
        [ActionName("Create")]
        public bool Create(Rod rod) {
            if (rod == null) {
                return false;
            }
            if (!ModelState.IsValid) {
                return false;
            }
            db.Rods.Add(rod);
            db.SaveChanges();
            return true;
        }

        [HttpPost]
        [ActionName("Change")]
        public bool Change(Rod rod) {
            if (rod == null) {
                return false;
            }

            if (!ModelState.IsValid) {
                return false;
            }

            var r = db.Rods.Find(rod.Id);
            r.Make = rod.Make;
            r.Model = rod.Model;
            r.Power = rod.Power;
            r.Action = rod.Action;

            db.SaveChanges();
            return true;
        }

        [HttpPost]
        [ActionName("Remove")]
        public bool Remove(Rod rod) {
            if (rod == null) {
                return false;
            }
            if (!ModelState.IsValid) {
                return false;
            }

            var r = db.Rods.Find(rod.Id);
            db.Rods.Remove(r);
            db.SaveChanges();
            return true;
        }

    }
}
